﻿using Optional;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToSParser
{
    public delegate ref int BufferIndex();

    public interface UnknownParser<This>
    {
        int GetLimit();
        This Copy(byte[] buffer, BufferIndex index, int size);
    }

    public interface UnknownWriter<This>
    {
        This Copy(byte[] buffer, BufferIndex index);
    }

    public interface Parser<Type, Parent> : UnknownParser<Parser<Type, Parent>> where Parent : UnknownParser<Parent>
    {
        Parent Parse(out Type value);
        void SetMaxLimit(int limit);
    }

    public interface Writer<Type, Parent> : UnknownWriter<Writer<Type, Parent>> where Parent : UnknownWriter<Parent>
    {
        Parent Parse(Type value);
    }

    public interface RepeatParser<Repeat, Parent> : UnknownParser<RepeatParser<Repeat, Parent>> where Parent : UnknownParser<Parent> where Repeat : UnknownParser<Repeat>
    {
        Repeat GetRepeat();
        Parent GetParent();
        Parent Parse(Func<Repeat, RootParser> parser, out int count);
    }

    public interface RepeatWriter<Repeat, Parent> : UnknownWriter<RepeatWriter<Repeat, Parent>> where Parent : UnknownWriter<Parent> where Repeat : UnknownWriter<Repeat>
    {
        Repeat GetRepeat();
        Parent GetParent();
        Parent Parse<T>(IEnumerable<T> values, Func<T, Repeat, RootWriter> writer);
    }

    public class RootParser : UnknownParser<RootParser>
    {
        private byte[] buffer;
        private BufferIndex index;
        private int size;
        private Option<byte> delimiter;

        internal RootParser() { }

        internal RootParser(byte delimiter) => this.delimiter = delimiter.Some();

        private RootParser(byte[] buffer, BufferIndex index, int size, Option<byte> delimiter)
        {
            this.buffer = buffer;
            this.index = index;
            this.size = size;
            this.delimiter = delimiter;
        }

        public int GetLimit() => delimiter.Map(d => GetLimit(d)).ValueOr(size);

        public int CheckPadding()
        {
            if (delimiter.HasValue && size > index() && buffer[index()++] != delimiter.ValueOr(0)) throw new ArgumentException("illegal byte");
            return index();
        }

        private int GetLimit(byte delimiter)
        {
            for (int offset = index(); offset < size; offset++) if (buffer[index()] == delimiter) return offset;
            return size;
        }

        public RootParser Copy(byte[] buffer, BufferIndex index, int size) => new RootParser(buffer, index, size, delimiter);
    }

    public class RootWriter : UnknownWriter<RootWriter>
    {
        private byte[] buffer;
        private BufferIndex index;
        private Option<byte> delimiter;

        internal RootWriter() { }

        internal RootWriter(byte delimiter) => this.delimiter = delimiter.Some();

        private RootWriter(byte[] buffer, BufferIndex index, Option<byte> delimiter)
        {
            this.buffer = buffer;
            this.index = index;
            this.delimiter = delimiter;
        }

        public int AddPadding()
        {
            if (delimiter.HasValue) buffer[index()++] = delimiter.ValueOr(0);
            return index();
        }

        public RootWriter Copy(byte[] buffer, BufferIndex index) => new RootWriter(buffer, index, delimiter);
    }

    public class ConditionalParser<Parent1, Parent2> : UnknownParser<ConditionalParser<Parent1, Parent2>> where Parent1 : UnknownParser<Parent1> where Parent2 : UnknownParser<Parent2>
    {
        private byte[] buffer;
        private BufferIndex index;
        private int size;
        private Parent1 parent1;
        private Parent2 parent2;

        internal ConditionalParser(Parent1 parent1, Parent2 parent2)
        {
            this.parent1 = parent1;
            this.parent2 = parent2;
        }

        private ConditionalParser(byte[] buffer, BufferIndex index, int size, Parent1 parent1, Parent2 parent2) : this(parent1, parent2)
        {
            this.buffer = buffer;
            this.index = index;
            this.size = size;
        }

        public int GetLimit() => parent1.GetLimit();

        public Parent1 getTrue() => parent1;

        public Parent2 getFalse() => parent2;

        public ConditionalParser<Parent1, Parent2> Copy(byte[] buffer, BufferIndex index, int size) => new ConditionalParser<Parent1, Parent2>(buffer, index, size, parent1.Copy(buffer, index, size), parent2.Copy(buffer, index, size));
    }

    public class ConditionalWriter<Parent1, Parent2> : UnknownWriter<ConditionalWriter<Parent1, Parent2>> where Parent1 : UnknownWriter<Parent1> where Parent2 : UnknownWriter<Parent2>
    {
        private byte[] buffer;
        private BufferIndex index;
        private Parent1 parent1;
        private Parent2 parent2;

        internal ConditionalWriter(Parent1 parent1, Parent2 parent2)
        {
            this.parent1 = parent1;
            this.parent2 = parent2;
        }

        private ConditionalWriter(byte[] buffer, BufferIndex index, Parent1 parent1, Parent2 parent2) : this(parent1, parent2)
        {
            this.buffer = buffer;
            this.index = index;
        }

        public RootWriter Parse(bool condition, Func<Parent1, RootWriter> ifTrue, Func<Parent2, RootWriter> ifFalse) => condition ? ifTrue(parent1) : ifFalse(parent2);

        public ConditionalWriter<Parent1, Parent2> Copy(byte[] buffer, BufferIndex index) => new ConditionalWriter<Parent1, Parent2>(buffer, index, parent1.Copy(buffer, index), parent2.Copy(buffer, index));
    }

    public interface ParserBuilder<This1, This2> where This1 : UnknownParser<This1> where This2 : UnknownWriter<This2>
    {
        ParserBuilder<Parser<R, This1>, Writer<R, This2>> After<R>(Converter<R> converter);
        ParserBuilder<Parser<R, This1>, Writer<R, This2>> After<R>(Converter<R> converter, byte delimiter);
        ParserBuilder<RepeatParser<P, This1>, RepeatWriter<W, This2>> Repeat<P, W>(int clip, ParserBuilder<P, W> repeat) where P : UnknownParser<P> where W : UnknownWriter<W>;
        ParserBuilder<RepeatParser<P, This1>, RepeatWriter<W, This2>> Repeat<P, W>(int clip, ParserBuilder<P, W> repeat, byte delimiter) where P : UnknownParser<P> where W : UnknownWriter<W>;
        ParserBuilder<ConditionalParser<This1, P>, ConditionalWriter<This2, W>> Condition<P, W>(ParserBuilder<P, W> ifFalse) where P : UnknownParser<P> where W : UnknownWriter<W>;
        This1 Build(byte[] buffer, int index, int size);
        This2 Build(byte[] buffer, int index);
    }

    public class RootBuilder : BaseParserBuilder<RootParser, RootWriter>
    {
        public RootBuilder() : base(new RootParser(), new RootWriter()) { }
        public RootBuilder(byte delimiter) : base(new RootParser(delimiter), new RootWriter(delimiter)) { }
    }

    public class BaseParserBuilder<This1, This2> : ParserBuilder<This1, This2> where This1 : UnknownParser<This1> where This2 : UnknownWriter<This2>
    {
        private This1 parser;
        private This2 writer;

        internal BaseParserBuilder(This1 parser, This2 writer)
        {
            this.parser = parser;
            this.writer = writer;
        }

        public ParserBuilder<Parser<R, This1>, Writer<R, This2>> After<R>(Converter<R> converter) => new BaseParserBuilder<Parser<R, This1>, Writer<R, This2>>(new BaseParser<R, This1>(parser, converter), new BaseWriter<R, This2>(writer, converter));

        public ParserBuilder<Parser<R, This1>, Writer<R, This2>> After<R>(Converter<R> converter, byte delimiter) => new BaseParserBuilder<Parser<R, This1>, Writer<R, This2>>(new DelimitedParser<R, This1>(parser, converter, delimiter), new DelimitedWriter<R, This2>(writer, converter, delimiter));

        public ParserBuilder<RepeatParser<P, This1>, RepeatWriter<W, This2>> Repeat<P, W>(int clip, ParserBuilder<P, W> repeat) where P : UnknownParser<P> where W : UnknownWriter<W> => new BaseParserBuilder<RepeatParser<P, This1>, RepeatWriter<W, This2>>(new BaseRepeatParser<P, This1>(parser, clip, repeat.Build(null, 0, 0)), new BaseRepeatWriter<W, This2>(writer, clip, repeat.Build(null, 0)));

        public ParserBuilder<RepeatParser<P, This1>, RepeatWriter<W, This2>> Repeat<P, W>(int clip, ParserBuilder<P, W> repeat, byte delimiter) where P : UnknownParser<P> where W : UnknownWriter<W> => new BaseParserBuilder<RepeatParser<P, This1>, RepeatWriter<W, This2>>(new DelimitedRepeatParser<P, This1>(parser, clip, repeat.Build(null, 0, 0), delimiter), new DelimitedRepeatWriter<W, This2>(writer, clip, repeat.Build(null, 0), delimiter));

        public ParserBuilder<ConditionalParser<This1, P>, ConditionalWriter<This2, W>> Condition<P, W>(ParserBuilder<P, W> ifFalse) where P : UnknownParser<P> where W : UnknownWriter<W> => new BaseParserBuilder<ConditionalParser<This1, P>, ConditionalWriter<This2, W>>(new ConditionalParser<This1, P>(parser, ifFalse.Build(null, 0, 0)), new ConditionalWriter<This2, W>(writer, ifFalse.Build(null, 0)));

        public This1 Build(byte[] buffer, int index, int size) => parser.Copy(buffer, new IndexContainer(index).Index, size);

        public This2 Build(byte[] buffer, int index) => writer.Copy(buffer, new IndexContainer(index).Index);

        private class IndexContainer
        {
            private int index;

            public IndexContainer(int index) => this.index = index;

            public ref int Index() => ref index;
        }
    }

    internal class BaseParser<Type, Parent> : Parser<Type, Parent> where Parent : UnknownParser<Parent>
    {
        protected byte[] buffer;
        protected BufferIndex index;
        protected int size;
        protected Parent parent;
        protected Converter<Type> converter;

        internal BaseParser(Parent parent, Converter<Type> converter)
        {
            this.parent = parent;
            this.converter = converter;
        }

        protected BaseParser(byte[] buffer, BufferIndex index, int size, Parent parent, Converter<Type> converter) : this(parent, converter)
        {
            this.buffer = buffer;
            this.index = index;
            this.size = size;
        }

        public virtual int GetLimit() => parent.GetLimit();

        public virtual Parent Parse(out Type value)
        {
            int index2 = index();
            while (index2 <= size)
            {
                try
                {
                    index2 = Math.Min(parent.GetLimit(), size);
                    int copy = index();
                    value = converter.FromBytes(buffer, ref copy, index2++ - copy);
                    index() = copy;
                    return parent;
                }
                catch (ArgumentException)
                {
                    index2++;
                }
            }
            throw new ArgumentException("insufficient data");
        }

        public virtual Parser<Type, Parent> Copy(byte[] buffer, BufferIndex index, int size) => new BaseParser<Type, Parent>(buffer, index, size, parent.Copy(buffer, index, size), converter);

        public void SetMaxLimit(int limit) => this.size = limit;
    }

    internal class BaseWriter<Type, Parent> : Writer<Type, Parent> where Parent : UnknownWriter<Parent>
    {
        protected byte[] buffer;
        protected BufferIndex index;
        protected Parent parent;
        protected Converter<Type> converter;

        internal BaseWriter(Parent parent, Converter<Type> converter)
        {
            this.parent = parent;
            this.converter = converter;
        }

        protected BaseWriter(byte[] buffer, BufferIndex index, Parent parent, Converter<Type> converter) : this(parent, converter)
        {
            this.buffer = buffer;
            this.index = index;
        }

        public virtual Parent Parse(Type value)
        {
            converter.ToBytes(buffer, ref index(), value);
            return parent;
        }

        public virtual Writer<Type, Parent> Copy(byte[] buffer, BufferIndex index) => new BaseWriter<Type, Parent>(buffer, index, parent.Copy(buffer, index), converter);
    }

    internal class DelimitedParser<Type, Parent> : BaseParser<Type, Parent> where Parent : UnknownParser<Parent>
    {
        private byte delimiter;

        internal DelimitedParser(Parent parent, Converter<Type> converter, byte delimiter) : base(parent, converter) => this.delimiter = delimiter;

        private DelimitedParser(byte[] buffer, BufferIndex index, int size, Parent parent, Converter<Type> converter, byte delimiter) : base(buffer, index, size, parent, converter) => this.delimiter = delimiter;

        public override int GetLimit()
        {
            for (int offset = index(); offset < size; offset++) if (buffer[offset] == delimiter) return offset;
            return size;
        }

        public override Parent Parse(out Type value)
        {
            if (size > index() && buffer[index()++] != delimiter) throw new ArgumentException("illegal byte");
            return base.Parse(out value);
        }

        public override Parser<Type, Parent> Copy(byte[] buffer, BufferIndex index, int size) => new DelimitedParser<Type, Parent>(buffer, index, size, parent.Copy(buffer, index, size), converter, delimiter);
    }

    internal class DelimitedWriter<Type, Parent> : BaseWriter<Type, Parent> where Parent : UnknownWriter<Parent>
    {
        private byte delimiter;

        internal DelimitedWriter(Parent parent, Converter<Type> converter, byte delimiter) : base(parent, converter) => this.delimiter = delimiter;

        private DelimitedWriter(byte[] buffer, BufferIndex index, Parent parent, Converter<Type> converter, byte delimiter) : base(buffer, index, parent, converter) => this.delimiter = delimiter;

        public override Parent Parse(Type value)
        {
            buffer[index()++] = delimiter;
            return base.Parse(value);
        }

        public override Writer<Type, Parent> Copy(byte[] buffer, BufferIndex index) => new DelimitedWriter<Type, Parent>(buffer, index, parent.Copy(buffer, index), converter, delimiter);
    }

    internal class BaseRepeatParser<Repeat, Parent> : RepeatParser<Repeat, Parent> where Parent : UnknownParser<Parent> where Repeat : UnknownParser<Repeat>
    {
        protected byte[] buffer;
        protected BufferIndex index;
        protected int size;
        protected Parent parent;
        protected int clip;
        protected Repeat repeat;

        internal BaseRepeatParser(Parent parent, int clip, Repeat repeat)
        {
            this.parent = parent;
            this.clip = clip;
            this.repeat = repeat;
        }

        protected BaseRepeatParser(byte[] buffer, BufferIndex index, int size, Parent parent, int clip, Repeat repeat) : this(parent, clip, repeat)
        {
            this.buffer = buffer;
            this.index = index;
            this.size = size;
        }

        public virtual int GetLimit() => parent.GetLimit();

        public Repeat GetRepeat() => repeat;

        public Parent GetParent() => parent;

        public virtual Parent Parse(Func<Repeat, RootParser> action, out int count)
        {
            int limit = index();
            int copy = index();
            while (limit < size)
            {
                index() = limit;
                limit = parent.GetLimit();
                index() = copy;
                count = 0;
                while (index() < limit)
                {
                    try
                    {
                        action(repeat).CheckPadding();
                        count++;
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                return parent;
            }
            throw new ArgumentException("insufficient data");
        }

        public virtual RepeatParser<Repeat, Parent> Copy(byte[] buffer, BufferIndex index, int size) => new BaseRepeatParser<Repeat, Parent>(buffer, index, size, parent.Copy(buffer, index, size), clip, repeat.Copy(buffer, index, size));
    }

    internal class BaseRepeatWriter<Repeat, Parent> : RepeatWriter<Repeat, Parent> where Parent : UnknownWriter<Parent> where Repeat : UnknownWriter<Repeat>
    {
        protected byte[] buffer;
        protected BufferIndex index;
        protected Parent parent;
        protected int clip;
        protected Repeat repeat;

        public BaseRepeatWriter(Parent parent, int clip, Repeat repeat)
        {
            this.parent = parent;
            this.clip = clip;
            this.repeat = repeat;
        }

        protected BaseRepeatWriter(byte[] buffer, BufferIndex index, Parent parent, int clip, Repeat repeat) : this(parent, clip, repeat)
        {
            this.buffer = buffer;
            this.index = index;
        }

        public Parent GetParent() => parent;

        public Repeat GetRepeat() => repeat;

        public virtual Parent Parse<T>(IEnumerable<T> values, Func<T, Repeat, RootWriter> writer)
        {
            int start = index();
            foreach (T value in values) writer(value, repeat).AddPadding();
            if (index() > start) index() -= clip;
            return parent;
        }

        public virtual RepeatWriter<Repeat, Parent> Copy(byte[] buffer, BufferIndex index) => new BaseRepeatWriter<Repeat, Parent>(buffer, index, parent.Copy(buffer, index), clip, repeat.Copy(buffer, index));
    }

    internal class DelimitedRepeatParser<Repeat, Parent> : BaseRepeatParser<Repeat, Parent> where Parent : UnknownParser<Parent> where Repeat : UnknownParser<Repeat>
    {
        private byte delimiter;

        internal DelimitedRepeatParser(Parent parent, int clip, Repeat repeat, byte delimiter) : base(parent, clip, repeat) => this.delimiter = delimiter;

        private DelimitedRepeatParser(byte[] buffer, BufferIndex index, int size, Parent parent, int clip, Repeat repeat, byte delimiter) : base(buffer, index, size, parent, clip, repeat) => this.delimiter = delimiter;

        public override int GetLimit()
        {
            for (int offset = index(); offset < size; offset++) if (buffer[offset] == delimiter) return offset;
            return size;
        }

        public override Parent Parse(Func<Repeat, RootParser> action, out int count)
        {
            if (index() < size && buffer[index()++] != delimiter) throw new ArgumentException("illegal byte");
            return base.Parse(action, out count);
        }

        public override RepeatParser<Repeat, Parent> Copy(byte[] buffer, BufferIndex index, int size) => new DelimitedRepeatParser<Repeat, Parent>(buffer, index, size, parent.Copy(buffer, index, size), clip, repeat.Copy(buffer, index, size), delimiter);
    }

    internal class DelimitedRepeatWriter<Repeat, Parent> : BaseRepeatWriter<Repeat, Parent> where Parent : UnknownWriter<Parent> where Repeat : UnknownWriter<Repeat>
    {
        private byte delimiter;

        internal DelimitedRepeatWriter(Parent parent, int clip, Repeat repeat, byte delimiter) : base(parent, clip, repeat) => this.delimiter = delimiter;

        private DelimitedRepeatWriter(byte[] buffer, BufferIndex index, Parent parent, int clip, Repeat repeat, byte delimiter) : base(buffer, index, parent, clip, repeat) => this.delimiter = delimiter;

        public override Parent Parse<T>(IEnumerable<T> values, Func<T, Repeat, RootWriter> writer)
        {
            buffer[index()++] = delimiter;
            return base.Parse(values, writer);
        }

        public override RepeatWriter<Repeat, Parent> Copy(byte[] buffer, BufferIndex index) => new DelimitedRepeatWriter<Repeat, Parent>(buffer, index, parent.Copy(buffer, index), clip, repeat.Copy(buffer, index), delimiter);
    }

    internal static class Parsers
    {
        internal static readonly RootBuilder ROOT = new RootBuilder();
        internal static readonly RootBuilder ROOT_ASTERISK = new RootBuilder(0x2A);
        internal static readonly RootBuilder ROOT_COMMA = new RootBuilder(0x2C);

        internal static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> STRING = ROOT.After(Converters.STRING);
        internal static readonly ParserBuilder<Parser<uint, RootParser>, Writer<uint, RootWriter>> UINT = ROOT.After(Converters.UInt<uint>());
        internal static readonly ParserBuilder<Parser<byte, RootParser>, Writer<byte, RootWriter>> BYTE = ROOT.After(Converters.Byte<byte>());
        internal static readonly ParserBuilder<Parser<bool, RootParser>, Writer<bool, RootWriter>> BOOLEAN = ROOT.After(Converters.BOOLEAN1);
        internal static readonly ParserBuilder<Parser<BrandID, RootParser>, Writer<BrandID, RootWriter>> BRAND = ROOT.After(Converters.Byte<BrandID>());
        internal static readonly ParserBuilder<Parser<GameModeID, RootParser>, Writer<GameModeID, RootWriter>> GAMEMODE = ROOT.After(Converters.Byte<GameModeID>());
        internal static readonly ParserBuilder<Parser<CatalogID, RootParser>, Writer<CatalogID, RootWriter>> CATALOG = ROOT.After(Converters.Byte<CatalogID>());
        internal static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> PLAYER = ROOT.After(Converters.Byte<PlayerID>());
        internal static readonly ParserBuilder<Parser<RoleID, RootParser>, Writer<RoleID, RootWriter>> ROLE = ROOT.After(Converters.Byte<RoleID>());
        internal static readonly ParserBuilder<Parser<LocalizationTableID, RootParser>, Writer<LocalizationTableID, RootWriter>> LOCALIZATION = ROOT.After(Converters.Byte<LocalizationTableID>());

        internal static readonly ParserBuilder<Parser<byte, Parser<byte, RootParser>>, Writer<byte, Writer<byte, RootWriter>>> BYTE2 = BYTE.After(Converters.Byte<byte>());
        internal static readonly ParserBuilder<Parser<PlayerID, Parser<string, RootParser>>, Writer<PlayerID, Writer<string, RootWriter>>> PLAYER_STRING = STRING.After(Converters.Byte<PlayerID>());
        internal static readonly ParserBuilder<Parser<PlayerID, Parser<byte, RootParser>>, Writer<PlayerID, Writer<byte, RootWriter>>> PLAYER_BYTE = BYTE.After(Converters.Byte<PlayerID>());
        internal static readonly ParserBuilder<Parser<PlayerID, Parser<PlayerID, RootParser>>, Writer<PlayerID, Writer<PlayerID, RootWriter>>> PLAYER2 = PLAYER.After(Converters.Byte<PlayerID>());
        internal static readonly ParserBuilder<Parser<PlayerID, Parser<RoleID, RootParser>>, Writer<PlayerID, Writer<RoleID, RootWriter>>> PLAYER_ROLE = ROLE.After(Converters.Byte<PlayerID>());

        internal static readonly ParserBuilder<Parser<PlayerID, Parser<PlayerID, Parser<byte, RootParser>>>, Writer<PlayerID, Writer<PlayerID, Writer<byte, RootWriter>>>> PLAYER2_BYTE = PLAYER_BYTE.After(Converters.Byte<PlayerID>());
        internal static readonly ParserBuilder<Parser<PlayerID, Parser<TauntTargetType, Parser<TauntID, RootParser>>>, Writer<PlayerID, Writer<TauntTargetType, Writer<TauntID, RootWriter>>>> PLAYER_TYPE_TAUNT = ROOT.After(Converters.Byte<TauntID>()).After(Converters.Byte<TauntTargetType>()).After(Converters.Byte<PlayerID>());

        internal static readonly ParserBuilder<Parser<string, Parser<string, RootParser>>, Writer<string, Writer<string, RootWriter>>> STRING2_ASTERISK = ROOT.After(Converters.STRING, 0x2A).After(Converters.STRING);
        internal static readonly ParserBuilder<Parser<string, Parser<uint, RootParser>>, Writer<string, Writer<uint, RootWriter>>> STRING_UINT_ASTERISK = ROOT.After(Converters.UInt<uint>(), 0x2A).After(Converters.STRING);
        internal static readonly ParserBuilder<Parser<uint, Parser<OnlineStatus, Parser<bool, RootParser>>>, Writer<uint, Writer<OnlineStatus, Writer<bool, RootWriter>>>> UINT_ONLINE_BOOLEAN_COMMA = ROOT.After(Converters.BOOLEAN2, 0x2A).After(Converters.Byte<OnlineStatus>(), 0x2A).After(Converters.UInt<uint>());
        internal static readonly ParserBuilder<Parser<string, Parser<uint, Parser<OnlineStatus, Parser<bool, RootParser>>>>, Writer<string, Writer<uint, Writer<OnlineStatus, Writer<bool, RootWriter>>>>> STRING_UINT_ONLINE_BOOLEAN_COMMA = new RootBuilder(0x2A).After(Converters.BOOLEAN2, 0x2C).After(Converters.Byte<OnlineStatus>(), 0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.STRING);
        internal static readonly ParserBuilder<Parser<uint, Parser<uint, Parser<uint, Parser<uint, Parser<uint, RootParser>>>>>, Writer<uint, Writer<uint, Writer<uint, Writer<uint, Writer<uint, RootWriter>>>>>> UINT5_COMMA = new RootBuilder(0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<uint>());

        internal static readonly ParserBuilder<RepeatParser<Parser<PlayerID, RootParser>, RootParser>, RepeatWriter<Writer<PlayerID, RootWriter>, RootWriter>> REPEAT_PLAYER = ROOT.Repeat(0, PLAYER);
        internal static readonly ParserBuilder<RepeatParser<Parser<AchievementID, RootParser>, RootParser>, RepeatWriter<Writer<AchievementID, RootWriter>, RootWriter>> REPEAT_ACHIEVEMENT = ROOT.Repeat(1, ROOT_COMMA.After(Converters.UInt<AchievementID>()));
        internal static readonly ParserBuilder<RepeatParser<Parser<PlayerID, Parser<RoleID, RootParser>>, RootParser>, RepeatWriter<Writer<PlayerID, Writer<RoleID, RootWriter>>, RootWriter>> REPEAT_PLAYER_ROLE = ROOT.Repeat(0, PLAYER_ROLE);
    }

    public static class Converters
    {
        public static readonly Converter<string> STRING = new ConverterImpl<string>(ToString, FromString);
        public static readonly Converter<Uri> URI = new ConverterImpl<Uri>(ToURI, FromURI);
        public static readonly Converter<bool> BOOLEAN1 = Boolean(Byte<byte>());
        public static readonly Converter<bool> BOOLEAN2 = Boolean(UInt<uint>());
        public static readonly Converter<double> DOUBLE = new ConverterImpl<double>(ToDouble, FromDouble);

        public static Converter<T> Default<T>() => new ConverterImpl<T>(ToDefault<T>, FromDefault);

        public static Converter<T> UInt<T>() where T : IConvertible => new ConverterImpl<T>(ToUInt<T>, FromUInt);

        public static Converter<T> Byte<T>() where T : IConvertible => new ConverterImpl<T>(ToByte<T>, FromByte);

        public static Converter<Option<R>> Optional<R>(Converter<R> converter) => new ConverterImpl<Option<R>>((byte[] buffer, ref int index, int count) => { try { return converter.FromBytes(buffer, ref index, count).SomeNotNull(); } catch (Exception) { return Option.None<R>(); } }, (byte[] buffer, ref int index, Option<R> value) => { if (value.HasValue) converter.ToBytes(buffer, ref index, value.ValueOr(default(R))); });

        public static Converter<bool> Boolean<T>(Converter<T> converter) where T : IConvertible => new ConverterImpl<bool>((byte[] buffer, ref int index, int count) => Convert.ToUInt32(converter.FromBytes(buffer, ref index, count)) != 0u, (byte[] buffer, ref int index, bool value) => converter.ToBytes(buffer, ref index, (value ? 1u : 0u).To<T>()));

        public static Converter<T?> Safe<T>(Converter<T> converter, string or) where T : struct => new ConverterImpl<T?>((byte[] buffer, ref int index, int count) => { try { return converter.FromBytes(buffer, ref index, count); } catch (Exception) { return null; } }, (byte[] buffer, ref int index, T? value) => { if (value != null) converter.ToBytes(buffer, ref index, (T)value); else FromString(buffer, ref index, or); });

        private delegate T FromBytes<T>(byte[] buffer, ref int index, int count);
        private delegate void ToBytes<T>(byte[] buffer, ref int index, T value);

        private class ConverterImpl<T> : Converter<T>
        {
            private FromBytes<T> from;
            private ToBytes<T> to;

            public ConverterImpl(FromBytes<T> from, ToBytes<T> to)
            {
                this.from = from;
                this.to = to;
            }

            public T FromBytes(byte[] buffer, ref int index, int count) => from(buffer, ref index, count);

            public void ToBytes(byte[] buffer, ref int index, T value) => to(buffer, ref index, value);
        }

        private static T ToDefault<T>(byte[] buffer, ref int index, int count) => default(T);
        private static void FromDefault<T>(byte[] buffer, ref int index, T value) { }

        private static string ToString(byte[] buffer, ref int index, int count)
        {
            int index2 = index;
            index += count;
            return Encoding.UTF8.GetString(buffer, index2, count);
        }
        private static void FromString(byte[] buffer, ref int index, string value) => index += Encoding.UTF8.GetBytes(value, 0, value.Length, buffer, index);

        private static Uri ToURI(byte[] buffer, ref int index, int count) => new Uri(ToString(buffer, ref index, count));
        private static void FromURI(byte[] buffer, ref int index, Uri uri) => FromString(buffer, ref index, uri.ToString());

        private static double ToDouble(byte[] buffer, ref int index, int count) => double.Parse(ToString(buffer, ref index, count));
        private static void FromDouble(byte[] buffer, ref int index, double value) => FromString(buffer, ref index, value.ToString());

        private static T ToUInt<T>(byte[] buffer, ref int index, int count) where T : IConvertible => uint.Parse(ToString(buffer, ref index, count)).To<T>();
        private static void FromUInt<T>(byte[] buffer, ref int index, T value) where T : IConvertible => FromString(buffer, ref index, Convert.ToUInt32(value).ToString());

        private static T ToByte<T>(byte[] buffer, ref int index, int count) where T : IConvertible => (buffer[index++] - 1u).To<T>();
        private static void FromByte<T>(byte[] buffer, ref int index, T value) where T : IConvertible => buffer[index++] = (byte)(Convert.ToUInt32(value) + 1u);

        private static T To<T>(this uint value) where T : IConvertible => (T)(typeof(T).IsEnum ? Enum.Parse(typeof(T), value.ToString()) : Convert.ChangeType(value, typeof(T)));
    }

    public class MessageParser
    {
        //public delegate RootWriter Writer(byte[] buffer, int index);
        //public delegate RootParser PartialWriter<P>(P parser, byte[] buffer, ref int index) where P : UnknownParser;
        //public delegate RootParser PartialReader<P>(P parser, byte[] buffer, ref int index, int length) where P : UnknownParser;

        private Action<byte[], int, int> onRead;
        private Action<byte[], int, int> onWrite;
        private byte[] read;
        private byte[] write;
        private int length;

        public MessageParser(Action<byte[], int, int> onRead, Action<byte[], int, int> onWrite)
        {
            this.onRead = onRead;
            this.onWrite = onWrite;
            read = new byte[4096];
            write = new byte[4096];
        }

        public void Parse(byte[] buffer, int index, int count)
        {
            CheckLength(count);
            for (; index < count; index++)
            {
                if (buffer[index] != 0) read[length++] = buffer[index];
                else if (length > 0)
                {
                    try
                    {
                        onRead(read, 0, length);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception thrown in read callback: {0}", e.Message);
                        Debug.WriteLine(e);
                    }
                    length = 0;
                }
            }
        }

        public void Parse(byte type, Func<byte[], int, RootWriter> func)
        {
            while (true)
            {
                try
                {
                    int length = 1;
                    length = func(write, length).AddPadding();
                    write[0] = type;
                    write[length++] = 0;
                    try
                    {
                        onWrite(write, 0, length);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception thrown in write callback: {0}", e.Message);
                        Debug.WriteLine(e);
                    }
                    break;
                }
                catch (IndexOutOfRangeException)
                {
                    byte[] buffer = write;
                    write = new byte[write.Length * 2];
                }
            }
        }

        private void CheckLength(int needed)
        {
            if (read.Length >= length + needed) return;
            byte[] buffer = read;
            read = new byte[read.Length * 2];
            Array.Copy(buffer, read, length);
        }
    }

    public interface Converter<R>
    {
        R FromBytes(byte[] buffer, ref int index, int count);
        void ToBytes(byte[] buffer, ref int index, R value);
    }
}
