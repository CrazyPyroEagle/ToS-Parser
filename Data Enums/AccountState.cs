using System;

namespace ToSParser
{
    [Flags]
    public enum AccountState : byte
    {
        NONE,
        NAME_CHANGE_REQUIRED
    }
}
