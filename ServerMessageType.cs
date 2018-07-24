using Optional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToSParser
{
    public enum ServerMessageType : byte
    {
        RESERVED,
        AUTHENTICATED,
        CREATE_LOBBY,
        SET_HOST,
        USER_JOINED_GAME,
        USER_LEFT_GAME,
        CHAT_BOX_MESSAGE,
        HOST_CLICKED_ON_CATALOG,
        HOST_CLICKED_ON_POSSIBLE_ROLES,
        HOST_CLICKED_ON_ADD_BUTTON,
        HOST_CLICKED_ON_REMOVE_BUTTON,
        HOST_CLICKED_ON_START_BUTTON,
        CANCEL_START_COOLDOWN,
        ASSIGN_NEW_HOST,
        VOTED_TO_REPICK_HOST,
        NO_LONGER_HOST,
        DO_NOT_SPAM,
        HOW_MANY_PLAYERS_AND_GAMES,
        SYSTEM_MESSAGE,
        STRING_TABLE_MESSAGE,
        FRIEND_LIST,
        FRIEND_REQUEST_NOTIFICATIONS,
        ADD_FRIEND_REQUEST_RESPONSE,
        CONFIRM_FRIEND_REQUEST,
        SUCCESSFULLY_REMOVED_FRIEND,
        SUCCESSFULLY_DECLINED_FRIEND_REQUEST,
        FRIEND_UPDATE,
        FRIEND_MESSAGE,
        USER_INFORMATION,
        CREATE_PARTY_LOBBY,
        PARTY_INVITE_FAILED,
        PARTY_INVITE_NOTIFICATION,
        ACCEPTED_PARTY_INVITE,
        PENDING_PARTY_INVITE_STATUS,
        SUCCESSFULLY_LEFT_PARTY,
        PARTY_CHAT,
        PARTY_MEMBER_LEFT,
        SETTINGS_INFORMATION,
        ADD_FRIEND,
        FORCED_LOGOUT,
        RETURN_TO_HOME_PAGE,
        UNKNOWN_TYPE_41,
        SHOP_PURCHASE_SUCCESS,
        PURCHASED_CHARACTERS,
        PURCHASED_HOUSES,
        PURCHASED_BACKGROUNDS,
        SELECTION_SETTINGS,
        REDEEM_CODE_MESSAGE,
        UPDATE_PAID_CURRENCY,
        PURCHASED_PACKS,
        PURCHASED_PETS,
        SET_LAST_BONUS_WIN_TIME,
        EARNED_ACHIEVEMENTS_52,
        PURCHASED_LOBBY_ICONS,
        PURCHASED_DEATH_ANIMATIONS,
        FACEBOOK_INVITE_FRIENDS,
        PURCHASED_SCROLLS,
        UNKNOWN_TYPE_57,
        HOST_GIVEN_TO_PLAYER,
        HOST_GIVEN_TO_ME,
        KICKED_PLAYER,
        KICKED_ME,
        INVITE_POWERS_GIVEN_TO_PLAYER,
        INVITE_POWERS_GIVEN_TO_ME,
        STEAM_FIRST_LOGIN,
        UNKNOWN_TYPE_65,
        UPDATE_FRIEND_USERNAME,
        ENABLE_SHOP_BUTTONS,
        STEAM_POPUP,
        REGISTER,
        AUTHENTICATE_WITH_STEAM_CLOUD,
        START_RANKED_QUEUE,
        LEAVE_RANKED_QUEUE,
        ACCEPT_RANKED_POPUP,
        USER_STATISTICS,
        RANKED_TIMEOUT_DURATION,
        AUTHENTICATE_WITH_STEAM,
        MODERATOR_MESSAGE,
        REFER_A_FRIEND_UPDATE,
        PLAYER_STATISTICS,
        SCROLL_CONSUMED,
        AD_VIEW_RESPONSE,
        USER_JOINING_LOBBY_TOO_QUICKLY_MESSAGE,
        PROMOTION_POPUP,
        KICKSTARTER_SHARE,
        UNKNOWN_TYPE_85,
        TUTORIAL_PROGRESS,
        PURCHASED_TAUNTS,
        CURRENCY_MULTIPLIER,
        UNKNOWN_TYPE_89,
        PICK_NAMES,
        NAMES_AND_POSITIONS_OF_USERS,
        ROLE_AND_POSITION,
        START_NIGHT,
        START_DAY,
        WHO_DIED_AND_HOW,
        START_DISCUSSION,
        START_VOTING,
        START_DEFENSE_TRANSITION,
        START_JUDGEMENT,
        TRIAL_FOUND_GUILTY,
        TRIAL_FOUND_NOT_GUILTY,
        LOOKOUT_NIGHT_ABILITY_MESSAGE,
        USER_VOTED,
        USER_CANCELED_VOTE,
        USER_CHANGED_VOTE,
        USER_DIED,
        RESURRECTION,
        TELL_ROLE_LIST,
        USER_CHOSEN_NAME,
        OTHER_MAFIA,
        TELL_TOWN_AMNESIAC_CHANGED_ROLE,
        AMNESIAC_CHANGED_ROLE,
        BROUGHT_BACK_TO_LIFE,
        START_FIRST_DAY,
        BEING_JAILED,
        JAILED_TARGET,
        USER_JUDGEMENT_VOTED,
        USER_CHANGED_JUDGEMENT_VOTE,
        USER_CANCELED_JUDGEMENT_VOTE,
        TELL_JUDGEMENT_VOTES,
        EXECUTIONER_COMPLETED_GOAL,
        JESTER_COMPLETED_GOAL,
        MAYOR_REVEALED,
        MAYOR_REVEALED_AND_ALREADY_VOTED,
        DISGUISER_STOLE_YOUR_IDENTITY,
        DISGUISER_CHANGED_IDENTITY,
        DISGUISER_CHANGED_UPDATE_MAFIA,
        MEDIUM_IS_TALKING_TO_US,
        MEDIUM_COMMUNICATING,
        TELL_LAST_WILL,
        HOW_MANY_ABILITIES_LEFT,
        MAFIA_TARGETING,
        TELL_JANITOR_TARGETS_ROLE,
        TELL_JANITOR_TARGETS_WILL,
        SOMEONE_HAS_WON,
        MAFIOSO_PROMOTED_TO_GODFATHER,
        MAFIOSO_PROMOTED_TO_GODFATHER_UPDATE_MAFIA,
        MAFIA_PROMOTED_TO_MAFIOSO,
        TELL_MAFIA_ABOUT_MAFIOSO_PROMOTION,
        EXECUTIONER_CONVERTED_TO_JESTER,
        AMNESIAC_BECAME_MAFIA_OR_WITCH,
        USER_DISCONNECTED,
        MAFIA_WAS_JAILED,
        INVALID_NAME_MESSAGE,
        START_NIGHT_TRANSITION,
        START_DAY_TRANSITION,
        LYNCH_USER,
        DEATH_NOTE,
        UNKNOWN_TYPE_149,
        HOUSES_CHOSEN,
        FIRST_DAY_TRANSITION,
        UNKNOWN_TYPE_152,
        CHARACTERS_CHOSEN,
        RESURRECTION_SET_ALIVE,
        START_DEFENSE,
        UNKNOWN_TYPE_156,
        USER_LEFT_DURING_SELECTION,
        VIGILANTE_KILLED_TOWN,
        NOTIFY_USERS_OF_PRIVATE_MESSAGE,
        PRIVATE_MESSAGE,
        EARNED_ACHIEVEMENTS_161,
        AUTHENTICATION_FAILED,
        SPY_NIGHT_ABILITY_MESSAGE,
        ONE_DAY_BEFORE_STALEMATE,
        PETS_CHOSEN,
        FACEBOOK_SHARE_ACHIEVEMENT,
        FACEBOOK_SHARE_WIN,
        DEATH_ANIMATIONS_CHOSEN,
        FULL_MOON_NIGHT,
        IDENTIFY,
        END_GAME_INFO,
        END_GAME_CHAT_MESSAGE,
        END_GAME_USER_UPDATE,
        UNKNOWN_TYPE_174,
        ROLE_LOTS_INFO_MESSAGE,
        EXTERNAL_PURCHASE,
        UNKNOWN_TYPE_177,
        UNKNOWN_TYPE_178,
        UNKNOWN_TYPE_179,
        VAMPIRE_PROMOTION,
        OTHER_VAMPIRES,
        ADD_VAMPIRE,
        CAN_VAMPIRES_CONVERT,
        VAMPIRE_DIED,
        VAMPIRE_HUNTER_PROMOTED,
        VAMPIRE_VISITED_MESSAGE,
        CHECK_USERNAME_RESULT,
        NAME_CHANGE_RESULT,
        ACCOUNT_STATE,
        PURCHASED_ACCOUNT_ITEMS,
        ACCOUNT_ITEM_CONSUMED,
        TRANSPORTER_NOTIFICATION,
        PRODUCT_PURCHASE_RESULT,
        UPDATE_FREE_CURRENCY,
        ACTIVE_EVENTS,
        CAULDRON_STATUS,
        TAUNT_RESULT,
        TAUNT_ACTIVATED,
        TAUNT_CONSUMED,
        TRACKER_NIGHT_ABILITY,
        AMBUSHER_NIGHT_ABILITY,
        GUARDIAN_ANGEL_PROTECTION,
        PIRATE_DUEL,
        DUEL_TARGET,
        POTION_MASTER_POTIONS,
        HAS_NECRONOMICON,
        OTHER_WITCHES,
        PSYCHIC_NIGHT_ABILITY,
        TRAPPER_NIGHT_ABILITY,
        TRAPPER_TRAP_STATUS,
        PESTILENCE_CONVERSION,
        JUGGERNAUT_KILL_COUNT,
        COVEN_GOT_NECRONOMICON,
        GUARDIAN_ANGEL_PROMOTED,
        VIP_TARGET,
        PIRATE_DUEL_OUTCOME,
        HOST_SET_PARTY_CONFIG_RESULT,
        ACTIVE_GAME_MODES,
        ACCOUNT_FLAGS,
        ZOMBIE_ROTTED,
        LOVER_TARGET,
        PLAGUE_SPREAD,
        RIVAL_TARGET,
        RANKED_INFO,
        JAILOR_DEATH_NOTE,
        DISCONNECTED,
        SPY_NIGHT_INFO,
        SERVER_FLAGS
    }

    public static class ServerMessageParsers
    {
        public static readonly ParserBuilder<Parser<bool, RootParser>, Writer<bool, RootWriter>> AUTHENTICATED = Parsers.BOOLEAN;
        public static readonly ParserBuilder<Parser<bool, Parser<GameMode, RootParser>>, Writer<bool, Writer<GameMode, RootWriter>>> CREATE_LOBBY = Parsers.ROOT.After(Converters.Byte<GameMode>()).After(Converters.BOOLEAN1);
        public static readonly RootBuilder SET_HOST = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<bool, Parser<bool, Parser<string, Parser<Player, Parser<LobbyIcon, RootParser>>>>>, Writer<bool, Writer<bool, Writer<string, Writer<Player, Writer<LobbyIcon, RootWriter>>>>>> USER_JOINED_GAME = Parsers.ROOT.After(Converters.Byte<LobbyIcon>()).After(Converters.Byte<Player>(), 0x2A).After(Converters.STRING).After(Converters.BOOLEAN1).After(Converters.BOOLEAN1);
        public static readonly ParserBuilder<Parser<bool, Parser<bool, Parser<Player, RootParser>>>, Writer<bool, Writer<bool, Writer<Player, RootWriter>>>> USER_LEFT_GAME = Parsers.ROOT.After(Converters.Byte<Player>()).After(Converters.BOOLEAN1).After(Converters.BOOLEAN1);
        public static readonly ParserBuilder<Parser<bool, Parser<Player, Parser<string, RootParser>>>, Writer<bool, Writer<Player, Writer<string, RootWriter>>>> CHAT_BOX_MESSAGE = Parsers.PLAYER_STRING.After(Converters.Optional(0xFF));
        public static readonly ParserBuilder<Parser<Catalog, RootParser>, Writer<Catalog, RootWriter>> HOST_CLICKED_ON_CATALOG = Parsers.CATALOG;
        public static readonly ParserBuilder<Parser<byte, Parser<byte, RootParser>>, Writer<byte, Writer<byte, RootWriter>>> HOST_CLICKED_ON_POSSIBLE_ROLES = Parsers.BYTE2;
        public static readonly ParserBuilder<Parser<Role, RootParser>, Writer<Role, RootWriter>> HOST_CLICKED_ON_ADD_BUTTON = Parsers.ROLE;
        public static readonly ParserBuilder<Parser<byte, RootParser>, Writer<byte, RootWriter>> HOST_CLICKED_ON_REMOVE_BUTTON = Parsers.BYTE;
        public static readonly RootBuilder HOST_CLICKED_ON_START_BUTTON = Parsers.ROOT;
        public static readonly RootBuilder CANCEL_START_COOLDOWN = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> ASSIGN_NEW_HOST = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<byte, RootParser>, Writer<byte, RootWriter>> VOTED_TO_REPICK_HOST = Parsers.BYTE;
        public static readonly RootBuilder NO_LONGER_HOST = Parsers.ROOT;
        public static readonly RootBuilder DO_NOT_SPAM = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<uint, Parser<uint, RootParser>>, Writer<uint, Writer<uint, RootWriter>>> HOW_MANY_PLAYERS_AND_GAMES = Parsers.ROOT.After(Converters.UInt<uint>(), 0x2A).After(Converters.UInt<uint>());
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> SYSTEM_MESSAGE = Parsers.STRING;
        public static readonly ParserBuilder<Parser<LocalizationTable, RootParser>, Writer<LocalizationTable, RootWriter>> STRING_TABLE_MESSAGE = Parsers.LOCALIZATION;
        public static readonly ParserBuilder<RepeatParser<Parser<string, Parser<uint, Parser<OnlineStatus, Parser<bool, RootParser>>>>, RootParser>, RepeatWriter<Writer<string, Writer<uint, Writer<OnlineStatus, Writer<bool, RootWriter>>>>, RootWriter>> FRIEND_LIST = Parsers.ROOT.Repeat(1, Parsers.STRING_UINT_ONLINE_BOOLEAN_COMMA);
        public static readonly ParserBuilder<RepeatParser<Parser<string, Parser<uint, RootParser>>, RootParser>, RepeatWriter<Writer<string, Writer<uint, RootWriter>>, RootWriter>> FRIEND_REQUEST_NOTIFICATIONS = Parsers.ROOT.Repeat(1, Parsers.ROOT_ASTERISK.After(Converters.UInt<uint>(), 0x2C).After(Converters.STRING));
        public static readonly ParserBuilder<Parser<bool, RootParser>, Writer<bool, RootWriter>> ADD_FRIEND_REQUEST_RESPONSE = Parsers.BOOLEAN;
        public static readonly ParserBuilder<Parser<uint, Parser<OnlineStatus, Parser<bool, RootParser>>>, Writer<uint, Writer<OnlineStatus, Writer<bool, RootWriter>>>> CONFIRM_FRIEND_REQUEST = Parsers.UINT_ONLINE_BOOLEAN_COMMA;
        public static readonly ParserBuilder<Parser<uint, RootParser>, Writer<uint, RootWriter>> SUCCESSFULLY_REMOVED_FRIEND = Parsers.UINT;
        public static readonly RootBuilder SUCCESSFULLY_DECLINED_FRIEND_REQUEST = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<uint, Parser<OnlineStatus, Parser<bool, RootParser>>>, Writer<uint, Writer<OnlineStatus, Writer<bool, RootWriter>>>> FRIEND_UPDATE = Parsers.UINT_ONLINE_BOOLEAN_COMMA;
        public static readonly ParserBuilder<Parser<uint, Parser<bool, Parser<string, RootParser>>>, Writer<uint, Writer<bool, Writer<string, RootWriter>>>> FRIEND_MESSAGE = Parsers.ROOT.After(Converters.STRING, 0x2A).After(Converters.BOOLEAN2, 0x2A).After(Converters.UInt<uint>());
        public static readonly ParserBuilder<Parser<string, Parser<uint, Parser<uint, RootParser>>>, Writer<string, Writer<uint, Writer<uint, RootWriter>>>> USER_INFORMATION = Parsers.ROOT.After(Converters.UInt<uint>(), 0x2A).After(Converters.UInt<uint>(), 0x2A).After(Converters.STRING);
        public static readonly ParserBuilder<Parser<Brand, RootParser>, Writer<Brand, RootWriter>> CREATE_PARTY_LOBBY = Parsers.BRAND;
        public static readonly ParserBuilder<Parser<string, Parser<FailedInvitationStatus, RootParser>>, Writer<string, Writer<FailedInvitationStatus, RootWriter>>> PARTY_INVITE_FAILED = Parsers.ROOT.After(Converters.UInt<FailedInvitationStatus>(), 0x2A).After(Converters.STRING);
        public static readonly ParserBuilder<Parser<uint, Parser<string, RootParser>>, Writer<uint, Writer<string, RootWriter>>> PARTY_INVITE_NOTIFICATION = Parsers.ROOT.After(Converters.STRING, 0x2A).After(Converters.UInt<uint>());
        public static readonly ParserBuilder<Parser<AcceptInvitationResult, RootParser>, Writer<AcceptInvitationResult, RootWriter>> ACCEPTED_PARTY_INVITE = Parsers.ROOT.After(Converters.Byte<AcceptInvitationResult>());
        public static readonly ParserBuilder<Parser<string, Parser<PendingInvitationStatus, RootParser>>, Writer<string, Writer<PendingInvitationStatus, RootWriter>>> PENDING_PARTY_INVITE_STATUS = Parsers.ROOT.After(Converters.Byte<PendingInvitationStatus>(), 0x2A).After(Converters.STRING);
        public static readonly RootBuilder SUCCESSFULLY_LEFT_PARTY = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<string, Parser<string, RootParser>>, Writer<string, Writer<string, RootWriter>>> PARTY_CHAT = Parsers.STRING2_ASTERISK;
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> PARTY_MEMBER_LEFT = Parsers.STRING;
        public static readonly ParserBuilder<Parser<bool, Parser<bool, Parser<bool, Parser<bool, Parser<bool, Parser<bool, Parser<byte, Parser<byte, Parser<Language, Parser<byte, Parser<TipBehaviour, RootParser>>>>>>>>>>>, Writer<bool, Writer<bool, Writer<bool, Writer<bool, Writer<bool, Writer<bool, Writer<byte, Writer<byte, Writer<Language, Writer<byte, Writer<TipBehaviour, RootWriter>>>>>>>>>>>> SETTINGS_INFORMATION = Parsers.ROOT.After(Converters.Byte<TipBehaviour>()).After(Converters.Byte<byte>()).After(Converters.Byte<Language>()).After(Converters.Byte<byte>()).After(Converters.Byte<byte>()).After(Converters.BOOLEAN1).After(Converters.BOOLEAN1).After(Converters.BOOLEAN1).After(Converters.BOOLEAN1).After(Converters.BOOLEAN1).After(Converters.BOOLEAN1);
        public static readonly ParserBuilder<Parser<string, Parser<uint, Parser<OnlineStatus, Parser<bool, RootParser>>>>, Writer<string, Writer<uint, Writer<OnlineStatus, Writer<bool, RootWriter>>>>> ADD_FRIEND = Parsers.STRING_UINT_ONLINE_BOOLEAN_COMMA;
        public static readonly RootBuilder FORCED_LOGOUT = Parsers.ROOT;
        public static readonly RootBuilder RETURN_TO_HOME_PAGE = Parsers.ROOT;
        public static readonly RootBuilder SHOP_PURCHASE_SUCCESS = Parsers.ROOT;
        public static readonly ParserBuilder<RepeatParser<Parser<Character, RootParser>, RootParser>, RepeatWriter<Writer<Character, RootWriter>, RootWriter>> PURCHASED_CHARACTERS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<Character>()));
        public static readonly ParserBuilder<RepeatParser<Parser<House, RootParser>, RootParser>, RepeatWriter<Writer<House, RootWriter>, RootWriter>> PURCHASED_HOUSES = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<House>()));
        public static readonly ParserBuilder<RepeatParser<Parser<Background, RootParser>, RootParser>, RepeatWriter<Writer<Background, RootWriter>, RootWriter>> PURCHASED_BACKGROUNDS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<Background>()));
        public static readonly ParserBuilder<Parser<Character, Parser<House, Parser<Background, Parser<Pet?, Parser<LobbyIcon, Parser<DeathAnimation, Parser<Scroll?, Parser<Scroll?, Parser<Scroll?, Parser<string, RootParser>>>>>>>>>>, Writer<Character, Writer<House, Writer<Background, Writer<Pet?, Writer<LobbyIcon, Writer<DeathAnimation, Writer<Scroll?, Writer<Scroll?, Writer<Scroll?, Writer<string, RootWriter>>>>>>>>>>> SELECTION_SETTINGS = Parsers.ROOT.After(Converters.STRING, 0x2C).After(Converters.Safe(Converters.UInt<Scroll>(), "-2"), 0x2C).After(Converters.Safe(Converters.UInt<Scroll>(), "-2"), 0x2C).After(Converters.Safe(Converters.UInt<Scroll>(), "-2"), 0x2C).After(Converters.UInt<DeathAnimation>(), 0x2C).After(Converters.UInt<LobbyIcon>(), 0x2C).After(Converters.Safe(Converters.UInt<Pet>(), "-2"), 0x2C).After(Converters.UInt<Background>(), 0x2C).After(Converters.UInt<House>(), 0x2C).After(Converters.UInt<Character>());
        public static readonly ParserBuilder<Parser<RedeemCodeResult, ConditionalParser<Parser<RedeemCodeReward, Parser<string, RootParser>>, RootParser>>, Writer<RedeemCodeResult, ConditionalWriter<Writer<RedeemCodeReward, Writer<string, RootWriter>>, RootWriter>>> REDEEM_CODE_MESSAGE = Parsers.STRING.After(Converters.UInt<RedeemCodeReward>()).Condition(Parsers.ROOT).After(Converters.Byte<RedeemCodeResult>());
        public static readonly ParserBuilder<Parser<uint, RootParser>, Writer<uint, RootWriter>> UPDATE_PAID_CURRENCY = Parsers.UINT;
        public static readonly ParserBuilder<RepeatParser<Parser<Pack, RootParser>, RootParser>, RepeatWriter<Writer<Pack, RootWriter>, RootWriter>> PURCHASED_PACKS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<Pack>()));
        public static readonly ParserBuilder<RepeatParser<Parser<Pet, RootParser>, RootParser>, RepeatWriter<Writer<Pet, RootWriter>, RootWriter>> PURCHASED_PETS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<Pet>()));
        public static readonly ParserBuilder<Parser<uint, RootParser>, Writer<uint, RootWriter>> SET_LAST_BONUS_WIN_TIME = Parsers.UINT;
        public static readonly ParserBuilder<RepeatParser<Parser<Achievement, RootParser>, RootParser>, RepeatWriter<Writer<Achievement, RootWriter>, RootWriter>> EARNED_ACHIEVEMENTS_52 = Parsers.REPEAT_ACHIEVEMENT;
        public static readonly ParserBuilder<RepeatParser<Parser<LobbyIcon, RootParser>, RootParser>, RepeatWriter<Writer<LobbyIcon, RootWriter>, RootWriter>> PURCHASED_LOBBY_ICONS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<LobbyIcon>()));
        public static readonly ParserBuilder<RepeatParser<Parser<DeathAnimation, RootParser>, RootParser>, RepeatWriter<Writer<DeathAnimation, RootWriter>, RootWriter>> PURCHASED_DEATH_ANIMATIONS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<DeathAnimation>()));
        public static readonly RootBuilder FACEBOOK_INVITE_FRIENDS = Parsers.ROOT;
        public static readonly ParserBuilder<RepeatParser<Parser<Scroll, Parser<uint, RootParser>>, RootParser>, RepeatWriter<Writer<Scroll, Writer<uint, RootWriter>>, RootWriter>> PURCHASED_SCROLLS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<uint>(), 0x2A).After(Converters.UInt<Scroll>()));
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> HOST_GIVEN_TO_PLAYER = Parsers.STRING;
        public static readonly RootBuilder HOST_GIVEN_TO_ME = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> KICKED_PLAYER = Parsers.STRING;
        public static readonly RootBuilder KICKED_ME = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> INVITE_POWERS_GIVEN_TO_PLAYER = Parsers.STRING;
        public static readonly RootBuilder INVITE_POWERS_GIVEN_TO_ME = Parsers.ROOT;
        public static readonly RootBuilder STEAM_FIRST_LOGIN = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<string, Parser<string, RootParser>>, Writer<string, Writer<string, RootWriter>>> UPDATE_FRIEND_USERNAME = Parsers.STRING2_ASTERISK;
        public static readonly RootBuilder ENABLE_SHOP_BUTTONS = Parsers.ROOT;
        public static readonly RootBuilder STEAM_POPUP = Parsers.ROOT;
        public static readonly RootBuilder REGISTER = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> AUTHENTICATE_WITH_STEAM_CLOUD = Parsers.STRING;
        public static readonly ParserBuilder<Parser<bool, Parser<uint, RootParser>>, Writer<bool, Writer<uint, RootWriter>>> START_RANKED_QUEUE = Parsers.ROOT.After(Converters.UInt<uint>()).After(Converters.BOOLEAN1);
        public static readonly RootBuilder LEAVE_RANKED_QUEUE = Parsers.ROOT;
        public static readonly RootBuilder ACCEPT_RANKED_POPUP = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<uint, Parser<uint, Parser<uint, Parser<uint, Parser<uint, RootParser>>>>>, Writer<uint, Writer<uint, Writer<uint, Writer<uint, Writer<uint, RootWriter>>>>>> USER_STATISTICS = Parsers.ROOT.After(Converters.UInt<uint>(), 0x2A).After(Converters.UInt<uint>(), 0x2A).After(Converters.UInt<uint>(), 0x2A).After(Converters.UInt<uint>(), 0x2A).After(Converters.UInt<uint>());
        public static readonly ParserBuilder<Parser<uint, RootParser>, Writer<uint, RootWriter>> RANKED_TIMEOUT_DURATION = Parsers.UINT;
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> AUTHENTICATE_WITH_STEAM = Parsers.STRING;
        public static readonly ParserBuilder<Parser<ModeratorMessage, Parser<string, RootParser>>, Writer<ModeratorMessage, Writer<string, RootWriter>>> MODERATOR_MESSAGE = Parsers.STRING.After(Converters.Byte<ModeratorMessage>());
        public static readonly ParserBuilder<Parser<ReferralReward, ConditionalParser<Parser<uint, RootParser>, RootParser>>, Writer<ReferralReward, ConditionalWriter<Writer<uint, RootWriter>, RootWriter>>> REFER_A_FRIEND_UPDATE = Parsers.UINT.Condition(Parsers.ROOT).After(Converters.Byte<ReferralReward>());
        public static readonly ParserBuilder<RepeatParser<Parser<uint, RootParser>, RootParser>, RepeatWriter<Writer<uint, RootWriter>, RootWriter>> PLAYER_STATISTICS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<uint>()));
        public static readonly ParserBuilder<Parser<Scroll, RootParser>, Writer<Scroll, RootWriter>> SCROLL_CONSUMED = Parsers.ROOT.After(Converters.UInt<Scroll>());
        public static readonly ParserBuilder<Parser<AdViewResult, ConditionalParser<ConditionalParser<Parser<byte, RootParser>, Parser<uint, RootParser>>, RootParser>>, Writer<AdViewResult, ConditionalWriter<ConditionalWriter<Writer<byte, RootWriter>, Writer<uint, RootWriter>>, RootWriter>>> AD_VIEW_RESPONSE = Parsers.BYTE.Condition(Parsers.UINT).Condition(Parsers.ROOT).After(Converters.Byte<AdViewResult>());
        public static readonly RootBuilder USER_JOINING_LOBBY_TOO_QUICKLY = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<Promotion, Parser<uint, Parser<double, Parser<uint, RootParser>>>>, Writer<Promotion, Writer<uint, Writer<double, Writer<uint, RootWriter>>>>> PROMOTION_POPUP = Parsers.ROOT.After(Converters.UInt<uint>(), 0x2C).After(Converters.DOUBLE, 0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<Promotion>());
        public static readonly RootBuilder KICKSTARTER_SHARE = Parsers.ROOT;
        public static readonly ParserBuilder<RepeatParser<Parser<TutorialTip, RootParser>, RootParser>, RepeatWriter<Writer<TutorialTip, RootWriter>, RootWriter>> TUTORIAL_PROGRESS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<TutorialTip>()));
        public static readonly ParserBuilder<RepeatParser<Parser<Taunt, Parser<uint, RootParser>>, RootParser>, RepeatWriter<Writer<Taunt, Writer<uint, RootWriter>>, RootWriter>> PURCHASED_TAUNTS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<uint>(), 0x2A).After(Converters.UInt<Taunt>()));
        public static readonly ParserBuilder<RepeatParser<Parser<Currency, Parser<uint, RootParser>>, RootParser>, RepeatWriter<Writer<Currency, Writer<uint, RootWriter>>, RootWriter>> CURRENCY_MULTIPLIER = Parsers.ROOT.Repeat(1, new RootBuilder(0x2A).After(Converters.UInt<uint>()).After(Converters.UInt<Currency>()));
        public static readonly ParserBuilder<Parser<byte, Parser<GameMode, RootParser>>, Writer<byte, Writer<GameMode, RootWriter>>> PICK_NAMES = Parsers.ROOT.After(Converters.Byte<GameMode>()).After(Converters.Byte<byte>());
        public static readonly ParserBuilder<Parser<Player, Parser<string, RootParser>>, Writer<Player, Writer<string, RootWriter>>> NAMES_AND_POSITIONS_OF_USERS = Parsers.PLAYER_STRING;
        public static readonly ParserBuilder<Parser<Role, Parser<Player, Parser<Option<Player>, RootParser>>>, Writer<Role, Writer<Player, Writer<Option<Player>, RootWriter>>>> ROLE_AND_POSITION = Parsers.ROOT.After(Converters.Optional(Converters.Byte<Player>())).After(Converters.Byte<Player>()).After(Converters.Byte<Role>());
        public static readonly RootBuilder START_NIGHT = Parsers.ROOT;
        public static readonly RootBuilder START_DAY = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<Player, Parser<Role, Parser<bool, RepeatParser<Parser<DeathCause, RootParser>, RootParser>>>>, Writer<Player, Writer<Role, Writer<bool, RepeatWriter<Writer<DeathCause, RootWriter>, RootWriter>>>>> WHO_DIED_AND_HOW = Parsers.ROOT.Repeat(0, Parsers.ROOT.After(Converters.Byte<DeathCause>())).After(Converters.BOOLEAN1).After(Converters.Byte<Role>()).After(Converters.Byte<Player>());
        public static readonly RootBuilder START_DISCUSSION = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<byte, RootParser>, Writer<byte, RootWriter>> START_VOTING = Parsers.BYTE;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> START_DEFENSE_TRANSITION = Parsers.PLAYER;
        public static readonly RootBuilder START_JUDGEMENT = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<byte, Parser<byte, RootParser>>, Writer<byte, Writer<byte, RootWriter>>> TRIAL_FOUND_GUILTY = Parsers.BYTE2;
        public static readonly ParserBuilder<Parser<byte, Parser<byte, RootParser>>, Writer<byte, Writer<byte, RootWriter>>> TRIAL_FOUND_NOT_GUILTY = Parsers.BYTE2;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> LOOKOUT_NIGHT_ABILITY_MESSAGE = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<Player, Parser<Player, Parser<byte, RootParser>>>, Writer<Player, Writer<Player, Writer<byte, RootWriter>>>> USER_VOTED = Parsers.PLAYER2_RAWBYTE;
        public static readonly ParserBuilder<Parser<Player, Parser<Player, Parser<byte, RootParser>>>, Writer<Player, Writer<Player, Writer<byte, RootWriter>>>> USER_CANCELED_VOTE = Parsers.PLAYER2_RAWBYTE;
        public static readonly ParserBuilder<Parser<Player, Parser<Player, Parser<Player, Parser<byte, RootParser>>>>, Writer<Player, Writer<Player, Writer<Player, Writer<byte, RootWriter>>>>> USER_CHANGED_VOTE = Parsers.ROOT.After(Converters.Byte<byte>(0u)).After(Converters.Byte<Player>()).After(Converters.Byte<Player>()).After(Converters.Byte<Player>());
        public static readonly ParserBuilder<Parser<bool, RootParser>, Writer<bool, RootWriter>> USER_DIED = Parsers.BOOLEAN;
        public static readonly ParserBuilder<Parser<Player, Parser<Role, RootParser>>, Writer<Player, Writer<Role, RootWriter>>> RESURRECTION = Parsers.PLAYER_ROLE;
        public static readonly ParserBuilder<RepeatParser<Parser<Role, RootParser>, RootParser>, RepeatWriter<Writer<Role, RootWriter>, RootWriter>> TELL_ROLE_LIST = Parsers.ROOT.Repeat(0, Parsers.ROLE);
        public static readonly ParserBuilder<Parser<LocalizationTable, Parser<Player, Parser<string, RootParser>>>, Writer<LocalizationTable, Writer<Player, Writer<string, RootWriter>>>> USER_CHOSEN_NAME = Parsers.ROOT.After(Converters.STRING).After(Converters.Byte<Player>()).After(Converters.Byte<LocalizationTable>());
        public static readonly ParserBuilder<RepeatParser<Parser<Player, Parser<Role, RootParser>>, RootParser>, RepeatWriter<Writer<Player, Writer<Role, RootWriter>>, RootWriter>> OTHER_MAFIA = Parsers.REPEAT_PLAYER_ROLE;
        public static readonly ParserBuilder<Parser<Role, RootParser>, Writer<Role, RootWriter>> TELL_TOWN_AMNESIAC_CHANGED_ROLE = Parsers.ROLE;
        public static readonly ParserBuilder<Parser<Role, Parser<Option<Player>, RootParser>>, Writer<Role, Writer<Option<Player>, RootWriter>>> AMNESIAC_CHANGED_ROLE = Parsers.ROOT.After(Converters.Optional(Converters.Byte<Player>())).After(Converters.Byte<Role>());
        public static readonly RootBuilder BROUGHT_BACK_TO_LIFE = Parsers.ROOT;
        public static readonly RootBuilder START_FIRST_DAY = Parsers.ROOT;
        public static readonly RootBuilder BEING_JAILED = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<Player, Parser<bool, Parser<bool, RootParser>>>, Writer<Player, Writer<bool, Writer<bool, RootWriter>>>> JAILED_TARGET = Parsers.ROOT.After(Converters.BOOLEAN1).After(Converters.BOOLEAN1).After(Converters.Byte<Player>());
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> USER_JUDGEMENT_VOTED = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> USER_CHANGED_JUDGEMENT_VOTE = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> USER_CANCELED_JUDGEMENT_VOTE = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<Player, Parser<JudgementVote, RootParser>>, Writer<Player, Writer<JudgementVote, RootWriter>>> TELL_JUDGEMENT_VOTES = Parsers.ROOT.After(Converters.Byte<JudgementVote>()).After(Converters.Byte<Player>());
        public static readonly RootBuilder EXECUTIONER_COMPLETED_GOAL = Parsers.ROOT;
        public static readonly RootBuilder JESTER_COMPLETED_GOAL = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> MAYOR_REVEALED = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> MAYOR_REVEALED_AND_ALREADY_VOTED = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> DISGUISER_STOLE_YOUR_IDENTITY = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> DISGUISER_CHANGED_IDENTITY = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<Player, Parser<Player, RootParser>>, Writer<Player, Writer<Player, RootWriter>>> DISGUISER_CHANGED_UPDATE_MAFIA = Parsers.PLAYER2;
        public static readonly RootBuilder MEDIUM_IS_TALKING_TO_US = Parsers.ROOT;
        public static readonly RootBuilder MEDIUM_COMMUNICATING = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<Player, Parser<bool, ConditionalParser<Parser<string, RootParser>, RootParser>>>, Writer<Player, Writer<bool, ConditionalWriter<Writer<string, RootWriter>, RootWriter>>>> TELL_LAST_WILL = Parsers.ROOT.After(Converters.STRING).Condition(Parsers.ROOT).After(Converters.BOOLEAN1).After(Converters.Byte<Player>());
        public static readonly ParserBuilder<Parser<byte, RootParser>, Writer<byte, RootWriter>> HOW_MANY_ABILITIES_LEFT = Parsers.BYTE;
        public static readonly ParserBuilder<Parser<Player, Parser<Role, Parser<Player, Parser<byte, Parser<Option<byte>, Parser<Option<byte>, RootParser>>>>>>, Writer<Player, Writer<Role, Writer<Player, Writer<byte, Writer<Option<byte>, Writer<Option<byte>, RootWriter>>>>>>> MAFIA_TARGETING = Parsers.ROOT.After(Converters.Optional(Converters.Byte<byte>())).After(Converters.Optional(Converters.Byte<byte>())).After(Converters.Byte<byte>()).After(Converters.Byte<Player>()).After(Converters.Byte<Role>()).After(Converters.Byte<Player>());
        public static readonly ParserBuilder<Parser<Role, RootParser>, Writer<Role, RootWriter>> TELL_JANITOR_TARGETS_ROLE = Parsers.ROLE;
        public static readonly ParserBuilder<Parser<Player, Parser<string, RootParser>>, Writer<Player, Writer<string, RootWriter>>> TELL_JANITOR_TARGETS_WILL = Parsers.PLAYER_STRING;
        public static readonly ParserBuilder<Parser<Faction, RepeatParser<Parser<Player, RootParser>, RootParser>>, Writer<Faction, RepeatWriter<Writer<Player, RootWriter>, RootWriter>>> SOMEONE_HAS_WON = Parsers.ROOT.Repeat(0, Parsers.PLAYER).After(Converters.Byte<Faction>());
        public static readonly RootBuilder MAFIOSO_PROMOTED_TO_GODFATHER = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> MAFIOSO_PROMOTED_TO_GODFATHER_UPDATE_MAFIA = Parsers.PLAYER;
        public static readonly RootBuilder MAFIA_PROMOTED_TO_MAFIOSO;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> TELL_MAFIA_ABOUT_MAFIOSO_PROMOTION = Parsers.PLAYER;
        public static readonly RootBuilder EXECUTIONER_CONVERTED_TO_JESTER = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<Player, Parser<Role, RootParser>>, Writer<Player, Writer<Role, RootWriter>>> AMNESIAC_BECAME_MAFIA_OR_WITCH = Parsers.PLAYER_ROLE;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> USER_DISCONNECTED = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> MAFIA_WAS_JAILED = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<InvalidNameStatus, RootParser>, Writer<InvalidNameStatus, RootWriter>> INVALID_NAME_MESSAGE = Parsers.ROOT.After(Converters.Byte<InvalidNameStatus>());
        public static readonly RootBuilder START_NIGHT_TRANSITION = Parsers.ROOT;
        public static readonly ParserBuilder<RepeatParser<Parser<Player, RootParser>, RootParser>, RepeatWriter<Writer<Player, RootWriter>, RootWriter>> START_DAY_TRANSITION = Parsers.REPEAT_PLAYER;
        public static readonly RootBuilder LYNCH_USER = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<Player, Parser<bool, Parser<string, RootParser>>>, Writer<Player, Writer<bool, Writer<string, RootWriter>>>> DEATH_NOTE = Parsers.ROOT.After(Converters.STRING).After(Converters.BOOLEAN1).After(Converters.Byte<Player>());
        public static readonly ParserBuilder<RepeatParser<Parser<Player, Parser<House, RootParser>>, RootParser>, RepeatWriter<Writer<Player, Writer<House, RootWriter>>, RootWriter>> HOUSES_CHOSEN = Parsers.ROOT.Repeat(0, Parsers.ROOT.After(Converters.Byte<House>()).After(Converters.Byte<Player>()));
        public static readonly RootBuilder FIRST_DAY_TRANSITION = Parsers.ROOT;
        public static readonly ParserBuilder<RepeatParser<Parser<Player, Parser<Character, RootParser>>, RootParser>, RepeatWriter<Writer<Player, Writer<Character, RootWriter>>, RootWriter>> CHARACTERS_CHOSEN = Parsers.ROOT.Repeat(0, Parsers.ROOT.After(Converters.Byte<Character>()).After(Converters.Byte<Player>()));
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> RESURRECTION_SET_ALIVE = Parsers.PLAYER;
        public static readonly RootBuilder START_DEFENSE = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> USER_LEFT_DURING_SELECTION = Parsers.PLAYER;
        public static readonly RootBuilder VIGILANTE_KILLED_TOWN = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<Player, Parser<Player, RootParser>>, Writer<Player, Writer<Player, RootWriter>>> NOTIFY_USERS_OF_PRIVATE_MESSAGE = Parsers.PLAYER2;
        public static readonly ParserBuilder<Parser<PrivateMessageType, Parser<Player, ConditionalParser<Parser<string, RootParser>, Parser<Player, Parser<string, RootParser>>>>>, Writer<PrivateMessageType, Writer<Player, ConditionalWriter<Writer<string, RootWriter>, Writer<Player, Writer<string, RootWriter>>>>>> PRIVATE_MESSAGE = Parsers.ROOT.After(Converters.STRING).Condition(Parsers.PLAYER_STRING).After(Converters.Byte<Player>()).After(Converters.Byte<PrivateMessageType>());
        public static readonly ParserBuilder<RepeatParser<Parser<Achievement, RootParser>, RootParser>, RepeatWriter<Writer<Achievement, RootWriter>, RootWriter>> EARNED_ACHIEVEMENTS_161 = Parsers.REPEAT_ACHIEVEMENT;
        public static readonly ParserBuilder<Parser<AuthenticationResult, ConditionalParser<Parser<uint, RootParser>, RootParser>>, Writer<AuthenticationResult, ConditionalWriter<Writer<uint, RootWriter>, RootWriter>>> AUTHENTICATION_FAILED = Parsers.UINT.Condition(Parsers.ROOT).After(Converters.Byte<AuthenticationResult>());
        public static readonly ParserBuilder<Parser<bool, Parser<Player, RootParser>>, Writer<bool, Writer<Player, RootWriter>>> SPY_NIGHT_ABILITY_MESSAGE = Parsers.ROOT.After(Converters.Byte<Player>()).After(Converters.BOOLEAN1);
        public static readonly RootBuilder ONE_DAY_BEFORE_STALEMATE = Parsers.ROOT;
        public static readonly ParserBuilder<RepeatParser<Parser<Player, Parser<Pet, RootParser>>, RootParser>, RepeatWriter<Writer<Player, Writer<Pet, RootWriter>>, RootWriter>> PETS_CHOSEN = Parsers.ROOT.Repeat(0, Parsers.ROOT.After(Converters.Byte<Pet>()).After(Converters.Byte<Player>()));
        public static readonly ParserBuilder<Parser<Achievement, RootParser>, Writer<Achievement, RootWriter>> FACEBOOK_SHARE_ACHIEVEMENT = Parsers.ROOT.After(Converters.UInt<Achievement>());
        public static readonly ParserBuilder<Parser<Faction, RootParser>, Writer<Faction, RootWriter>> FACEBOOK_SHARE_WIN = Parsers.ROOT.After(Converters.Byte<Faction>());
        public static readonly ParserBuilder<RepeatParser<Parser<Player, Parser<DeathAnimation, RootParser>>, RootParser>, RepeatWriter<Writer<Player, Writer<DeathAnimation, RootWriter>>, RootWriter>> DEATH_ANIMATIONS_CHOSEN = Parsers.ROOT.Repeat(0, Parsers.ROOT.After(Converters.Byte<DeathAnimation>()).After(Converters.Byte<Player>()));
        public static readonly RootBuilder FULL_MOON_NIGHT = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> IDENTIFY = Parsers.STRING;
        public static readonly ParserBuilder<Parser<uint, Parser<GameMode, Parser<Faction, Parser<bool, Parser<byte, Parser<byte, RepeatParser<Parser<string, Parser<string, Parser<Player, RepeatParser<Parser<Role, RootParser>, Parser<object, RootParser>>>>>, RootParser>>>>>>>, Writer<uint, Writer<GameMode, Writer<Faction, Writer<bool, Writer<byte, Writer<byte, RepeatWriter<Writer<string, Writer<string, Writer<Player, RepeatWriter<Writer<Role, RootWriter>, Writer<object, RootWriter>>>>>, RootWriter>>>>>>>> END_GAME_INFO = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.Default<object>(), 0x29).Repeat(0, Parsers.ROOT.After(Converters.Byte<Role>())).After(Converters.Byte<Player>()).After(Converters.STRING, 0x2C).After(Converters.STRING, 0x2C)).After(Converters.Byte<byte>()).After(Converters.Byte<byte>()).After(Converters.BOOLEAN1).After(Converters.Byte<Faction>()).After(Converters.Byte<GameMode>(), 0x2C).After(Converters.UInt<uint>());
        public static readonly ParserBuilder<Parser<Player, Parser<string, RootParser>>, Writer<Player, Writer<string, RootWriter>>> END_GAME_CHAT_MESSAGE = Parsers.PLAYER_STRING;
        public static readonly ParserBuilder<RepeatParser<Parser<Player, Parser<bool, RootParser>>, RootParser>, RepeatWriter<Writer<Player, Writer<bool, RootWriter>>, RootWriter>> END_GAME_USER_UPDATE = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.BOOLEAN1, 0x2C).After(Converters.Byte<Player>()));
        public static readonly ParserBuilder<RepeatParser<Parser<Role, Parser<uint, Parser<uint, RootParser>>>, RootParser>, RepeatWriter<Writer<Role, Writer<uint, Writer<uint, RootWriter>>>, RootWriter>> ROLE_LOTS_INFO_MESSAGE = Parsers.ROOT.Repeat(1, new RootBuilder(0x2A).After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<Role>()));
        public static readonly ParserBuilder<Parser<Uri, RootParser>, Writer<Uri, RootWriter>> EXTERNAL_PURCHASE = Parsers.ROOT.After(Converters.URI);
        public static readonly RootBuilder VAMPIRE_PROMOTION = Parsers.ROOT;
        public static readonly ParserBuilder<RepeatParser<Parser<Player, Parser<bool, RootParser>>, RootParser>, RepeatWriter<Writer<Player, Writer<bool, RootWriter>>, RootWriter>> OTHER_VAMPIRES = Parsers.ROOT.Repeat(0, Parsers.BOOLEAN.After(Converters.Byte<Player>()));
        public static readonly ParserBuilder<Parser<Player, Parser<bool, RootParser>>, Writer<Player, Writer<bool, RootWriter>>> ADD_VAMPIRE = Parsers.ROOT.After(Converters.BOOLEAN1).After(Converters.Byte<Player>());
        public static readonly ParserBuilder<Parser<bool, RootParser>, Writer<bool, RootWriter>> CAN_VAMPIRES_CONVERT = Parsers.BOOLEAN;
        public static readonly ParserBuilder<Parser<Player, Parser<Option<Player>, RootParser>>, Writer<Player, Writer<Option<Player>, RootWriter>>> VAMPIRE_DIED = Parsers.ROOT.After(Converters.Optional(Converters.Byte<Player>())).After(Converters.Byte<Player>());
        public static readonly RootBuilder VAMPIRE_HUNTER_PROMOTED = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> VAMPIRE_VISITED_MESSAGE = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<bool, RootParser>, Writer<bool, RootWriter>> CHECK_USERNAME_RESULT = Parsers.BOOLEAN;
        public static readonly ParserBuilder<Parser<NameChangeResult, RootParser>, Writer<NameChangeResult, RootWriter>> NAME_CHANGE_RESULT = Parsers.ROOT.After(Converters.Byte<NameChangeResult>());
        public static readonly ParserBuilder<Parser<AccountState, RootParser>, Writer<AccountState, RootWriter>> ACCOUNT_STATE = Parsers.ROOT.After(Converters.Byte<AccountState>());
        public static readonly ParserBuilder<RepeatParser<Parser<AccountItem, RootParser>, RootParser>, RepeatWriter<Writer<AccountItem, RootWriter>, RootWriter>> PURCHASED_ACCOUNT_ITEMS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<AccountItem>()));
        public static readonly ParserBuilder<Parser<AccountItem, Parser<uint, Parser<uint, RootParser>>>, Writer<AccountItem, Writer<uint, Writer<uint, RootWriter>>>> ACCOUNT_ITEM_CONSUMED = Parsers.ROOT.After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<AccountItem>());
        public static readonly ParserBuilder<Parser<Player, Parser<Player, RootParser>>, Writer<Player, Writer<Player, RootWriter>>> TRANSPORTER_NOTIFICATION = Parsers.PLAYER2;
        public static readonly ParserBuilder<Parser<ShopItem, Parser<uint, Parser<PurchaseSource, Parser<uint, Parser<PurchaseResult, Parser<ItemType, RepeatParser<Parser<ItemType, Parser<uint, RootParser>>, RootParser>>>>>>>, Writer<ShopItem, Writer<uint, Writer<PurchaseSource, Writer<uint, Writer<PurchaseResult, Writer<ItemType, RepeatWriter<Writer<ItemType, Writer<uint, RootWriter>>, RootWriter>>>>>>>> PRODUCT_PURCHASE_RESULT = Parsers.ROOT.Repeat(0, Parsers.ROOT.After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<ItemType>(), 0x2C)).After(Converters.UInt<ItemType>(), 0x2C).After(Converters.UInt<PurchaseResult>(), 0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<PurchaseSource>(), 0x2C).After(Converters.UInt<uint>()).After(Converters.UInt<ShopItem>());
        public static readonly ParserBuilder<Parser<uint, RootParser>, Writer<uint, RootWriter>> UPDATE_FREE_CURRENCY = Parsers.UINT;
        public static readonly ParserBuilder<RepeatParser<Parser<uint, Parser<string, Parser<uint, Parser<uint, RootParser>>>>, RootParser>, RepeatWriter<Writer<uint, Writer<string, Writer<uint, Writer<uint, RootWriter>>>>, RootWriter>> ACTIVE_EVENTS = Parsers.ROOT.Repeat(1, new RootBuilder(0x2A).After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.STRING, 0x2C).After(Converters.UInt<uint>()));
        public static readonly ParserBuilder<Parser<CauldronRewardType, Parser<uint, Parser<uint, Parser<bool, Parser<uint, RepeatParser<Parser<CauldronPotion, RootParser>, RepeatParser<Parser<ItemType, Parser<uint, Parser<uint, RootParser>>>, RootParser>>>>>>>, Writer<CauldronRewardType, Writer<uint, Writer<uint, Writer<bool, Writer<uint, RepeatWriter<Writer<CauldronPotion, RootWriter>, RepeatWriter<Writer<ItemType, Writer<uint, Writer<uint, RootWriter>>>, RootWriter>>>>>>>> CAULDRON_STATUS = Parsers.ROOT.Repeat(1, new RootBuilder(0x2A).After(Converters.UInt<uint>(), 0x7C).After(Converters.UInt<uint>(), 0x7C).After(Converters.UInt<ItemType>()), 0x2C).Repeat(0, Parsers.ROOT.After(Converters.UInt<CauldronPotion>()), 0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.BOOLEAN2, 0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<CauldronRewardType>());
        public static readonly ParserBuilder<Parser<Player, Parser<TauntTargetType, Parser<Taunt, Parser<bool, RootParser>>>>, Writer<Player, Writer<TauntTargetType, Writer<Taunt, Writer<bool, RootWriter>>>>> TAUNT_RESULT = Parsers.BOOLEAN.After(Converters.Byte<Taunt>()).After(Converters.Byte<TauntTargetType>()).After(Converters.Byte<Player>());
        public static readonly ParserBuilder<Parser<Player, Parser<TauntTargetType, Parser<Taunt, RootParser>>>, Writer<Player, Writer<TauntTargetType, Writer<Taunt, RootWriter>>>> TAUNT_ACTIVATED = Parsers.PLAYER_TYPE_TAUNT;
        public static readonly ParserBuilder<Parser<Taunt, RootParser>, Writer<Taunt, RootWriter>> TAUNT_CONSUMED = Parsers.ROOT.After(Converters.Byte<Taunt>());
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> TRACKER_NIGHT_ABILITY = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> AMBUSHER_NIGHT_ABILITY = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> GUARDIAN_ANGEL_PROTECTION = Parsers.PLAYER;
        public static readonly RootBuilder PIRATE_DUEL = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> DUEL_TARGET = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<byte, Parser<byte, Parser<byte, RootParser>>>, Writer<byte, Writer<byte, Writer<byte, RootWriter>>>> POTION_MASTER_POTIONS = Parsers.ROOT.After(Converters.Byte<byte>()).After(Converters.Byte<byte>()).After(Converters.Byte<byte>());
        public static readonly ParserBuilder<Parser<bool, ConditionalParser<RootParser, Parser<byte, RootParser>>>, Writer<bool, ConditionalWriter<RootWriter, Writer<byte, RootWriter>>>> HAS_NECRONOMICON = Parsers.ROOT.Condition(Parsers.ROOT.After(Converters.Byte<byte>(0u))).After(Converters.BOOLEAN1);
        public static readonly ParserBuilder<RepeatParser<Parser<Player, Parser<Role, RootParser>>, RootParser>, RepeatWriter<Writer<Player, Writer<Role, RootWriter>>, RootWriter>> OTHER_WITCHES = Parsers.REPEAT_PLAYER_ROLE;
        public static readonly ParserBuilder<Parser<bool, Parser<Player, Parser<Player, ConditionalParser<RootParser, Parser<Player, RootParser>>>>>, Writer<bool, Writer<Player, Writer<Player, ConditionalWriter<RootWriter, Writer<Player, RootWriter>>>>>> PSYCHIC_NIGHT_ABILITY = Parsers.ROOT.Condition(Parsers.PLAYER).After(Converters.Byte<Player>()).After(Converters.Byte<Player>()).After(Converters.BOOLEAN1);
        public static readonly ParserBuilder<Parser<Role, RootParser>, Writer<Role, RootWriter>> TRAPPER_NIGHT_ABILITY = Parsers.ROLE;
        public static readonly ParserBuilder<Parser<TrapStatus, RootParser>, Writer<TrapStatus, RootWriter>> TRAPPER_TRAP_STATUS = Parsers.ROOT.After(Converters.Byte<TrapStatus>());
        public static readonly RootBuilder PESTILENCE_CONVERSION = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<byte, RootParser>, Writer<byte, RootWriter>> JUGGERNAUT_KILL_COUNT = Parsers.BYTE;
        public static readonly ParserBuilder<Parser<bool, Parser<Player, ConditionalParser<RootParser, Parser<Player, RootParser>>>>, Writer<bool, Writer<Player, ConditionalWriter<RootWriter, Writer<Player, RootWriter>>>>> COVEN_GOT_NECRONOMICON = Parsers.ROOT.Condition(Parsers.PLAYER).After(Converters.Byte<Player>()).After(Converters.BOOLEAN1);
        public static readonly RootBuilder GUARDIAN_ANGEL_PROMOTED = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> VIP_TARGET = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<DuelAttack, Parser<DuelDefense, RootParser>>, Writer<DuelAttack, Writer<DuelDefense, RootWriter>>> PIRATE_DUEL_OUTCOME = Parsers.ROOT.After(Converters.Byte<DuelDefense>()).After(Converters.Byte<DuelAttack>());
        public static readonly ParserBuilder<Parser<Brand, Parser<GameMode, Parser<SetConfigResult, RootParser>>>, Writer<Brand, Writer<GameMode, Writer<SetConfigResult, RootWriter>>>> HOST_SET_PARTY_CONFIG_RESULT = Parsers.ROOT.After(Converters.Byte<SetConfigResult>()).After(Converters.Byte<GameMode>()).After(Converters.Byte<Brand>());
        public static readonly ParserBuilder<RepeatParser<Parser<GameMode, RootParser>, RootParser>, RepeatWriter<Writer<GameMode, RootWriter>, RootWriter>> ACTIVE_GAME_MODES = Parsers.ROOT.Repeat(0, Parsers.GAMEMODE);
        public static readonly ParserBuilder<Parser<AccountFlags, RootParser>, Writer<AccountFlags, RootWriter>> ACCOUNT_FLAGS = Parsers.ROOT.After(Converters.Byte<AccountFlags>());
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> ZOMBIE_ROTTED = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> LOVER_TARGET = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> PLAGUE_SPREAD = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> RIVAL_TARGET = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<GameMode, Parser<uint, Parser<uint, Parser<uint, Parser<uint, Parser<uint, Parser<uint, Parser<uint, Parser<bool, Parser<uint, Parser<uint, Parser<uint, Parser<uint, Parser<uint, Parser<uint, Parser<uint, RootParser>>>>>>>>>>>>>>>>, Writer<GameMode, Writer<uint, Writer<uint, Writer<uint, Writer<uint, Writer<uint, Writer<uint, Writer<uint, Writer<bool, Writer<uint, Writer<uint, Writer<uint, Writer<uint, Writer<uint, Writer<uint, Writer<uint, RootWriter>>>>>>>>>>>>>>>>> RANKED_INFO = Parsers.UINT5_COMMA.After(Converters.UInt<uint>()).After(Converters.UInt<uint>()).After(Converters.BOOLEAN2).After(Converters.UInt<uint>()).After(Converters.UInt<uint>()).After(Converters.UInt<uint>()).After(Converters.UInt<uint>()).After(Converters.UInt<uint>()).After(Converters.UInt<uint>()).After(Converters.UInt<uint>()).After(Converters.Byte<GameMode>());
        public static readonly ParserBuilder<Parser<Player, Parser<bool, Parser<ExecuteReason, RootParser>>>, Writer<Player, Writer<bool, Writer<ExecuteReason, RootWriter>>>> JAILOR_DEATH_NOTE = Parsers.ROOT.After(Converters.Byte<ExecuteReason>()).After(Converters.BOOLEAN1).After(Converters.Byte<Player>());
        public static readonly ParserBuilder<Parser<DisconnectReason, RootParser>, Writer<DisconnectReason, RootWriter>> DISCONNECTED = Parsers.ROOT.After(Converters.Byte<DisconnectReason>());
        public static readonly ParserBuilder<RepeatParser<Parser<LocalizationTable, RootParser>, RootParser>, RepeatWriter<Writer<LocalizationTable, RootWriter>, RootWriter>> SPY_NIGHT_INFO = Parsers.ROOT.Repeat(0, Parsers.LOCALIZATION);
        public static readonly ParserBuilder<RepeatParser<Parser<bool, RootParser>, RootParser>, RepeatWriter<Writer<bool, RootWriter>, RootWriter>> SERVER_FLAGS = Parsers.ROOT.Repeat(0, Parsers.BOOLEAN);

        public static void Authenticated(this MessageParser parser, bool registered) => parser.Parse((byte)ServerMessageType.AUTHENTICATED, (buffer, index) => AUTHENTICATED.Build(buffer, index).Parse(registered));
        public static void CreateLobby(this MessageParser parser, bool host, GameMode mode) => parser.Parse((byte)ServerMessageType.CREATE_LOBBY, (buffer, index) => CREATE_LOBBY.Build(buffer, index).Parse(host).Parse(mode));
        public static void SetHost(this MessageParser parser) => parser.Parse((byte)ServerMessageType.SET_HOST, SET_HOST.Build);
        public static void UserJoinedGame(this MessageParser parser, bool host, bool display, string username, Player id, LobbyIcon icon) => parser.Parse((byte)ServerMessageType.USER_JOINED_GAME, (buffer, index) => USER_JOINED_GAME.Build(buffer, index).Parse(host).Parse(display).Parse(username).Parse(id).Parse(icon));
        public static void UserLeftGame(this MessageParser parser, bool update, bool display, Player id) => parser.Parse((byte)ServerMessageType.USER_LEFT_GAME, (buffer, index) => USER_LEFT_GAME.Build(buffer, index).Parse(update).Parse(display).Parse(id));
        public static void ChatBoxMessage(this MessageParser parser, bool inGame, Player id, string message) => parser.Parse((byte)ServerMessageType.CHAT_BOX_MESSAGE, (buffer, index) => CHAT_BOX_MESSAGE.Build(buffer, index).Parse(inGame).Parse(id).Parse(message));
        public static void HostClickedOnCatalog(this MessageParser parser, Catalog catalog) => parser.Parse((byte)ServerMessageType.HOST_CLICKED_ON_CATALOG, (buffer, index) => HOST_CLICKED_ON_CATALOG.Build(buffer, index).Parse(catalog));
        public static void HostClickedOnPossibleRoles(this MessageParser parser, byte selectedIndex, byte scrollPosition) => parser.Parse((byte)ServerMessageType.HOST_CLICKED_ON_POSSIBLE_ROLES, (buffer, index) => HOST_CLICKED_ON_POSSIBLE_ROLES.Build(buffer, index).Parse(selectedIndex).Parse(scrollPosition));
        public static void HostClickedOnAddButton(this MessageParser parser, Role role) => parser.Parse((byte)ServerMessageType.HOST_CLICKED_ON_ADD_BUTTON, (buffer, index) => HOST_CLICKED_ON_ADD_BUTTON.Build(buffer, index).Parse(role));
        public static void HostClickedOnRemoveButton(this MessageParser parser, byte slotIndex) => parser.Parse((byte)ServerMessageType.HOST_CLICKED_ON_REMOVE_BUTTON, (buffer, index) => HOST_CLICKED_ON_REMOVE_BUTTON.Build(buffer, index).Parse(slotIndex));
        public static void HostClickedOnStartButton(this MessageParser parser) => parser.Parse((byte)ServerMessageType.HOST_CLICKED_ON_START_BUTTON, HOST_CLICKED_ON_START_BUTTON.Build);
        public static void CancelStartCooldown(this MessageParser parser) => parser.Parse((byte)ServerMessageType.CANCEL_START_COOLDOWN, CANCEL_START_COOLDOWN.Build);
        public static void AssignNewHost(this MessageParser parser, Player newHost) => parser.Parse((byte)ServerMessageType.ASSIGN_NEW_HOST, (buffer, index) => ASSIGN_NEW_HOST.Build(buffer, index).Parse(newHost));
        public static void VotedToRepickHost(this MessageParser parser, byte votesUntilRepick) => parser.Parse((byte)ServerMessageType.VOTED_TO_REPICK_HOST, (buffer, index) => VOTED_TO_REPICK_HOST.Build(buffer, index).Parse(votesUntilRepick));
        public static void NoLongerHost(this MessageParser parser) => parser.Parse((byte)ServerMessageType.NO_LONGER_HOST, NO_LONGER_HOST.Build);
        public static void DoNotSpam(this MessageParser parser) => parser.Parse((byte)ServerMessageType.DO_NOT_SPAM, DO_NOT_SPAM.Build);
        public static void HowManyPlayersAndGames(this MessageParser parser, uint playerCount, uint gameCount) => parser.Parse((byte)ServerMessageType.HOW_MANY_PLAYERS_AND_GAMES, (buffer, index) => HOW_MANY_PLAYERS_AND_GAMES.Build(buffer, index).Parse(gameCount).Parse(playerCount));
        public static void SystemMessage(this MessageParser parser, string message) => parser.Parse((byte)ServerMessageType.SYSTEM_MESSAGE, (buffer, index) => SYSTEM_MESSAGE.Build(buffer, index).Parse(message));
        public static void StringTableMessage(this MessageParser parser, LocalizationTable message) => parser.Parse((byte)ServerMessageType.STRING_TABLE_MESSAGE, (buffer, index) => STRING_TABLE_MESSAGE.Build(buffer, index).Parse(message));
        public static void FriendList(this MessageParser parser, params (string username, uint friendID, OnlineStatus status, bool ownsCoven)[] friends) => parser.Parse((byte)ServerMessageType.FRIEND_LIST, (buffer, index) => FRIEND_LIST.Build(buffer, index).Parse(friends, (friend, p) => p.Parse(friend.username).Parse(friend.friendID).Parse(friend.status).Parse(friend.ownsCoven)));
        public static void FriendRequestNotifications(this MessageParser parser, params (string username, uint friendID)[] requests) => parser.Parse((byte)ServerMessageType.FRIEND_REQUEST_NOTIFICATIONS, (buffer, index) => FRIEND_REQUEST_NOTIFICATIONS.Build(buffer, index).Parse(requests, (request, p) => p.Parse(request.username).Parse(request.friendID)));
        public static void AddFriendRequestResponse(this MessageParser parser, bool success) => parser.Parse((byte)ServerMessageType.ADD_FRIEND_REQUEST_RESPONSE, (buffer, index) => ADD_FRIEND_REQUEST_RESPONSE.Build(buffer, index).Parse(success));
        public static void ConfirmFriendRequest(this MessageParser parser, uint friendID, OnlineStatus status, bool ownsCoven) => parser.Parse((byte)ServerMessageType.CONFIRM_FRIEND_REQUEST, (buffer, index) => CONFIRM_FRIEND_REQUEST.Build(buffer, index).Parse(friendID).Parse(status).Parse(ownsCoven));
        public static void SuccessfullyRemovedFriend(this MessageParser parser, uint friendID) => parser.Parse((byte)ServerMessageType.SUCCESSFULLY_REMOVED_FRIEND, (buffer, index) => SUCCESSFULLY_REMOVED_FRIEND.Build(buffer, index).Parse(friendID));
        public static void SuccessfullyDeclinedFriendRequest(this MessageParser parser) => parser.Parse((byte)ServerMessageType.SUCCESSFULLY_DECLINED_FRIEND_REQUEST, SUCCESSFULLY_DECLINED_FRIEND_REQUEST.Build);
        public static void FriendUpdate(this MessageParser parser, uint friendID, OnlineStatus status, bool ownsCoven) => parser.Parse((byte)ServerMessageType.FRIEND_UPDATE, (buffer, index) => FRIEND_UPDATE.Build(buffer, index).Parse(friendID).Parse(status).Parse(ownsCoven));
        public static void FriendMessage(this MessageParser parser, uint friendID, bool sent, string message) => parser.Parse((byte)ServerMessageType.FRIEND_MESSAGE, (buffer, index) => FRIEND_MESSAGE.Build(buffer, index).Parse(friendID).Parse(sent).Parse(message));
        public static void UserInformation(this MessageParser parser, string username, uint townPoints, uint meritPoints) => parser.Parse((byte)ServerMessageType.USER_INFORMATION, (buffer, index) => USER_INFORMATION.Build(buffer, index).Parse(username).Parse(townPoints).Parse(meritPoints));
        public static void CreatePartyLobby(this MessageParser parser, Brand brand) => parser.Parse((byte)ServerMessageType.CREATE_PARTY_LOBBY, (buffer, index) => CREATE_PARTY_LOBBY.Build(buffer, index).Parse(brand));
        public static void PartyInviteFailed(this MessageParser parser, string username, FailedInvitationStatus status) => parser.Parse((byte)ServerMessageType.PARTY_INVITE_FAILED, (buffer, index) => PARTY_INVITE_FAILED.Build(buffer, index).Parse(username).Parse(status));
        public static void PartyInviteNotification(this MessageParser parser, uint friendID, string username) => parser.Parse((byte)ServerMessageType.PARTY_INVITE_NOTIFICATION, (buffer, index) => PARTY_INVITE_NOTIFICATION.Build(buffer, index).Parse(friendID).Parse(username));
        public static void AcceptedPartyInvite(this MessageParser parser, AcceptInvitationResult result) => parser.Parse((byte)ServerMessageType.ACCEPTED_PARTY_INVITE, (buffer, index) => ACCEPTED_PARTY_INVITE.Build(buffer, index).Parse(result));
        public static void PendingPartyInviteStatus(this MessageParser parser, string username, PendingInvitationStatus status) => parser.Parse((byte)ServerMessageType.PENDING_PARTY_INVITE_STATUS, (buffer, index) => PENDING_PARTY_INVITE_STATUS.Build(buffer, index).Parse(username).Parse(status));
        public static void SuccessfullyLeftParty(this MessageParser parser) => parser.Parse((byte)ServerMessageType.SUCCESSFULLY_LEFT_PARTY, SUCCESSFULLY_LEFT_PARTY.Build);
        public static void PartyChat(this MessageParser parser, string username, string message) => parser.Parse((byte)ServerMessageType.PARTY_CHAT, (buffer, index) => PARTY_CHAT.Build(buffer, index).Parse(username).Parse(message));
        public static void PartyMemberLeft(this MessageParser parser, string username) => parser.Parse((byte)ServerMessageType.PARTY_MEMBER_LEFT, (buffer, index) => PARTY_MEMBER_LEFT.Build(buffer, index).Parse(username));
        public static void SettingsInformation(this MessageParser parser, bool filterChat, bool muteMusic, bool muteEffects, bool shareSkin, bool classicSkinsOnly, bool displayPets, byte effectsVolume, byte musicVolume, Language selectedLanguage, byte unknown, TipBehaviour tipBehaviour) => parser.Parse((byte)ServerMessageType.SETTINGS_INFORMATION, (buffer, index) => SETTINGS_INFORMATION.Build(buffer, index).Parse(filterChat).Parse(muteMusic).Parse(muteEffects).Parse(shareSkin).Parse(classicSkinsOnly).Parse(displayPets).Parse(effectsVolume).Parse(musicVolume).Parse(selectedLanguage).Parse(unknown).Parse(tipBehaviour));
        public static void AddFriend(this MessageParser parser, string username, uint id, OnlineStatus status, bool ownsCoven) => parser.Parse((byte)ServerMessageType.ADD_FRIEND, (buffer, index) => ADD_FRIEND.Build(buffer, index).Parse(username).Parse(id).Parse(status).Parse(ownsCoven));
        public static void ForcedLogout(this MessageParser parser) => parser.Parse((byte)ServerMessageType.FORCED_LOGOUT, FORCED_LOGOUT.Build);
        public static void ReturnToHomePage(this MessageParser parser) => parser.Parse((byte)ServerMessageType.RETURN_TO_HOME_PAGE, RETURN_TO_HOME_PAGE.Build);
        public static void ShopPurchaseSuccess(this MessageParser parser) => parser.Parse((byte)ServerMessageType.SHOP_PURCHASE_SUCCESS, SHOP_PURCHASE_SUCCESS.Build);
        public static void PurchasedCharacters(this MessageParser parser, params Character[] characters) => parser.Parse((byte)ServerMessageType.PURCHASED_CHARACTERS, (buffer, index) => PURCHASED_CHARACTERS.Build(buffer, index).Parse(characters, (character, p) => p.Parse(character)));
        public static void PurchasedHouses(this MessageParser parser, params House[] houses) => parser.Parse((byte)ServerMessageType.PURCHASED_HOUSES, (buffer, index) => PURCHASED_HOUSES.Build(buffer, index).Parse(houses, (house, p) => p.Parse(house)));
        public static void PurchasedBackgrounds(this MessageParser parser, params Background[] backgrounds) => parser.Parse((byte)ServerMessageType.PURCHASED_BACKGROUNDS, (buffer, index) => PURCHASED_BACKGROUNDS.Build(buffer, index).Parse(backgrounds, (background, p) => p.Parse(background)));
        public static void SelectionSettings(this MessageParser parser, Character character, House house, Background background, Pet? pet, LobbyIcon icon, DeathAnimation death, Scroll? scroll1, Scroll? scroll2, Scroll? scroll3, string name) => parser.Parse((byte)ServerMessageType.SELECTION_SETTINGS, (buffer, index) => SELECTION_SETTINGS.Build(buffer, index).Parse(character).Parse(house).Parse(background).Parse(pet).Parse(icon).Parse(death).Parse(scroll1).Parse(scroll2).Parse(scroll3).Parse(name));
        public static void RedeemCodeMessage(this MessageParser parser, RedeemCodeResult result, RedeemCodeReward? reward = null, string rewardArgs = "") => parser.Parse((byte)ServerMessageType.REDEEM_CODE_MESSAGE, (buffer, index) => REDEEM_CODE_MESSAGE.Build(buffer, index).Parse(result).Parse(reward != null, p => p.Parse(reward ?? default(RedeemCodeReward)).Parse(rewardArgs), p => p));
        public static void UpdatePaidCurrency(this MessageParser parser, uint amount) => parser.Parse((byte)ServerMessageType.UPDATE_PAID_CURRENCY, (buffer, index) => UPDATE_PAID_CURRENCY.Build(buffer, index).Parse(amount));
        public static void PurchasedPacks(this MessageParser parser, params Pack[] packs) => parser.Parse((byte)ServerMessageType.PURCHASED_PACKS, (buffer, index) => PURCHASED_PACKS.Build(buffer, index).Parse(packs, (pack, p) => p.Parse(pack)));
        public static void PurchasedPets(this MessageParser parser, params Pet[] pets) => parser.Parse((byte)ServerMessageType.PURCHASED_PETS, (buffer, index) => PURCHASED_PETS.Build(buffer, index).Parse(pets, (pet, p) => p.Parse(pet)));
        public static void SetLastBonusWinTime(this MessageParser parser, uint time) => parser.Parse((byte)ServerMessageType.SET_LAST_BONUS_WIN_TIME, (buffer, index) => SET_LAST_BONUS_WIN_TIME.Build(buffer, index).Parse(time));
        public static void EarnedAchievements52(this MessageParser parser, params Achievement[] achievements) => parser.Parse((byte)ServerMessageType.EARNED_ACHIEVEMENTS_52, (buffer, index) => EARNED_ACHIEVEMENTS_52.Build(buffer, index).Parse(achievements, (achievement, p) => p.Parse(achievement)));
        public static void PurchasedLobbyIcons(this MessageParser parser, params LobbyIcon[] icons) => parser.Parse((byte)ServerMessageType.PURCHASED_LOBBY_ICONS, (buffer, index) => PURCHASED_LOBBY_ICONS.Build(buffer, index).Parse(icons, (icon, p) => p.Parse(icon)));
        public static void PurchasedDeathAnimations(this MessageParser parser, params DeathAnimation[] deaths) => parser.Parse((byte)ServerMessageType.PURCHASED_DEATH_ANIMATIONS, (buffer, index) => PURCHASED_DEATH_ANIMATIONS.Build(buffer, index).Parse(deaths, (death, p) => p.Parse(death)));
        public static void FacebookInviteFriends(this MessageParser parser) => parser.Parse((byte)ServerMessageType.FACEBOOK_INVITE_FRIENDS, FACEBOOK_INVITE_FRIENDS.Build);
        public static void PurchasedScrolls(this MessageParser parser, params (Scroll scroll, uint amount)[] scrolls) => parser.Parse((byte)ServerMessageType.PURCHASED_SCROLLS, (buffer, index) => PURCHASED_SCROLLS.Build(buffer, index).Parse(scrolls, (scroll, p) => p.Parse(scroll.scroll).Parse(scroll.amount)));
        public static void HostGivenToPlayer(this MessageParser parser, string user) => parser.Parse((byte)ServerMessageType.HOST_GIVEN_TO_PLAYER, (buffer, index) => HOST_GIVEN_TO_PLAYER.Build(buffer, index).Parse(user));
        public static void HostGivenToMe(this MessageParser parser) => parser.Parse((byte)ServerMessageType.HOST_GIVEN_TO_ME, HOST_GIVEN_TO_ME.Build);
        public static void KickedPlayer(this MessageParser parser, string user) => parser.Parse((byte)ServerMessageType.KICKED_PLAYER, (buffer, index) => KICKED_PLAYER.Build(buffer, index).Parse(user));
        public static void KickedMe(this MessageParser parser) => parser.Parse((byte)ServerMessageType.KICKED_ME, KICKED_ME.Build);
        public static void InvitePowersGivenToPlayer(this MessageParser parser, string user) => parser.Parse((byte)ServerMessageType.INVITE_POWERS_GIVEN_TO_PLAYER, (buffer, index) => INVITE_POWERS_GIVEN_TO_PLAYER.Build(buffer, index).Parse(user));
        public static void InvitePowersGivenToMe(this MessageParser parser) => parser.Parse((byte)ServerMessageType.INVITE_POWERS_GIVEN_TO_ME, INVITE_POWERS_GIVEN_TO_ME.Build);
        public static void SteamFirstLogin(this MessageParser parser) => parser.Parse((byte)ServerMessageType.STEAM_FIRST_LOGIN, STEAM_FIRST_LOGIN.Build);
        public static void UpdateFriendUsername(this MessageParser parser, string oldName, string newName) => parser.Parse((byte)ServerMessageType.UPDATE_FRIEND_USERNAME, (buffer, index) => UPDATE_FRIEND_USERNAME.Build(buffer, index).Parse(oldName).Parse(newName));
        public static void EnableShopButtons(this MessageParser parser) => parser.Parse((byte)ServerMessageType.ENABLE_SHOP_BUTTONS, ENABLE_SHOP_BUTTONS.Build);
        public static void SteamPopup(this MessageParser parser) => parser.Parse((byte)ServerMessageType.STEAM_POPUP, STEAM_POPUP.Build);
        public static void Register(this MessageParser parser) => parser.Parse((byte)ServerMessageType.REGISTER, REGISTER.Build);
        public static void AuthenticateWithSteamCloud(this MessageParser parser, string username) => parser.Parse((byte)ServerMessageType.AUTHENTICATE_WITH_STEAM_CLOUD, (buffer, index) => AUTHENTICATE_WITH_STEAM_CLOUD.Build(buffer, index).Parse(username));
        public static void StartRankedQueue(this MessageParser parser, bool requeue, uint timer) => parser.Parse((byte)ServerMessageType.START_RANKED_QUEUE, (buffer, index) => START_RANKED_QUEUE.Build(buffer, index).Parse(requeue).Parse(timer));
        public static void LeaveRankedQueue(this MessageParser parser) => parser.Parse((byte)ServerMessageType.LEAVE_RANKED_QUEUE, LEAVE_RANKED_QUEUE.Build);
        public static void AcceptRankedPopup(this MessageParser parser) => parser.Parse((byte)ServerMessageType.ACCEPT_RANKED_POPUP, ACCEPT_RANKED_POPUP.Build);
        public static void UserStatistics(this MessageParser parser, uint gamesPlayed, uint gamesWon, uint gamesDrawn, uint gamesDisconnected, uint friendsReferred) => parser.Parse((byte)ServerMessageType.USER_STATISTICS, (buffer, index) => USER_STATISTICS.Build(buffer, index).Parse(gamesPlayed).Parse(gamesWon).Parse(gamesDrawn).Parse(gamesDisconnected).Parse(friendsReferred));
        public static void RankedTimeoutDuration(this MessageParser parser, uint duration) => parser.Parse((byte)ServerMessageType.RANKED_TIMEOUT_DURATION, (buffer, index) => RANKED_TIMEOUT_DURATION.Build(buffer, index).Parse(duration));
        public static void AuthenticateWithSteam(this MessageParser parser, string username) => parser.Parse((byte)ServerMessageType.AUTHENTICATE_WITH_STEAM, (buffer, index) => AUTHENTICATE_WITH_STEAM.Build(buffer, index).Parse(username));
        public static void ModeratorMessage(this MessageParser parser, ModeratorMessage message, string args) => parser.Parse((byte)ServerMessageType.MODERATOR_MESSAGE, (buffer, index) => MODERATOR_MESSAGE.Build(buffer, index).Parse(message).Parse(args));
        public static void ReferAFriendUpdate(this MessageParser parser, ReferralReward reward, uint? tpReward = null) => parser.Parse((byte)ServerMessageType.REFER_A_FRIEND_UPDATE, (buffer, index) => REFER_A_FRIEND_UPDATE.Build(buffer, index).Parse(reward).Parse(tpReward != null, p => p.Parse(tpReward ?? 0), p => p));
        public static void PlayerStatistics(this MessageParser parser, params uint[] statistics) => parser.Parse((byte)ServerMessageType.PLAYER_STATISTICS, (buffer, index) => PLAYER_STATISTICS.Build(buffer, index).Parse(statistics, (stat, p) => p.Parse(stat)));
        public static void ScrollConsumed(this MessageParser parser, Scroll scroll) => parser.Parse((byte)ServerMessageType.SCROLL_CONSUMED, (buffer, index) => SCROLL_CONSUMED.Build(buffer, index).Parse(scroll));
        public static void AdViewResponse(this MessageParser parser, AdViewResult result, uint value = 0) => parser.Parse((byte)ServerMessageType.AD_VIEW_RESPONSE, (buffer, index) => AD_VIEW_RESPONSE.Build(buffer, index).Parse(result).Parse(result == AdViewResult.GIVE_PRIZE || result == AdViewResult.SET_TOKEN, p => p.Parse(result == AdViewResult.GIVE_PRIZE, p2 => p2.Parse((byte)value), p2 => p2.Parse(value)), p => p));
        public static void UserJoiningLobbyTooQuickly(this MessageParser parser) => parser.Parse((byte)ServerMessageType.USER_JOINING_LOBBY_TOO_QUICKLY_MESSAGE, USER_JOINING_LOBBY_TOO_QUICKLY.Build);
        public static void PromotionPopup(this MessageParser parser, Promotion promotion, uint secondsActive, double discount, uint refID) => parser.Parse((byte)ServerMessageType.PROMOTION_POPUP, (buffer, index) => PROMOTION_POPUP.Build(buffer, index).Parse(promotion).Parse(secondsActive).Parse(discount).Parse(refID));
        public static void KickstarterShare(this MessageParser parser) => parser.Parse((byte)ServerMessageType.KICKSTARTER_SHARE, KICKSTARTER_SHARE.Build);
        public static void TutorialProgress(this MessageParser parser, params TutorialTip[] triggeredTips) => parser.Parse((byte)ServerMessageType.TUTORIAL_PROGRESS, (buffer, index) => TUTORIAL_PROGRESS.Build(buffer, index).Parse(triggeredTips, (tip, p) => p.Parse(tip)));
        public static void PurchasedTaunts(this MessageParser parser, params (Taunt id, uint amount)[] taunts) => parser.Parse((byte)ServerMessageType.PURCHASED_TAUNTS, (buffer, index) => PURCHASED_TAUNTS.Build(buffer, index).Parse(taunts, (taunt, p) => p.Parse(taunt.id).Parse(taunt.amount)));
        public static void CurrencyMultiplier(this MessageParser parser, params (Currency currency, uint multiplier)[] multipliers) => parser.Parse((byte)ServerMessageType.CURRENCY_MULTIPLIER, (buffer, index) => CURRENCY_MULTIPLIER.Build(buffer, index).Parse(multipliers, (multiplier, p) => p.Parse(multiplier.currency).Parse(multiplier.multiplier)));
        public static void PickNames(this MessageParser parser, byte playerCount, GameMode mode) => parser.Parse((byte)ServerMessageType.PICK_NAMES, (buffer, index) => PICK_NAMES.Build(buffer, index).Parse(playerCount).Parse(mode));
        public static void NamesAndPositionsOfUsers(this MessageParser parser, Player id, string name) => parser.Parse((byte)ServerMessageType.NAMES_AND_POSITIONS_OF_USERS, (buffer, index) => NAMES_AND_POSITIONS_OF_USERS.Build(buffer, index).Parse(id).Parse(name));
        public static void RoleAndPosition(this MessageParser parser, Role role, Player id, Player? target = null) => parser.Parse((byte)ServerMessageType.ROLE_AND_POSITION, (buffer, index) => ROLE_AND_POSITION.Build(buffer, index).Parse(role).Parse(id).Parse(target.ToOption()));
        public static void StartNight(this MessageParser parser) => parser.Parse((byte)ServerMessageType.START_NIGHT, START_NIGHT.Build);
        public static void StartDay(this MessageParser parser) => parser.Parse((byte)ServerMessageType.START_DAY, START_DAY.Build);
        public static void WhoDiedAndHow(this MessageParser parser, Player player, Role role, bool announce, params DeathCause[] causes) => parser.Parse((byte)ServerMessageType.WHO_DIED_AND_HOW, (buffer, index) => WHO_DIED_AND_HOW.Build(buffer, index).Parse(player).Parse(role).Parse(announce).Parse(causes, (cause, p) => p.Parse(cause)));
        public static void StartDiscussion(this MessageParser parser) => parser.Parse((byte)ServerMessageType.START_DISCUSSION, START_DISCUSSION.Build);
        public static void StartVoting(this MessageParser parser, byte votesNeeded) => parser.Parse((byte)ServerMessageType.START_VOTING, (buffer, index) => START_VOTING.Build(buffer, index).Parse(votesNeeded));
        public static void StartDefenseTransition(this MessageParser parser, Player player) => parser.Parse((byte)ServerMessageType.START_DEFENSE_TRANSITION, (buffer, index) => START_DEFENSE_TRANSITION.Build(buffer, index).Parse(player));
        public static void StartJudgement(this MessageParser parser) => parser.Parse((byte)ServerMessageType.START_JUDGEMENT, START_JUDGEMENT.Build);
        public static void TrialFoundGuilty(this MessageParser parser, byte guiltyVotes, byte innocentVotes) => parser.Parse((byte)ServerMessageType.TRIAL_FOUND_GUILTY, (buffer, index) => TRIAL_FOUND_GUILTY.Build(buffer, index).Parse(guiltyVotes).Parse(innocentVotes));
        public static void TrialFoundNotGuilty(this MessageParser parser, byte guiltyVotes, byte innocentVotes) => parser.Parse((byte)ServerMessageType.TRIAL_FOUND_NOT_GUILTY, (buffer, index) => TRIAL_FOUND_NOT_GUILTY.Build(buffer, index).Parse(guiltyVotes).Parse(innocentVotes));
        public static void LookoutNightAbilityMessage(this MessageParser parser, Player player) => parser.Parse((byte)ServerMessageType.LOOKOUT_NIGHT_ABILITY_MESSAGE, (buffer, index) => LOOKOUT_NIGHT_ABILITY_MESSAGE.Build(buffer, index).Parse(player));
        public static void UserVoted(this MessageParser parser, Player voter, Player voted, byte voteCount) => parser.Parse((byte)ServerMessageType.USER_VOTED, (buffer, index) => USER_VOTED.Build(buffer, index).Parse(voter).Parse(voted).Parse(voteCount));
        public static void UserCanceledVote(this MessageParser parser, Player voter, Player voted, byte voteCount) => parser.Parse((byte)ServerMessageType.USER_CANCELED_VOTE, (buffer, index) => USER_CANCELED_VOTE.Build(buffer, index).Parse(voter).Parse(voted).Parse(voteCount));
        public static void UserChangedVote(this MessageParser parser, Player voter, Player newVoted, Player oldVoted, byte voteCount) => parser.Parse((byte)ServerMessageType.USER_CHANGED_VOTE, (buffer, index) => USER_CHANGED_VOTE.Build(buffer, index).Parse(voter).Parse(newVoted).Parse(oldVoted).Parse(voteCount));
        public static void UserDied(this MessageParser parser, bool silent) => parser.Parse((byte)ServerMessageType.USER_DIED, (buffer, index) => USER_DIED.Build(buffer, index).Parse(silent));
        public static void Resurrection(this MessageParser parser, Player player, Role role) => parser.Parse((byte)ServerMessageType.RESURRECTION, (buffer, index) => RESURRECTION.Build(buffer, index).Parse(player).Parse(role));
        public static void TellRoleList(this MessageParser parser, params Role[] roles) => parser.Parse((byte)ServerMessageType.TELL_ROLE_LIST, (buffer, index) => TELL_ROLE_LIST.Build(buffer, index).Parse(roles, (role, p) => p.Parse(role)));
        public static void UserChosenName(this MessageParser parser, LocalizationTable message, Player player, string name) => parser.Parse((byte)ServerMessageType.USER_CHOSEN_NAME, (buffer, index) => USER_CHOSEN_NAME.Build(buffer, index).Parse(message).Parse(player).Parse(name));
        public static void OtherMafia(this MessageParser parser, params (Player player, Role role)[] mafiaMembers) => parser.Parse((byte)ServerMessageType.OTHER_MAFIA, (buffer, index) => OTHER_MAFIA.Build(buffer, index).Parse(mafiaMembers, (member, p) => p.Parse(member.player).Parse(member.role)));
        public static void TellTownAmnesiacChangedRole(this MessageParser parser, Role role) => parser.Parse((byte)ServerMessageType.TELL_TOWN_AMNESIAC_CHANGED_ROLE, (buffer, index) => TELL_TOWN_AMNESIAC_CHANGED_ROLE.Build(buffer, index).Parse(role));
        public static void AmnesiacChangedRole(this MessageParser parser, Role role, Player? target = null) => parser.Parse((byte)ServerMessageType.AMNESIAC_CHANGED_ROLE, (buffer, index) => AMNESIAC_CHANGED_ROLE.Build(buffer, index).Parse(role).Parse(target.ToOption()));
        public static void BroughtBackToLife(this MessageParser parser) => parser.Parse((byte)ServerMessageType.BROUGHT_BACK_TO_LIFE, BROUGHT_BACK_TO_LIFE.Build);
        public static void StartFirstDay(this MessageParser parser) => parser.Parse((byte)ServerMessageType.START_FIRST_DAY, START_FIRST_DAY.Build);
        public static void BeingJailed(this MessageParser parser) => parser.Parse((byte)ServerMessageType.BEING_JAILED, BEING_JAILED.Build);
        public static void JailedTarget(this MessageParser parser, Player jailed, bool canExecute, bool executedTown) => parser.Parse((byte)ServerMessageType.JAILED_TARGET, (buffer, index) => JAILED_TARGET.Build(buffer, index).Parse(jailed).Parse(canExecute).Parse(executedTown));
        public static void UserJudgementVoted(this MessageParser parser, Player player) => parser.Parse((byte)ServerMessageType.USER_JUDGEMENT_VOTED, (buffer, index) => USER_JUDGEMENT_VOTED.Build(buffer, index).Parse(player));
        public static void UserChangedJudgementVote(this MessageParser parser, Player player) => parser.Parse((byte)ServerMessageType.USER_CHANGED_JUDGEMENT_VOTE, (buffer, index) => USER_CHANGED_JUDGEMENT_VOTE.Build(buffer, index).Parse(player));
        public static void UserCanceledJudgementVote(this MessageParser parser, Player player) => parser.Parse((byte)ServerMessageType.USER_CANCELED_JUDGEMENT_VOTE, (buffer, index) => USER_CANCELED_JUDGEMENT_VOTE.Build(buffer, index).Parse(player));
        public static void TellJudgementVotes(this MessageParser parser, Player player, JudgementVote vote) => parser.Parse((byte)ServerMessageType.TELL_JUDGEMENT_VOTES, (buffer, index) => TELL_JUDGEMENT_VOTES.Build(buffer, index).Parse(player).Parse(vote));
        public static void ExecutionerCompletedGoal(this MessageParser parser) => parser.Parse((byte)ServerMessageType.EXECUTIONER_COMPLETED_GOAL, EXECUTIONER_COMPLETED_GOAL.Build);
        public static void JesterCompletedGoal(this MessageParser parser) => parser.Parse((byte)ServerMessageType.JESTER_COMPLETED_GOAL, JESTER_COMPLETED_GOAL.Build);
        public static void MayorRevealed(this MessageParser parser, Player player) => parser.Parse((byte)ServerMessageType.MAYOR_REVEALED, (buffer, index) => MAYOR_REVEALED.Build(buffer, index).Parse(player));
        public static void MayorRevealedAndAlreadyVoted(this MessageParser parser, Player player) => parser.Parse((byte)ServerMessageType.MAYOR_REVEALED_AND_ALREADY_VOTED, (buffer, index) => MAYOR_REVEALED_AND_ALREADY_VOTED.Build(buffer, index).Parse(player));
        public static void DisguiserStoleYourIdentity(this MessageParser parser, Player player) => parser.Parse((byte)ServerMessageType.DISGUISER_STOLE_YOUR_IDENTITY, (buffer, index) => DISGUISER_STOLE_YOUR_IDENTITY.Build(buffer, index).Parse(player));
        public static void DisguiserChangedIdentity(this MessageParser parser, Player player) => parser.Parse((byte)ServerMessageType.DISGUISER_CHANGED_IDENTITY, (buffer, index) => DISGUISER_CHANGED_IDENTITY.Build(buffer, index).Parse(player));
        public static void DisguiserChangedUpdateMafia(this MessageParser parser, Player newPlayer, Player oldPlayer) => parser.Parse((byte)ServerMessageType.DISGUISER_CHANGED_UPDATE_MAFIA, (buffer, index) => DISGUISER_CHANGED_UPDATE_MAFIA.Build(buffer, index).Parse(newPlayer).Parse(oldPlayer));
        public static void MediumIsTalkingToUs(this MessageParser parser) => parser.Parse((byte)ServerMessageType.MEDIUM_IS_TALKING_TO_US, MEDIUM_IS_TALKING_TO_US.Build);
        public static void MediumCommunicating(this MessageParser parser) => parser.Parse((byte)ServerMessageType.MEDIUM_COMMUNICATING, MEDIUM_COMMUNICATING.Build);
        public static void TellLastWill(this MessageParser parser, Player player, string will) => parser.Parse((byte)ServerMessageType.TELL_LAST_WILL, (buffer, index) => TELL_LAST_WILL.Build(buffer, index).Parse(player).Parse(will != null).Parse(will != null, p => p.Parse(will), p => p));
        public static void HowManyAbilitiesLeft(this MessageParser parser, byte abilitiesLeft) => parser.Parse((byte)ServerMessageType.HOW_MANY_ABILITIES_LEFT, (buffer, index) => HOW_MANY_ABILITIES_LEFT.Build(buffer, index).Parse(abilitiesLeft));
        public static void MafiaTargeting(this MessageParser parser, Player player, Role role, Player target, byte mod1, byte? mod2 = null, byte? mod3 = null) => parser.Parse((byte)ServerMessageType.MAFIA_TARGETING, (buffer, index) => MAFIA_TARGETING.Build(buffer, index).Parse(player).Parse(role).Parse(target).Parse(mod1).Parse(mod2.ToOption()).Parse(mod3.ToOption()));
        public static void TellJanitorTargetsRole(this MessageParser parser, Role role) => parser.Parse((byte)ServerMessageType.TELL_JANITOR_TARGETS_ROLE, (buffer, index) => TELL_JANITOR_TARGETS_ROLE.Build(buffer, index).Parse(role));
        public static void TellJanitorTargetsWill(this MessageParser parser, Player player, string will) => parser.Parse((byte)ServerMessageType.TELL_JANITOR_TARGETS_WILL, (buffer, index) => TELL_JANITOR_TARGETS_WILL.Build(buffer, index).Parse(player).Parse(will));
        public static void SomeoneHasWon(this MessageParser parser, Faction faction, params Player[] winners) => parser.Parse((byte)ServerMessageType.SOMEONE_HAS_WON, (buffer, index) => SOMEONE_HAS_WON.Build(buffer, index).Parse(faction).Parse(winners, (player, p) => p.Parse(player)));
        public static void MafiosoPromotedToGodfather(this MessageParser parser) => parser.Parse((byte)ServerMessageType.MAFIOSO_PROMOTED_TO_GODFATHER, MAFIOSO_PROMOTED_TO_GODFATHER.Build);
        public static void MafiosoPromotedToGodfatherUpdateMafia(this MessageParser parser, Player promoted) => parser.Parse((byte)ServerMessageType.MAFIOSO_PROMOTED_TO_GODFATHER_UPDATE_MAFIA, (buffer, index) => MAFIOSO_PROMOTED_TO_GODFATHER_UPDATE_MAFIA.Build(buffer, index).Parse(promoted));
        public static void MafiaPromotedToMafioso(this MessageParser parser) => parser.Parse((byte)ServerMessageType.MAFIA_PROMOTED_TO_MAFIOSO, MAFIA_PROMOTED_TO_MAFIOSO.Build);
        public static void TellMafiaAboutMafiosoPromotion(this MessageParser parser, Player promoted) => parser.Parse((byte)ServerMessageType.TELL_MAFIA_ABOUT_MAFIOSO_PROMOTION, (buffer, index) => TELL_MAFIA_ABOUT_MAFIOSO_PROMOTION.Build(buffer, index).Parse(promoted));
        public static void ExecutionerConvertedToJester(this MessageParser parser) => parser.Parse((byte)ServerMessageType.EXECUTIONER_CONVERTED_TO_JESTER, EXECUTIONER_CONVERTED_TO_JESTER.Build);
        public static void AmnesiacBecameMafiaOrWitch(this MessageParser parser, Player player, Role role) => parser.Parse((byte)ServerMessageType.AMNESIAC_BECAME_MAFIA_OR_WITCH, (buffer, index) => AMNESIAC_BECAME_MAFIA_OR_WITCH.Build(buffer, index).Parse(player).Parse(role));
        public static void UserDisconnected(this MessageParser parser, Player player) => parser.Parse((byte)ServerMessageType.USER_DISCONNECTED, (buffer, index) => USER_DISCONNECTED.Build(buffer, index).Parse(player));
        public static void MafiaWasJailed(this MessageParser parser, Player jailed) => parser.Parse((byte)ServerMessageType.MAFIA_WAS_JAILED, (buffer, index) => MAFIA_WAS_JAILED.Build(buffer, index).Parse(jailed));
        public static void InvalidNameMessage(this MessageParser parser, InvalidNameStatus status) => parser.Parse((byte)ServerMessageType.INVALID_NAME_MESSAGE, (buffer, index) => INVALID_NAME_MESSAGE.Build(buffer, index).Parse(status));
        public static void StartNightTransition(this MessageParser parser) => parser.Parse((byte)ServerMessageType.START_NIGHT_TRANSITION, START_NIGHT_TRANSITION.Build);
        public static void StartDayTransition(this MessageParser parser, params Player[] deaths) => parser.Parse((byte)ServerMessageType.START_DAY_TRANSITION, (buffer, index) => START_DAY_TRANSITION.Build(buffer, index).Parse(deaths, (death, p) => p.Parse(death)));
        public static void LynchUser(this MessageParser parser) => parser.Parse((byte)ServerMessageType.LYNCH_USER, LYNCH_USER.Build);
        public static void DeathNote(this MessageParser parser, Player player, bool longTimer, string note) => parser.Parse((byte)ServerMessageType.DEATH_NOTE, (buffer, index) => DEATH_NOTE.Build(buffer, index).Parse(player).Parse(longTimer).Parse(note));
        public static void HousesChosen(this MessageParser parser, params (Player player, House house)[] choices) => parser.Parse((byte)ServerMessageType.HOUSES_CHOSEN, (buffer, index) => HOUSES_CHOSEN.Build(buffer, index).Parse(choices, (choice, p) => p.Parse(choice.player).Parse(choice.house)));
        public static void FirstDayTransition(this MessageParser parser) => parser.Parse((byte)ServerMessageType.FIRST_DAY_TRANSITION, FIRST_DAY_TRANSITION.Build);
        public static void CharactersChosen(this MessageParser parser, params (Player player, Character character)[] choices) => parser.Parse((byte)ServerMessageType.CHARACTERS_CHOSEN, (buffer, index) => CHARACTERS_CHOSEN.Build(buffer, index).Parse(choices, (choice, p) => p.Parse(choice.player).Parse(choice.character)));
        public static void ResurrectionSetAlive(this MessageParser parser, Player player) => parser.Parse((byte)ServerMessageType.RESURRECTION_SET_ALIVE, (buffer, index) => RESURRECTION_SET_ALIVE.Build(buffer, index).Parse(player));
        public static void StartDefense(this MessageParser parser) => parser.Parse((byte)ServerMessageType.START_DEFENSE, START_DEFENSE.Build);
        public static void UserLeftDuringSelection(this MessageParser parser, Player player) => parser.Parse((byte)ServerMessageType.USER_LEFT_DURING_SELECTION, (buffer, index) => USER_LEFT_DURING_SELECTION.Build(buffer, index).Parse(player));
        public static void VigilanteKilledTown(this MessageParser parser) => parser.Parse((byte)ServerMessageType.VIGILANTE_KILLED_TOWN, VIGILANTE_KILLED_TOWN.Build);
        public static void NotifyUsersOfPrivateMessage(this MessageParser parser, Player src, Player dst) => parser.Parse((byte)ServerMessageType.NOTIFY_USERS_OF_PRIVATE_MESSAGE, (buffer, index) => NOTIFY_USERS_OF_PRIVATE_MESSAGE.Build(buffer, index).Parse(src).Parse(dst));
        public static void PrivateMessage(this MessageParser parser, PrivateMessageType type, Player with, string message, Player? dst = null) => parser.Parse((byte)ServerMessageType.PRIVATE_MESSAGE, (buffer, index) => PRIVATE_MESSAGE.Build(buffer, index).Parse(type).Parse(with).Parse(dst == null, p => p.Parse(message), p => p.Parse(dst ?? default(Player)).Parse(message)));
        public static void EarnedAchievements161(this MessageParser parser, params Achievement[] achievements) => parser.Parse((byte)ServerMessageType.EARNED_ACHIEVEMENTS_161, (buffer, index) => EARNED_ACHIEVEMENTS_161.Build(buffer, index).Parse(achievements, (achievement, p) => p.Parse(achievement)));
        public static void AuthenticationFailed(this MessageParser parser, AuthenticationResult result, uint? timer = null) => parser.Parse((byte)ServerMessageType.AUTHENTICATION_FAILED, (buffer, index) => AUTHENTICATION_FAILED.Build(buffer, index).Parse(result).Parse(timer != null, p => p.Parse(timer ?? 0), p => p));
        public static void SpyNightAbilityMessage(this MessageParser parser, bool isCoven, Player visited) => parser.Parse((byte)ServerMessageType.SPY_NIGHT_ABILITY_MESSAGE, (buffer, index) => SPY_NIGHT_ABILITY_MESSAGE.Build(buffer, index).Parse(isCoven).Parse(visited));
        public static void OneDayBeforeStalemate(this MessageParser parser) => parser.Parse((byte)ServerMessageType.ONE_DAY_BEFORE_STALEMATE, ONE_DAY_BEFORE_STALEMATE.Build);
        public static void PetsChosen(this MessageParser parser, params (Player player, Pet pet)[] pets) => parser.Parse((byte)ServerMessageType.PETS_CHOSEN, (buffer, index) => PETS_CHOSEN.Build(buffer, index).Parse(pets, (pet, p) => p.Parse(pet.player).Parse(pet.pet)));
        public static void FacebookShareAchievement(this MessageParser parser, Achievement achievement) => parser.Parse((byte)ServerMessageType.FACEBOOK_SHARE_ACHIEVEMENT, (buffer, index) => FACEBOOK_SHARE_ACHIEVEMENT.Build(buffer, index).Parse(achievement));
        public static void FacebookShareWin(this MessageParser parser, Faction faction) => parser.Parse((byte)ServerMessageType.FACEBOOK_SHARE_WIN, (buffer, index) => FACEBOOK_SHARE_WIN.Build(buffer, index).Parse(faction));
        public static void DeathAnimationsChosen(this MessageParser parser, params (Player player, DeathAnimation animation)[] animations) => parser.Parse((byte)ServerMessageType.DEATH_ANIMATIONS_CHOSEN, (buffer, index) => DEATH_ANIMATIONS_CHOSEN.Build(buffer, index).Parse(animations, (animation, p) => p.Parse(animation.player).Parse(animation.animation)));
        public static void FullMoonNight(this MessageParser parser) => parser.Parse((byte)ServerMessageType.FULL_MOON_NIGHT, FULL_MOON_NIGHT.Build);
        public static void Identify(this MessageParser parser, string message) => parser.Parse((byte)ServerMessageType.IDENTIFY, (buffer, index) => IDENTIFY.Build(buffer, index).Parse(message));
        public static void EndGameInfo(this MessageParser parser, uint timeout, GameMode mode, Faction winningFaction, bool won, byte eloChange, byte mpGain, params (string name, string username, Player id, Role[] roles)[] players) => parser.Parse((byte)ServerMessageType.END_GAME_INFO, (buffer, index) => END_GAME_INFO.Build(buffer, index).Parse(timeout).Parse(mode).Parse(winningFaction).Parse(won).Parse(eloChange).Parse(mpGain).Parse(players, (player, p) => p.Parse(player.name).Parse(player.username).Parse(player.id).Parse(player.roles, (role, p2) => p2.Parse(role)).Parse(null)));
        public static void EndGameChatMessage(this MessageParser parser, Player player, string message) => parser.Parse((byte)ServerMessageType.END_GAME_CHAT_MESSAGE, (buffer, index) => END_GAME_CHAT_MESSAGE.Build(buffer, index).Parse(player).Parse(message));
        public static void EndGameUserUpdate(this MessageParser parser, params (Player player, bool left)[] updates) => parser.Parse((byte)ServerMessageType.END_GAME_USER_UPDATE, (buffer, index) => END_GAME_USER_UPDATE.Build(buffer, index).Parse(updates, (update, p) => p.Parse(update.player).Parse(update.left)));
        public static void RoleLotsInfoMessage(this MessageParser parser, params (Role role, uint totalSlots, uint yourSlots)[] lots) => parser.Parse((byte)ServerMessageType.ROLE_LOTS_INFO_MESSAGE, (buffer, index) => ROLE_LOTS_INFO_MESSAGE.Build(buffer, index).Parse(lots, (lot, p) => p.Parse(lot.role).Parse(lot.totalSlots).Parse(lot.yourSlots)));
        public static void ExternalPurchase(this MessageParser parser, Uri uri) => parser.Parse((byte)ServerMessageType.EXTERNAL_PURCHASE, (buffer, index) => EXTERNAL_PURCHASE.Build(buffer, index).Parse(uri));
        public static void VampirePromotion(this MessageParser parser) => parser.Parse((byte)ServerMessageType.VAMPIRE_PROMOTION, VAMPIRE_PROMOTION.Build);
        public static void OtherVampires(this MessageParser parser, params (Player player, bool youngest)[] vampires) => parser.Parse((byte)ServerMessageType.OTHER_VAMPIRES, (buffer, index) => OTHER_VAMPIRES.Build(buffer, index).Parse(vampires, (vampire, p) => p.Parse(vampire.player).Parse(vampire.youngest)));
        public static void AddVampire(this MessageParser parser, Player player, bool youngest) => parser.Parse((byte)ServerMessageType.ADD_VAMPIRE, (buffer, index) => ADD_VAMPIRE.Build(buffer, index).Parse(player).Parse(youngest));
        public static void CanVampiresConvert(this MessageParser parser, bool canConvert) => parser.Parse((byte)ServerMessageType.CAN_VAMPIRES_CONVERT, (buffer, index) => CAN_VAMPIRES_CONVERT.Build(buffer, index).Parse(canConvert));
        public static void VampireDied(this MessageParser parser, Player player, Player? newYoungest = null) => parser.Parse((byte)ServerMessageType.VAMPIRE_DIED, (buffer, index) => VAMPIRE_DIED.Build(buffer, index).Parse(player).Parse(newYoungest.ToOption()));
        public static void VampireHunterPromoted(this MessageParser parser) => parser.Parse((byte)ServerMessageType.VAMPIRE_HUNTER_PROMOTED, VAMPIRE_HUNTER_PROMOTED.Build);
        public static void VampireVisitedMessage(this MessageParser parser, Player player) => parser.Parse((byte)ServerMessageType.VAMPIRE_VISITED_MESSAGE, (buffer, index) => VAMPIRE_VISITED_MESSAGE.Build(buffer, index).Parse(player));
        public static void CheckUsernameResult(this MessageParser parser, bool available) => parser.Parse((byte)ServerMessageType.CHECK_USERNAME_RESULT, (buffer, index) => CHECK_USERNAME_RESULT.Build(buffer, index).Parse(available));
        public static void NameChangeResult(this MessageParser parser, NameChangeResult result) => parser.Parse((byte)ServerMessageType.NAME_CHANGE_RESULT, (buffer, index) => NAME_CHANGE_RESULT.Build(buffer, index).Parse(result));
        public static void AccountState(this MessageParser parser, AccountState state) => parser.Parse((byte)ServerMessageType.ACCOUNT_STATE, (buffer, index) => ACCOUNT_STATE.Build(buffer, index).Parse(state));
        public static void PurchasedAccountItems(this MessageParser parser, params AccountItem[] items) => parser.Parse((byte)ServerMessageType.PURCHASED_ACCOUNT_ITEMS, (buffer, index) => PURCHASED_ACCOUNT_ITEMS.Build(buffer, index).Parse(items, (item, p) => p.Parse(item)));
        public static void AccountItemConsumed(this MessageParser parser, AccountItem item, uint consumed, uint remaining) => parser.Parse((byte)ServerMessageType.ACCOUNT_ITEM_CONSUMED, (buffer, index) => ACCOUNT_ITEM_CONSUMED.Build(buffer, index).Parse(item).Parse(consumed).Parse(remaining));
        public static void TransporterNotification(this MessageParser parser, Player player1, Player player2) => parser.Parse((byte)ServerMessageType.TRANSPORTER_NOTIFICATION, (buffer, index) => TRANSPORTER_NOTIFICATION.Build(buffer, index).Parse(player1).Parse(player2));
        public static void ProductPurchaseResult(this MessageParser parser, ShopItem purchasedItem, uint quantity, PurchaseSource source, uint sourceData, PurchaseResult result, ItemType itemType, params (ItemType type, uint id)[] items) => parser.Parse((byte)ServerMessageType.PRODUCT_PURCHASE_RESULT, (buffer, index) => PRODUCT_PURCHASE_RESULT.Build(buffer, index).Parse(purchasedItem).Parse(quantity).Parse(source).Parse(sourceData).Parse(result).Parse(itemType).Parse(items, (item, p2) => p2.Parse(item.type).Parse(item.id)));
        public static void UpdateFreeCurrency(this MessageParser parser, uint amount) => parser.Parse((byte)ServerMessageType.UPDATE_FREE_CURRENCY, (buffer, index) => UPDATE_FREE_CURRENCY.Build(buffer, index).Parse(amount));
        public static void ActiveEvents(this MessageParser parser, params (uint type, string uiFilter, uint startingSeconds, uint endingSeconds)[] events) => parser.Parse((byte)ServerMessageType.ACTIVE_EVENTS, (buffer, index) => ACTIVE_EVENTS.Build(buffer, index).Parse(events, (evt, p) => p.Parse(evt.type).Parse(evt.uiFilter).Parse(evt.startingSeconds).Parse(evt.endingSeconds)));
        public static void CauldronStatus(this MessageParser parser, CauldronRewardType rewardType, uint progress, uint progressTarget, bool complete, uint freePotionCooldown, IEnumerable<CauldronPotion> purchasablePotions, params (ItemType type, uint id, uint quantity)[] rewards) => parser.Parse((byte)ServerMessageType.CAULDRON_STATUS, (buffer, index) => CAULDRON_STATUS.Build(buffer, index).Parse(rewardType).Parse(progress).Parse(progressTarget).Parse(complete).Parse(freePotionCooldown).Parse(purchasablePotions, (potion, p) => p.Parse(potion)).Parse(rewards, (reward, p) => p.Parse(reward.type).Parse(reward.id).Parse(reward.quantity)));
        public static void TauntResult(this MessageParser parser, Player player, TauntTargetType type, Taunt taunt, bool success) => parser.Parse((byte)ServerMessageType.TAUNT_RESULT, (buffer, index) => TAUNT_RESULT.Build(buffer, index).Parse(player).Parse(type).Parse(taunt).Parse(success));
        public static void TauntActivated(this MessageParser parser, Player player, TauntTargetType type, Taunt taunt) => parser.Parse((byte)ServerMessageType.TAUNT_ACTIVATED, (buffer, index) => TAUNT_ACTIVATED.Build(buffer, index).Parse(player).Parse(type).Parse(taunt));
        public static void TauntConsumed(this MessageParser parser, Taunt taunt) => parser.Parse((byte)ServerMessageType.TAUNT_CONSUMED, (buffer, index) => TAUNT_CONSUMED.Build(buffer, index).Parse(taunt));
        public static void TrackerNightAbility(this MessageParser parser, Player visited) => parser.Parse((byte)ServerMessageType.TRACKER_NIGHT_ABILITY, (buffer, index) => TRACKER_NIGHT_ABILITY.Build(buffer, index).Parse(visited));
        public static void AmbusherNightAbility(this MessageParser parser, Player ambusher) => parser.Parse((byte)ServerMessageType.AMBUSHER_NIGHT_ABILITY, (buffer, index) => AMBUSHER_NIGHT_ABILITY.Build(buffer, index).Parse(ambusher));
        public static void GuardianAngelProtection(this MessageParser parser, Player target) => parser.Parse((byte)ServerMessageType.GUARDIAN_ANGEL_PROTECTION, (buffer, index) => GUARDIAN_ANGEL_PROTECTION.Build(buffer, index).Parse(target));
        public static void PirateDuel(this MessageParser parser) => parser.Parse((byte)ServerMessageType.PIRATE_DUEL, PIRATE_DUEL.Build);
        public static void DuelTarget(this MessageParser parser, Player target) => parser.Parse((byte)ServerMessageType.DUEL_TARGET, (buffer, index) => DUEL_TARGET.Build(buffer, index).Parse(target));
        public static void PotionMasterPotions(this MessageParser parser, byte healCooldown, byte attackCooldown, byte investigateCooldown) => parser.Parse((byte)ServerMessageType.POTION_MASTER_POTIONS, (buffer, index) => POTION_MASTER_POTIONS.Build(buffer, index).Parse(healCooldown).Parse(attackCooldown).Parse(investigateCooldown));
        public static void HasNecronomicon(this MessageParser parser, byte? nightsUntil = null) => parser.Parse((byte)ServerMessageType.HAS_NECRONOMICON, (buffer, index) => HAS_NECRONOMICON.Build(buffer, index).Parse(nightsUntil != null).Parse(nightsUntil == null, p => p, p => p.Parse(nightsUntil ?? 0)));
        public static void OtherWitches(this MessageParser parser, params (Player id, Role role)[] witches) => parser.Parse((byte)ServerMessageType.OTHER_WITCHES, (buffer, index) => OTHER_WITCHES.Build(buffer, index).Parse(witches, (witch, p) => p.Parse(witch.id).Parse(witch.role)));
        public static void PsychicNightAbility(this MessageParser parser, Player player1, Player player2, Player? player3 = null) => parser.Parse((byte)ServerMessageType.PSYCHIC_NIGHT_ABILITY, (buffer, index) => PSYCHIC_NIGHT_ABILITY.Build(buffer, index).Parse(player3 != null).Parse(player1).Parse(player2).Parse(player3 == null, p => p, p => p.Parse(player3 ?? default(Player))));
        public static void TrapperNightAbility(this MessageParser parser, Role caughtRole) => parser.Parse((byte)ServerMessageType.TRAPPER_NIGHT_ABILITY, (buffer, index) => TRAPPER_NIGHT_ABILITY.Build(buffer, index).Parse(caughtRole));
        public static void TrapperTrapStatus(this MessageParser parser, TrapStatus status) => parser.Parse((byte)ServerMessageType.TRAPPER_TRAP_STATUS, (buffer, index) => TRAPPER_TRAP_STATUS.Build(buffer, index).Parse(status));
        public static void PestilenceConversion(this MessageParser parser) => parser.Parse((byte)ServerMessageType.PESTILENCE_CONVERSION, PESTILENCE_CONVERSION.Build);
        public static void JuggernautKillCount(this MessageParser parser, byte killCount) => parser.Parse((byte)ServerMessageType.JUGGERNAUT_KILL_COUNT, (buffer, index) => JUGGERNAUT_KILL_COUNT.Build(buffer, index).Parse(killCount));
        public static void CovenGotNecronomicon(this MessageParser parser, Player owner, Player? newOwner = null) => parser.Parse((byte)ServerMessageType.COVEN_GOT_NECRONOMICON, (buffer, index) => COVEN_GOT_NECRONOMICON.Build(buffer, index).Parse(newOwner != null).Parse(owner).Parse(newOwner == null, p => p, p => p.Parse(newOwner ?? default(Player))));
        public static void GuardianAngelPromoted(this MessageParser parser) => parser.Parse((byte)ServerMessageType.GUARDIAN_ANGEL_PROMOTED, GUARDIAN_ANGEL_PROMOTED.Build);
        public static void VIPTarget(this MessageParser parser, Player vip) => parser.Parse((byte)ServerMessageType.VIP_TARGET, (buffer, index) => VIP_TARGET.Build(buffer, index).Parse(vip));
        public static void PirateDuelOutcome(this MessageParser parser, DuelAttack attack, DuelDefense defense) => parser.Parse((byte)ServerMessageType.PIRATE_DUEL_OUTCOME, (buffer, index) => PIRATE_DUEL_OUTCOME.Build(buffer, index).Parse(attack).Parse(defense));
        public static void HostSetPartyConfigResult(this MessageParser parser, Brand brand, GameMode mode, SetConfigResult result) => parser.Parse((byte)ServerMessageType.HOST_SET_PARTY_CONFIG_RESULT, (buffer, index) => HOST_SET_PARTY_CONFIG_RESULT.Build(buffer, index).Parse(brand).Parse(mode).Parse(result));
        public static void ActiveGameModes(this MessageParser parser, params GameMode[] modes) => parser.Parse((byte)ServerMessageType.ACTIVE_GAME_MODES, (buffer, index) => ACTIVE_GAME_MODES.Build(buffer, index).Parse(modes, (mode, p) => p.Parse(mode)));
        public static void AccountFlags(this MessageParser parser, AccountFlags flags) => parser.Parse((byte)ServerMessageType.ACCOUNT_FLAGS, (buffer, index) => ACCOUNT_FLAGS.Build(buffer, index).Parse(flags));
        public static void ZombieRotted(this MessageParser parser, Player player) => parser.Parse((byte)ServerMessageType.ZOMBIE_ROTTED, (buffer, index) => ZOMBIE_ROTTED.Build(buffer, index).Parse(player));
        public static void LoverTarget(this MessageParser parser, Player player) => parser.Parse((byte)ServerMessageType.LOVER_TARGET, (buffer, index) => LOVER_TARGET.Build(buffer, index).Parse(player));
        public static void PlagueSpread(this MessageParser parser, Player player) => parser.Parse((byte)ServerMessageType.PLAGUE_SPREAD, (buffer, index) => PLAGUE_SPREAD.Build(buffer, index).Parse(player));
        public static void RivalTarget(this MessageParser parser, Player player) => parser.Parse((byte)ServerMessageType.RIVAL_TARGET, (buffer, index) => RIVAL_TARGET.Build(buffer, index).Parse(player));
        public static void RankedInfo(this MessageParser parser, GameMode mode, uint practiceGamesPlayed, uint careerWins, uint careerLosses, uint careerDraws, uint careerLeaves, uint careerHighRating, uint seasonNumber, bool offseason, uint placementGamesNeeded, uint seasonWins, uint seasonLosses, uint seasonDraws, uint seasonLeaves, uint seasonHighRating, uint seasonRating) => parser.Parse((byte)ServerMessageType.RANKED_INFO, (buffer, index) => RANKED_INFO.Build(buffer, index).Parse(mode).Parse(practiceGamesPlayed).Parse(careerWins).Parse(careerLosses).Parse(careerDraws).Parse(careerLeaves).Parse(careerHighRating).Parse(seasonNumber).Parse(offseason).Parse(placementGamesNeeded).Parse(seasonWins).Parse(seasonLosses).Parse(seasonDraws).Parse(seasonLeaves).Parse(seasonHighRating).Parse(seasonRating));
        public static void JailorDeathNote(this MessageParser parser, Player player, bool longTimer, ExecuteReason note) => parser.Parse((byte)ServerMessageType.JAILOR_DEATH_NOTE, (buffer, index) => JAILOR_DEATH_NOTE.Build(buffer, index).Parse(player).Parse(longTimer).Parse(note));
        public static void Disconnected(this MessageParser parser, DisconnectReason reason) => parser.Parse((byte)ServerMessageType.DISCONNECTED, (buffer, index) => DISCONNECTED.Build(buffer, index).Parse(reason));
        public static void SpyNightInfo(this MessageParser parser, params LocalizationTable[] messages) => parser.Parse((byte)ServerMessageType.SPY_NIGHT_INFO, (buffer, index) => SPY_NIGHT_INFO.Build(buffer, index).Parse(messages, (message, p) => p.Parse(message)));
        public static void ServerFlags(this MessageParser parser, params bool[] flags) => parser.Parse((byte)ServerMessageType.SERVER_FLAGS, (buffer, index) => SERVER_FLAGS.Build(buffer, index).Parse(flags, (flag, p) => p.Parse(flag)));
    }

    public class ServerMessageParser
    {
        public event Action<bool> Authenticated;
        public event Action<bool, GameMode> CreateLobby;
        public event Action SetHost;
        public event Action<bool, bool, string, Player, LobbyIcon> UserJoinedGame;
        public event Action<bool, bool, Player> UserLeftGame;
        public event Action<bool, Player, string> ChatBoxMessage;
        public event Action<Catalog> HostClickedOnCatalog;
        public event Action<byte, byte> HostClickedOnPossibleRoles;
        public event Action<Role> HostClickedOnAddButton;
        public event Action<byte> HostClickedOnRemoveButton;
        public event Action HostClickedOnStartButton;
        public event Action CancelStartCooldown;
        public event Action<Player> AssignNewHost;
        public event Action<byte> VotedToRepickHost;
        public event Action NoLongerHost;
        public event Action DoNotSpam;
        public event Action<uint, uint> HowManyPlayersAndGames;
        public event Action<string> SystemMessage;
        public event Action<LocalizationTable> StringTableMessage;
        public event Action<IEnumerable<(string username, uint userID, OnlineStatus status, bool ownsCoven)>> FriendList;
        public event Action<IEnumerable<(string username, uint userID)>> FriendRequestNotifications;
        public event Action<bool> AddFriendRequestResponse;
        public event Action<uint, OnlineStatus, bool> ConfirmFriendRequest;
        public event Action<uint> SuccessfullyRemovedFriend;
        public event Action SuccessfullyDeclinedFriendRequest;
        public event Action<uint, OnlineStatus, bool> FriendUpdate;
        public event Action<uint, bool, string> FriendMessage;
        public event Action<string, uint, uint> UserInformation;
        public event Action<Brand> CreatePartyLobby;
        public event Action<string, FailedInvitationStatus> PartyInviteFailed;
        public event Action<uint, string> PartyInviteNotification;
        public event Action<AcceptInvitationResult> AcceptedPartyInvite;
        public event Action<string, PendingInvitationStatus> PendingPartyInviteStatus;
        public event Action SuccessfullyLeftParty;
        public event Action<string, string> PartyChat;
        public event Action<string> PartyMemberLeft;
        public event Action<bool, bool, bool, bool, bool, bool, byte, byte, Language, byte, TipBehaviour> SettingsInformation;
        public event Action<string, uint, OnlineStatus, bool> AddFriend;
        public event Action ForcedLogout;
        public event Action ReturnToHomePage;
        public event Action ShopPurchaseSuccess;
        public event Action<IEnumerable<Character>> PurchasedCharacters;
        public event Action<IEnumerable<House>> PurchasedHouses;
        public event Action<IEnumerable<Background>> PurchasedBackgrounds;
        public event Action<Character, House, Background, Pet?, LobbyIcon, DeathAnimation, Scroll?, Scroll?, Scroll?, string> SelectionSettings;
        public event Action<RedeemCodeResult, RedeemCodeReward?, string> RedeemCodeMessage;
        public event Action<uint> UpdatePaidCurrency;
        public event Action<IEnumerable<Pack>> PurchasedPacks;
        public event Action<IEnumerable<Pet>> PurchasedPets;
        public event Action<uint> SetLastBonusWinTime;
        public event Action<IEnumerable<Achievement>> EarnedAchievements52;
        public event Action<IEnumerable<LobbyIcon>> PurchasedLobbyIcons;
        public event Action<IEnumerable<DeathAnimation>> PurchasedDeathAnimations;
        public event Action FacebookInviteFriends;
        public event Action<IEnumerable<(Scroll scroll, uint amount)>> PurchasedScrolls;
        public event Action<string> HostGivenToPlayer;
        public event Action HostGivenToMe;
        public event Action<string> KickedPlayer;
        public event Action KickedMe;
        public event Action<string> InvitePowersGivenToPlayer;
        public event Action InvitePowersGivenToMe;
        public event Action SteamFirstLogin;
        public event Action<string, string> UpdateFriendUsername;
        public event Action EnableShopButtons;
        public event Action SteamPopup;
        public event Action Register;
        public event Action<string> AuthenticateWithSteamCloud;
        public event Action<bool, uint> StartRankedQueue;
        public event Action LeaveRankedQueue;
        public event Action AcceptRankedPopup;
        public event Action<uint, uint, uint, uint, uint> UserStatistics;
        public event Action<uint> RankedTimeoutDuration;
        public event Action<string> AuthenticateWithSteam;
        public event Action<ModeratorMessage, string> ModeratorMessage;
        public event Action<ReferralReward, uint?> ReferAFriendUpdate;
        public event Action<IEnumerable<uint>> PlayerStatistics;
        public event Action<Scroll> ScrollConsumed;
        public event Action<AdViewResult, uint> AdViewResponse;
        public event Action UserJoiningLobbyTooQuickly;
        public event Action<Promotion, uint, double, uint> PromotionPopup;
        public event Action KickstarterShare;
        public event Action<IEnumerable<TutorialTip>> TutorialProgress;
        public event Action<IEnumerable<(Taunt taunt, uint amount)>> PurchasedTaunts;
        public event Action<IEnumerable<(Currency currency, uint multiplier)>> CurrencyMultiplier;
        public event Action<byte, GameMode> PickNames;
        public event Action<Player, string> NamesAndPositionsOfUsers;
        public event Action<Role, Player, Option<Player>> RoleAndPosition;
        public event Action StartNight;
        public event Action StartDay;
        public event Action<Player, Role, bool, IEnumerable<DeathCause>> WhoDiedAndHow;
        public event Action StartDiscussion;
        public event Action<byte> StartVoting;
        public event Action<Player> StartDefenseTransition;
        public event Action StartJudgement;
        public event Action<byte, byte> TrialFoundGuilty;
        public event Action<byte, byte> TrialFoundNotGuilty;
        public event Action<Player> LookoutNightAbilityMessage;
        public event Action<Player, Player, byte> UserVoted;
        public event Action<Player, Player, byte> UserCanceledVote;
        public event Action<Player, Player, Player, byte> UserChangedVote;
        public event Action<bool> UserDied;
        public event Action<Player, Role> Resurrection;
        public event Action<IEnumerable<Role>> TellRoleList;
        public event Action<LocalizationTable, Player, string> UserChosenName;
        public event Action<IEnumerable<(Player player, Role role)>> OtherMafia;
        public event Action<Role> TellTownAmnesiacChangedRole;
        public event Action<Role, Option<Player>> AmnesiacChangedRole;
        public event Action BroughtBackToLife;
        public event Action StartFirstDay;
        public event Action BeingJailed;
        public event Action<Player, bool, bool> JailedTarget;
        public event Action<Player> UserJudgementVoted;
        public event Action<Player> UserChangedJudgementVote;
        public event Action<Player> UserCanceledJudgementVote;
        public event Action<Player, JudgementVote> TellJudgementVotes;
        public event Action ExecutionerCompletedGoal;
        public event Action JesterCompletedGoal;
        public event Action<Player> MayorRevealed;
        public event Action<Player> MayorRevealedAndAlreadyVoted;
        public event Action<Player> DisguiserStoleYourIdentity;
        public event Action<Player> DisguiserChangedIdentity;
        public event Action<Player, Player> DisguiserChangedUpdateMafia;
        public event Action MediumIsTalkingToUs;
        public event Action MediumCommunicating;
        public event Action<Player, string> TellLastWill;
        public event Action<byte> HowManyAbilitiesLeft;
        public event Action<Player, Role, Player, byte, byte?, byte?> MafiaTargeting;
        public event Action<Role> TellJanitorTargetsRole;
        public event Action<Player, string> TellJanitorTargetsWill;
        public event Action<Faction, IEnumerable<Player>> SomeoneHasWon;
        public event Action MafiosoPromotedToGodfather;
        public event Action<Player> MafiosoPromotedToGodfatherUpdateMafia;
        public event Action MafiaPromotedToMafioso;
        public event Action<Player> TellMafiaAboutMafiosoPromotion;
        public event Action ExecutionerConvertedToJester;
        public event Action<Player, Role> AmnesiacBecameMafiaOrWitch;
        public event Action<Player> UserDisconnected;
        public event Action<Player> MafiaWasJailed;
        public event Action<InvalidNameStatus> InvalidNameMessage;
        public event Action StartNightTransition;
        public event Action<IEnumerable<Player>> StartDayTransition;
        public event Action LynchUser;
        public event Action<Player, bool, string> DeathNote;
        public event Action<IEnumerable<(Player player, House house)>> HousesChosen;
        public event Action FirstDayTransition;
        public event Action<IEnumerable<(Player player, Character character)>> CharactersChosen;
        public event Action<Player> ResurrectionSetAlive;
        public event Action StartDefense;
        public event Action<Player> UserLeftDuringSelection;
        public event Action VigilanteKilledTown;
        public event Action<Player, Player> NotifyUsersOfPrivateMessage;
        public event Action<PrivateMessageType, Player, string, Player?> PrivateMessage;
        public event Action<IEnumerable<Achievement>> EarnedAchievements161;
        public event Action<AuthenticationResult, uint?> AuthenticationFailed;
        public event Action<bool, Player> SpyNightAbilityMessage;
        public event Action OneDayBeforeStalemate;
        public event Action<IEnumerable<(Player player, Pet pet)>> PetsChosen;
        public event Action<Achievement> FacebookShareAchievement;
        public event Action<Faction> FacebookShareWin;
        public event Action<IEnumerable<(Player player, DeathAnimation deathAnimation)>> DeathAnimationsChosen;
        public event Action FullMoonNight;
        public event Action<string> Identify;
        public event Action<uint, GameMode, Faction, bool, byte, byte, IEnumerable<(string name, string username, Player player, IEnumerable<Role> roles)>> EndGameInfo;
        public event Action<Player, string> EndGameChatMessage;
        public event Action<IEnumerable<(Player, bool)>> EndGameUserUpdate;
        public event Action<IEnumerable<(Role role, uint totalSlots, uint yourSlots)>> RoleLotsInfoMessage;
        public event Action<Uri> ExternalPurchase;
        public event Action VampirePromotion;
        public event Action<IEnumerable<(Player player, bool youngest)>> OtherVampires;
        public event Action<Player, bool> AddVampire;
        public event Action<bool> CanVampiresConvert;
        public event Action<Player, Option<Player>> VampireDied;
        public event Action VampireHunterPromoted;
        public event Action<Player> VampireVisitedMessage;
        public event Action<bool> CheckUsernameResult;
        public event Action<NameChangeResult> NameChangeResult;
        public event Action<AccountState> AccountState;
        public event Action<IEnumerable<AccountItem>> PurchasedAccountItems;
        public event Action<AccountItem, uint, uint> AccountItemConsumed;
        public event Action<Player, Player> TransporterNotification;
        public event Action<ShopItem, uint, PurchaseSource, uint, PurchaseResult, ItemType, IEnumerable<(ItemType type, uint id)>> ProductPurchaseResult;
        public event Action<uint> UpdateFreeCurrency;
        public event Action<IEnumerable<(uint type, string uiFilter, uint startingSeconds, uint endingSeconds)>> ActiveEvents;
        public event Action<CauldronRewardType, uint, uint, bool, uint, IEnumerable<CauldronPotion>, IEnumerable<(ItemType type, uint id, uint amount)>> CauldronStatus;
        public event Action<Player, TauntTargetType, Taunt, bool> TauntResult;
        public event Action<Player, TauntTargetType, Taunt> TauntActivated;
        public event Action<Taunt> TauntConsumed;
        public event Action<Player> TrackerNightAbility;
        public event Action<Player> AmbusherNightAbility;
        public event Action<Player> GuardianAngelProtection;
        public event Action PirateDuel;
        public event Action<Player> DuelTarget;
        public event Action<byte, byte, byte> PotionMasterPotions;
        public event Action<byte?> HasNecronomicon;
        public event Action<IEnumerable<(Player player, Role role)>> OtherWitches;
        public event Action<Player, Player, Player?> PsychicNightAbility;
        public event Action<Role> TrapperNightAbility;
        public event Action<TrapStatus> TrapperTrapStatus;
        public event Action PestilenceConversion;
        public event Action<byte> JuggernautKillCount;
        public event Action<Player, Player?> CovenGotNecronomicon;
        public event Action GuardianAngelPromoted;
        public event Action<Player> VIPTarget;
        public event Action<DuelAttack, DuelDefense> PirateDuelOutcome;
        public event Action<Brand, GameMode, SetConfigResult> HostSetPartyConfigResult;
        public event Action<IEnumerable<GameMode>> ActiveGameModes;
        public event Action<AccountFlags> AccountFlags;
        public event Action<Player> ZombieRotted;
        public event Action<Player> LoverTarget;
        public event Action<Player> PlagueSpread;
        public event Action<Player> RivalTarget;
        public event Action<GameMode, uint, uint, uint, uint, uint, uint, uint, bool, uint, uint, uint, uint, uint, uint, uint> RankedInfo;
        public event Action<Player, bool, ExecuteReason> JailorDeathNote;
        public event Action<DisconnectReason> Disconnected;
        public event Action<IEnumerable<LocalizationTable>> SpyNightInfo;
        public event Action<IEnumerable<bool>> ServerFlags;

        public ServerMessageParser(MessageParser parser) => parser.MessageRead += Parse;

        protected void Parse(byte[] buffer, int index, int length)
        {
            switch ((ServerMessageType)buffer[index++])
            {
                case ServerMessageType.AUTHENTICATED:
                    if (Authenticated == null) break;
                    ServerMessageParsers.AUTHENTICATED.Build(buffer, index, length).Parse(out bool registered).CheckPadding();
                    Authenticated(registered);
                    break;
                case ServerMessageType.CREATE_LOBBY:
                    if (CreateLobby == null) break;
                    ServerMessageParsers.CREATE_LOBBY.Build(buffer, index, length).Parse(out bool host).Parse(out GameMode gameMode).CheckPadding();
                    CreateLobby(host, gameMode);
                    break;
                case ServerMessageType.SET_HOST:
                    if (SetHost == null) break;
                    ServerMessageParsers.SET_HOST.Build(buffer, index, length).CheckPadding();
                    SetHost();
                    break;
                case ServerMessageType.USER_JOINED_GAME:
                    if (UserJoinedGame == null) break;
                    ServerMessageParsers.USER_JOINED_GAME.Build(buffer, index, length).Parse(out host).Parse(out bool display).Parse(out string username).Parse(out Player player).Parse(out LobbyIcon lobbyIcon).CheckPadding();
                    UserJoinedGame(host, display, username, player, lobbyIcon);
                    break;
                case ServerMessageType.USER_LEFT_GAME:
                    if (UserLeftGame == null) break;
                    ServerMessageParsers.USER_LEFT_GAME.Build(buffer, index, length).Parse(out bool update).Parse(out display).Parse(out player).CheckPadding();
                    UserLeftGame(update, display, player);
                    break;
                case ServerMessageType.CHAT_BOX_MESSAGE:
                    if (ChatBoxMessage == null) break;
                    ServerMessageParsers.CHAT_BOX_MESSAGE.Build(buffer, index, length).Parse(out bool inGame).Parse(out player).Parse(out string message).CheckPadding();
                    ChatBoxMessage(inGame, player, message);
                    break;
                case ServerMessageType.HOST_CLICKED_ON_CATALOG:
                    if (HostClickedOnCatalog == null) break;
                    ServerMessageParsers.HOST_CLICKED_ON_CATALOG.Build(buffer, index, length).Parse(out Catalog catalog).CheckPadding();
                    HostClickedOnCatalog(catalog);
                    break;
                case ServerMessageType.HOST_CLICKED_ON_POSSIBLE_ROLES:
                    if (HostClickedOnPossibleRoles == null) break;
                    ServerMessageParsers.HOST_CLICKED_ON_POSSIBLE_ROLES.Build(buffer, index, length).Parse(out byte selectedIndex).Parse(out byte scrollPosition).CheckPadding();
                    HostClickedOnPossibleRoles(selectedIndex, scrollPosition);
                    break;
                case ServerMessageType.HOST_CLICKED_ON_ADD_BUTTON:
                    if (HostClickedOnAddButton == null) break;
                    ServerMessageParsers.HOST_CLICKED_ON_ADD_BUTTON.Build(buffer, index, length).Parse(out Role role).CheckPadding();
                    HostClickedOnAddButton(role);
                    break;
                case ServerMessageType.HOST_CLICKED_ON_REMOVE_BUTTON:
                    if (HostClickedOnRemoveButton == null) break;
                    ServerMessageParsers.HOST_CLICKED_ON_REMOVE_BUTTON.Build(buffer, index, length).Parse(out byte slotIndex).CheckPadding();
                    HostClickedOnRemoveButton(slotIndex);
                    break;
                case ServerMessageType.HOST_CLICKED_ON_START_BUTTON:
                    if (HostClickedOnStartButton == null) break;
                    ServerMessageParsers.HOST_CLICKED_ON_START_BUTTON.Build(buffer, index, length).CheckPadding();
                    HostClickedOnStartButton();
                    break;
                case ServerMessageType.CANCEL_START_COOLDOWN:
                    if (CancelStartCooldown == null) break;
                    ServerMessageParsers.CANCEL_START_COOLDOWN.Build(buffer, index, length).CheckPadding();
                    CancelStartCooldown();
                    break;
                case ServerMessageType.ASSIGN_NEW_HOST:
                    if (AssignNewHost == null) break;
                    ServerMessageParsers.ASSIGN_NEW_HOST.Build(buffer, index, length).Parse(out player);
                    AssignNewHost(player);
                    break;
                case ServerMessageType.VOTED_TO_REPICK_HOST:
                    if (VotedToRepickHost == null) break;
                    ServerMessageParsers.VOTED_TO_REPICK_HOST.Build(buffer, index, length).Parse(out byte votesUntilRepick);
                    VotedToRepickHost(votesUntilRepick);
                    break;
                case ServerMessageType.NO_LONGER_HOST:
                    if (NoLongerHost == null) break;
                    ServerMessageParsers.NO_LONGER_HOST.Build(buffer, index, length).CheckPadding();
                    NoLongerHost();
                    break;
                case ServerMessageType.DO_NOT_SPAM:
                    if (DoNotSpam == null) break;
                    ServerMessageParsers.DO_NOT_SPAM.Build(buffer, index, length).CheckPadding();
                    DoNotSpam();
                    break;
                case ServerMessageType.HOW_MANY_PLAYERS_AND_GAMES:
                    if (HowManyPlayersAndGames == null) break;
                    ServerMessageParsers.HOW_MANY_PLAYERS_AND_GAMES.Build(buffer, index, length).Parse(out uint playerCount).Parse(out uint gameCount).CheckPadding();
                    HowManyPlayersAndGames(playerCount, gameCount);
                    break;
                case ServerMessageType.SYSTEM_MESSAGE:
                    if (SystemMessage == null) break;
                    ServerMessageParsers.SYSTEM_MESSAGE.Build(buffer, index, length).Parse(out message).CheckPadding();
                    SystemMessage(message);
                    break;
                case ServerMessageType.STRING_TABLE_MESSAGE:
                    if (StringTableMessage == null) break;
                    ServerMessageParsers.STRING_TABLE_MESSAGE.Build(buffer, index, length).Parse(out LocalizationTable tableMessage);
                    StringTableMessage(tableMessage);
                    break;
                case ServerMessageType.FRIEND_LIST:
                    if (FriendList == null) break;
                    ServerMessageParsers.FRIEND_LIST.Build(buffer, index, length).Parse(parser => parser.Parse((username2, rest) => (username2, rest.userID2, rest.status2, rest.ownsCoven2), p => p.Parse((userID2, rest) => (userID2, rest.status2, rest.ownsCoven2), p2 => p2.Parse((status2, ownsCoven2) => (status2, ownsCoven2), p3 => p3.Parse(p4 => p4.CheckPadding())))), out IEnumerable<(string username, uint userID, OnlineStatus status, bool ownsCoven)> friendList).CheckPadding();
                    FriendList(friendList);
                    break;
                case ServerMessageType.FRIEND_REQUEST_NOTIFICATIONS:
                    if (FriendRequestNotifications == null) break;
                    ServerMessageParsers.FRIEND_REQUEST_NOTIFICATIONS.Build(buffer, index, length).Parse(parser => parser.Parse((username2, userID2) => (username2, userID2), p => p.Parse(p2 => p2.CheckPadding())), out IEnumerable<(string username, uint userID)> friendRequests).CheckPadding();
                    FriendRequestNotifications(friendRequests);
                    break;
                case ServerMessageType.ADD_FRIEND_REQUEST_RESPONSE:
                    if (AddFriendRequestResponse == null) break;
                    ServerMessageParsers.ADD_FRIEND_REQUEST_RESPONSE.Build(buffer, index, length).Parse(out bool success).CheckPadding();
                    AddFriendRequestResponse(success);
                    break;
                case ServerMessageType.CONFIRM_FRIEND_REQUEST:
                    if (ConfirmFriendRequest == null) break;
                    ServerMessageParsers.CONFIRM_FRIEND_REQUEST.Build(buffer, index, length).Parse(out uint userID).Parse(out OnlineStatus onlineStatus).Parse(out bool ownsCoven).CheckPadding();
                    ConfirmFriendRequest(userID, onlineStatus, ownsCoven);
                    break;
                case ServerMessageType.SUCCESSFULLY_REMOVED_FRIEND:
                    if (SuccessfullyRemovedFriend == null) break;
                    ServerMessageParsers.SUCCESSFULLY_REMOVED_FRIEND.Build(buffer, index, length).Parse(out userID).CheckPadding();
                    SuccessfullyRemovedFriend(userID);
                    break;
                case ServerMessageType.SUCCESSFULLY_DECLINED_FRIEND_REQUEST:
                    if (SuccessfullyDeclinedFriendRequest == null) break;
                    ServerMessageParsers.SUCCESSFULLY_DECLINED_FRIEND_REQUEST.Build(buffer, index, length).CheckPadding();
                    SuccessfullyDeclinedFriendRequest();
                    break;
                case ServerMessageType.FRIEND_UPDATE:
                    if (FriendUpdate == null) break;
                    ServerMessageParsers.FRIEND_UPDATE.Build(buffer, index, length).Parse(out userID).Parse(out onlineStatus).Parse(out ownsCoven).CheckPadding();
                    FriendUpdate(userID, onlineStatus, ownsCoven);
                    break;
                case ServerMessageType.FRIEND_MESSAGE:
                    if (FriendMessage == null) break;
                    ServerMessageParsers.FRIEND_MESSAGE.Build(buffer, index, length).Parse(out userID).Parse(out bool sent).Parse(out message).CheckPadding();
                    FriendMessage(userID, sent, message);
                    break;
                case ServerMessageType.USER_INFORMATION:
                    if (UserInformation == null) break;
                    ServerMessageParsers.USER_INFORMATION.Build(buffer, index, length).Parse(out username).Parse(out uint townPoints).Parse(out uint meritPoints).CheckPadding();
                    UserInformation(username, townPoints, meritPoints);
                    break;
                case ServerMessageType.CREATE_PARTY_LOBBY:
                    if (CreatePartyLobby == null) break;
                    ServerMessageParsers.CREATE_PARTY_LOBBY.Build(buffer, index, length).Parse(out Brand brand).CheckPadding();
                    CreatePartyLobby(brand);
                    break;
                case ServerMessageType.PARTY_INVITE_FAILED:
                    if (PartyInviteFailed == null) break;
                    ServerMessageParsers.PARTY_INVITE_FAILED.Build(buffer, index, length).Parse(out username).Parse(out FailedInvitationStatus failedInvitationStatus).CheckPadding();
                    PartyInviteFailed(username, failedInvitationStatus);
                    break;
                case ServerMessageType.PARTY_INVITE_NOTIFICATION:
                    if (PartyInviteNotification == null) break;
                    ServerMessageParsers.PARTY_INVITE_NOTIFICATION.Build(buffer, index, length).Parse(out userID).Parse(out username).CheckPadding();
                    PartyInviteNotification(userID, username);
                    break;
                case ServerMessageType.ACCEPTED_PARTY_INVITE:
                    if (AcceptedPartyInvite == null) break;
                    ServerMessageParsers.ACCEPTED_PARTY_INVITE.Build(buffer, index, length).Parse(out AcceptInvitationResult acceptInvitationResult).CheckPadding();
                    AcceptedPartyInvite(acceptInvitationResult);
                    break;
                case ServerMessageType.PENDING_PARTY_INVITE_STATUS:
                    if (PendingPartyInviteStatus == null) break;
                    ServerMessageParsers.PENDING_PARTY_INVITE_STATUS.Build(buffer, index, length).Parse(out username).Parse(out PendingInvitationStatus pendingInvitationStatus).CheckPadding();
                    PendingPartyInviteStatus(username, pendingInvitationStatus);
                    break;
                case ServerMessageType.SUCCESSFULLY_LEFT_PARTY:
                    if (SuccessfullyLeftParty == null) break;
                    ServerMessageParsers.SUCCESSFULLY_LEFT_PARTY.Build(buffer, index, length).CheckPadding();
                    SuccessfullyLeftParty();
                    break;
                case ServerMessageType.PARTY_CHAT:
                    if (PartyChat == null) break;
                    ServerMessageParsers.PARTY_CHAT.Build(buffer, index, length).Parse(out username).Parse(out message).CheckPadding();
                    PartyChat(username, message);
                    break;
                case ServerMessageType.PARTY_MEMBER_LEFT:
                    if (PartyMemberLeft == null) break;
                    ServerMessageParsers.PARTY_MEMBER_LEFT.Build(buffer, index, length).Parse(out username).CheckPadding();
                    PartyMemberLeft(username);
                    break;
                case ServerMessageType.SETTINGS_INFORMATION:
                    if (SettingsInformation == null) break;
                    ServerMessageParsers.SETTINGS_INFORMATION.Build(buffer, index, length).Parse(out bool filterChat).Parse(out bool muteMusic).Parse(out bool muteEffects).Parse(out bool shareSkin).Parse(out bool classicSkinsOnly).Parse(out bool displayPets).Parse(out byte effectsVolume).Parse(out byte musicVolume).Parse(out Language language).Parse(out byte unknown).Parse(out TipBehaviour tipBehaviour).CheckPadding();
                    SettingsInformation(filterChat, muteMusic, muteEffects, shareSkin, classicSkinsOnly, displayPets, effectsVolume, musicVolume, language, unknown, tipBehaviour);
                    break;
                case ServerMessageType.ADD_FRIEND:
                    if (AddFriend == null) break;
                    ServerMessageParsers.ADD_FRIEND.Build(buffer, index, length).Parse(out username).Parse(out userID).Parse(out onlineStatus).Parse(out ownsCoven).CheckPadding();
                    AddFriend(username, userID, onlineStatus, ownsCoven);
                    break;
                case ServerMessageType.FORCED_LOGOUT:
                    if (ForcedLogout == null) break;
                    ServerMessageParsers.FORCED_LOGOUT.Build(buffer, index, length).CheckPadding();
                    ForcedLogout();
                    break;
                case ServerMessageType.RETURN_TO_HOME_PAGE:
                    if (ReturnToHomePage == null) break;
                    ServerMessageParsers.RETURN_TO_HOME_PAGE.Build(buffer, index, length).CheckPadding();
                    ReturnToHomePage();
                    break;
                case ServerMessageType.SHOP_PURCHASE_SUCCESS:
                    if (ShopPurchaseSuccess == null) break;
                    ServerMessageParsers.SHOP_PURCHASE_SUCCESS.Build(buffer, index, length).CheckPadding();
                    ShopPurchaseSuccess();
                    break;
                case ServerMessageType.PURCHASED_CHARACTERS:
                    if (PurchasedCharacters == null) break;
                    ServerMessageParsers.PURCHASED_CHARACTERS.Build(buffer, index, length).Parse(parser => parser.Parse(p => p.CheckPadding()), out IEnumerable<Character> characters).CheckPadding();
                    PurchasedCharacters(characters);
                    break;
                case ServerMessageType.PURCHASED_HOUSES:
                    if (PurchasedHouses == null) break;
                    ServerMessageParsers.PURCHASED_HOUSES.Build(buffer, index, length).Parse(parser => parser.Parse(p => p.CheckPadding()), out IEnumerable<House> houses).CheckPadding();
                    PurchasedHouses(houses);
                    break;
                case ServerMessageType.PURCHASED_BACKGROUNDS:
                    if (PurchasedBackgrounds == null) break;
                    ServerMessageParsers.PURCHASED_BACKGROUNDS.Build(buffer, index, length).Parse(parser => parser.Parse(p => p.CheckPadding()), out IEnumerable<Background> backgrounds).CheckPadding();
                    PurchasedBackgrounds(backgrounds);
                    break;
                case ServerMessageType.SELECTION_SETTINGS:
                    if (SelectionSettings == null) break;
                    ServerMessageParsers.SELECTION_SETTINGS.Build(buffer, index, length).Parse(out Character character).Parse(out House house).Parse(out Background background).Parse(out Pet? pet).Parse(out lobbyIcon).Parse(out DeathAnimation deathAnimation).Parse(out Scroll? scroll1).Parse(out Scroll? scroll2).Parse(out Scroll? scroll3).Parse(out string name).CheckPadding();
                    SelectionSettings(character, house, background, pet, lobbyIcon, deathAnimation, scroll1, scroll2, scroll3, name);
                    break;
                case ServerMessageType.REDEEM_CODE_MESSAGE:
                    if (RedeemCodeMessage == null) break;
                    RedeemCodeReward redeemCodeReward = default;
                    string rewardArgs = null;
                    ServerMessageParsers.REDEEM_CODE_MESSAGE.Build(buffer, index, length).Parse(out RedeemCodeResult redeemCodeResult).Parse(redeemCodeResult == RedeemCodeResult.SUCCESS, parser => parser.Parse(out redeemCodeReward).Parse(out rewardArgs), parser => parser).CheckPadding();
                    RedeemCodeMessage(redeemCodeResult, redeemCodeResult == RedeemCodeResult.SUCCESS ? (RedeemCodeReward?)redeemCodeReward : null, rewardArgs);
                    break;
                case ServerMessageType.UPDATE_PAID_CURRENCY:
                    if (UpdatePaidCurrency == null) break;
                    ServerMessageParsers.UPDATE_PAID_CURRENCY.Build(buffer, index, length).Parse(out townPoints).CheckPadding();
                    UpdatePaidCurrency(townPoints);
                    break;
                case ServerMessageType.PURCHASED_PACKS:
                    if (PurchasedPacks == null) break;
                    ServerMessageParsers.PURCHASED_PACKS.Build(buffer, index, length).Parse(parser => parser.Parse(p => p.CheckPadding()), out IEnumerable<Pack> packs).CheckPadding();
                    PurchasedPacks(packs);
                    break;
                case ServerMessageType.PURCHASED_PETS:
                    if (PurchasedPets == null) break;
                    ServerMessageParsers.PURCHASED_PETS.Build(buffer, index, length).Parse(parser => parser.Parse(p => p.CheckPadding()), out IEnumerable<Pet> pets).CheckPadding();
                    PurchasedPets(pets);
                    break;
                case ServerMessageType.SET_LAST_BONUS_WIN_TIME:
                    if (SetLastBonusWinTime == null) break;
                    ServerMessageParsers.SET_LAST_BONUS_WIN_TIME.Build(buffer, index, length).Parse(out uint lastBonusWinTime).CheckPadding();
                    SetLastBonusWinTime(lastBonusWinTime);
                    break;
                case ServerMessageType.EARNED_ACHIEVEMENTS_52:
                    if (EarnedAchievements52 == null) break;
                    ServerMessageParsers.EARNED_ACHIEVEMENTS_52.Build(buffer, index, length).Parse(parser => parser.Parse(p => p.CheckPadding()), out IEnumerable<Achievement> achievements).CheckPadding();
                    EarnedAchievements52(achievements);
                    break;
                case ServerMessageType.PURCHASED_LOBBY_ICONS:
                    if (PurchasedLobbyIcons == null) break;
                    ServerMessageParsers.PURCHASED_LOBBY_ICONS.Build(buffer, index, length).Parse(parser => parser.Parse(p => p.CheckPadding()), out IEnumerable<LobbyIcon> lobbyIcons).CheckPadding();
                    PurchasedLobbyIcons(lobbyIcons);
                    break;
                case ServerMessageType.PURCHASED_DEATH_ANIMATIONS:
                    if (PurchasedDeathAnimations == null) break;
                    ServerMessageParsers.PURCHASED_DEATH_ANIMATIONS.Build(buffer, index, length).Parse(parser => parser.Parse(p => p.CheckPadding()), out IEnumerable<DeathAnimation> deathAnimations).CheckPadding();
                    PurchasedDeathAnimations(deathAnimations);
                    break;
                case ServerMessageType.FACEBOOK_INVITE_FRIENDS:
                    if (FacebookInviteFriends == null) break;
                    ServerMessageParsers.FACEBOOK_INVITE_FRIENDS.Build(buffer, index, length).CheckPadding();
                    FacebookInviteFriends();
                    break;
                case ServerMessageType.PURCHASED_SCROLLS:
                    if (PurchasedScrolls == null) break;
                    ServerMessageParsers.PURCHASED_SCROLLS.Build(buffer, index, length).Parse(parser => parser.Parse((scroll4, amount) => (scroll4, amount), p => p.Parse(p2 => p2.CheckPadding())), out IEnumerable<(Scroll scroll, uint amount)> scrolls).CheckPadding();
                    PurchasedScrolls(scrolls);
                    break;
                case ServerMessageType.HOST_GIVEN_TO_PLAYER:
                    if (HostGivenToPlayer == null) break;
                    ServerMessageParsers.HOST_GIVEN_TO_PLAYER.Build(buffer, index, length).Parse(out username).CheckPadding();
                    HostGivenToPlayer(username);
                    break;
                case ServerMessageType.HOST_GIVEN_TO_ME:
                    if (HostGivenToMe == null) break;
                    ServerMessageParsers.HOST_GIVEN_TO_ME.Build(buffer, index, length).CheckPadding();
                    HostGivenToMe();
                    break;
                case ServerMessageType.KICKED_PLAYER:
                    if (KickedPlayer == null) break;
                    ServerMessageParsers.KICKED_PLAYER.Build(buffer, index, length).Parse(out username).CheckPadding();
                    KickedPlayer(username);
                    break;
                case ServerMessageType.KICKED_ME:
                    if (KickedMe == null) break;
                    ServerMessageParsers.KICKED_ME.Build(buffer, index, length).CheckPadding();
                    KickedMe();
                    break;
                case ServerMessageType.INVITE_POWERS_GIVEN_TO_PLAYER:
                    if (InvitePowersGivenToPlayer == null) break;
                    ServerMessageParsers.INVITE_POWERS_GIVEN_TO_PLAYER.Build(buffer, index, length).Parse(out username).CheckPadding();
                    InvitePowersGivenToPlayer(username);
                    break;
                case ServerMessageType.INVITE_POWERS_GIVEN_TO_ME:
                    if (InvitePowersGivenToMe == null) break;
                    ServerMessageParsers.INVITE_POWERS_GIVEN_TO_ME.Build(buffer, index, length).CheckPadding();
                    InvitePowersGivenToMe();
                    break;
                case ServerMessageType.STEAM_FIRST_LOGIN:
                    if (SteamFirstLogin == null) break;
                    ServerMessageParsers.STEAM_FIRST_LOGIN.Build(buffer, index, length).CheckPadding();
                    SteamFirstLogin();
                    break;
                case ServerMessageType.UPDATE_FRIEND_USERNAME:
                    if (UpdateFriendUsername == null) break;
                    ServerMessageParsers.UPDATE_FRIEND_USERNAME.Build(buffer, index, length).Parse(out username).Parse(out string newUsername).CheckPadding();
                    UpdateFriendUsername(username, newUsername);
                    break;
                case ServerMessageType.ENABLE_SHOP_BUTTONS:
                    if (EnableShopButtons == null) break;
                    ServerMessageParsers.ENABLE_SHOP_BUTTONS.Build(buffer, index, length).CheckPadding();
                    EnableShopButtons();
                    break;
                case ServerMessageType.REGISTER:
                    if (Register == null) break;
                    ServerMessageParsers.REGISTER.Build(buffer, index, length).CheckPadding();
                    Register();
                    break;
                case ServerMessageType.AUTHENTICATE_WITH_STEAM_CLOUD:
                    if (AuthenticateWithSteamCloud == null) break;
                    ServerMessageParsers.AUTHENTICATE_WITH_STEAM_CLOUD.Build(buffer, index, length).Parse(out username).CheckPadding();
                    AuthenticateWithSteamCloud(username);
                    break;
                case ServerMessageType.START_RANKED_QUEUE:
                    if (StartRankedQueue == null) break;
                    ServerMessageParsers.START_RANKED_QUEUE.Build(buffer, index, length).Parse(out bool requeue).Parse(out uint queueTimer).CheckPadding();
                    StartRankedQueue(requeue, queueTimer);
                    break;
                case ServerMessageType.LEAVE_RANKED_QUEUE:
                    if (LeaveRankedQueue == null) break;
                    ServerMessageParsers.LEAVE_RANKED_QUEUE.Build(buffer, index, length).CheckPadding();
                    LeaveRankedQueue();
                    break;
                case ServerMessageType.ACCEPT_RANKED_POPUP:
                    if (AcceptRankedPopup == null) break;
                    ServerMessageParsers.ACCEPT_RANKED_POPUP.Build(buffer, index, length).CheckPadding();
                    AcceptRankedPopup();
                    break;
                case ServerMessageType.USER_STATISTICS:
                    if (UserStatistics == null) break;
                    ServerMessageParsers.USER_STATISTICS.Build(buffer, index, length).Parse(out uint gamesPlayed).Parse(out uint gamesWon).Parse(out uint gamesDrawn).Parse(out uint gamesDisconnected).Parse(out uint friendsReferred).CheckPadding();
                    UserStatistics(gamesPlayed, gamesWon, gamesDrawn, gamesDisconnected, friendsReferred);
                    break;
                case ServerMessageType.RANKED_TIMEOUT_DURATION:
                    if (RankedTimeoutDuration == null) break;
                    ServerMessageParsers.RANKED_TIMEOUT_DURATION.Build(buffer, index, length).Parse(out uint timeoutDuration).CheckPadding();
                    RankedTimeoutDuration(timeoutDuration);
                    break;
                case ServerMessageType.AUTHENTICATE_WITH_STEAM:
                    if (AuthenticateWithSteam == null) break;
                    ServerMessageParsers.AUTHENTICATE_WITH_STEAM.Build(buffer, index, length).Parse(out username).CheckPadding();
                    AuthenticateWithSteam(username);
                    break;
                case ServerMessageType.MODERATOR_MESSAGE:
                    if (ModeratorMessage == null) break;
                    ServerMessageParsers.MODERATOR_MESSAGE.Build(buffer, index, length).Parse(out ModeratorMessage modMessage).Parse(out string args).CheckPadding();
                    ModeratorMessage(modMessage, args);
                    break;
                case ServerMessageType.REFER_A_FRIEND_UPDATE:
                    if (ReferAFriendUpdate == null) break;
                    townPoints = 0u;
                    ServerMessageParsers.REFER_A_FRIEND_UPDATE.Build(buffer, index, length).Parse(out ReferralReward reward).Parse(reward < (ReferralReward)4, parser => parser.Parse(out townPoints), parser => parser).CheckPadding();
                    ReferAFriendUpdate(reward, reward < (ReferralReward)4 ? null : (uint?)townPoints);
                    break;
                case ServerMessageType.PLAYER_STATISTICS:
                    if (PlayerStatistics == null) break;
                    ServerMessageParsers.PLAYER_STATISTICS.Build(buffer, index, length).Parse(parser => parser.Parse(p => p.CheckPadding()), out IEnumerable<uint> statistics).CheckPadding();
                    PlayerStatistics(statistics);
                    break;
                case ServerMessageType.SCROLL_CONSUMED:
                    if (ScrollConsumed == null) break;
                    ServerMessageParsers.SCROLL_CONSUMED.Build(buffer, index, length).Parse(out Scroll scroll).CheckPadding();
                    ScrollConsumed(scroll);
                    break;
                case ServerMessageType.AD_VIEW_RESPONSE:
                    if (AdViewResponse == null) break;
                    uint value = 0u;
                    byte byteValue = 0;
                    ServerMessageParsers.AD_VIEW_RESPONSE.Build(buffer, index, length).Parse(out AdViewResult adViewResult).Parse(adViewResult == AdViewResult.GIVE_PRIZE || adViewResult == AdViewResult.SET_TOKEN, parser => parser.Parse(adViewResult == AdViewResult.GIVE_PRIZE, p => p.Parse(out byteValue), p => p.Parse(out value)), parser => parser).CheckPadding();
                    AdViewResponse(adViewResult, adViewResult == AdViewResult.GIVE_PRIZE ? byteValue : value);
                    break;
                case ServerMessageType.USER_JOINING_LOBBY_TOO_QUICKLY_MESSAGE:
                    if (UserJoiningLobbyTooQuickly == null) break;
                    ServerMessageParsers.USER_JOINING_LOBBY_TOO_QUICKLY.Build(buffer, index, length).CheckPadding();
                    UserJoiningLobbyTooQuickly();
                    break;
                case ServerMessageType.PROMOTION_POPUP:
                    if (PromotionPopup == null) break;
                    ServerMessageParsers.PROMOTION_POPUP.Build(buffer, index, length).Parse(out Promotion promotion).Parse(out uint secondsActive).Parse(out double discount).Parse(out uint refID).CheckPadding();
                    PromotionPopup(promotion, secondsActive, discount, refID);
                    break;
                case ServerMessageType.KICKSTARTER_SHARE:
                    if (KickstarterShare == null) break;
                    ServerMessageParsers.KICKSTARTER_SHARE.Build(buffer, index, length).CheckPadding();
                    KickstarterShare();
                    break;
                case ServerMessageType.TUTORIAL_PROGRESS:
                    if (TutorialProgress == null) break;
                    ServerMessageParsers.TUTORIAL_PROGRESS.Build(buffer, index, length).Parse(parser => parser.Parse(p => p.CheckPadding()), out IEnumerable<TutorialTip> tutorialTips);
                    TutorialProgress(tutorialTips);
                    break;
                case ServerMessageType.PURCHASED_TAUNTS:
                    if (PurchasedTaunts == null) break;
                    ServerMessageParsers.PURCHASED_TAUNTS.Build(buffer, index, length).Parse(parser => parser.Parse((taunt2, amount) => (taunt2, amount), p => p.Parse(p2 => p2.CheckPadding())), out IEnumerable<(Taunt taunt, uint amount)> taunts);
                    PurchasedTaunts(taunts);
                    break;
                case ServerMessageType.CURRENCY_MULTIPLIER:
                    if (CurrencyMultiplier == null) break;
                    ServerMessageParsers.CURRENCY_MULTIPLIER.Build(buffer, index, length).Parse(parser => parser.Parse((currency, multiplier) => (currency, multiplier), p => p.Parse(p2 => p2.CheckPadding())), out IEnumerable<(Currency currency, uint multiplier)> currencyMultipliers);
                    CurrencyMultiplier(currencyMultipliers);
                    break;
                case ServerMessageType.PICK_NAMES:
                    if (PickNames == null) break;
                    ServerMessageParsers.PICK_NAMES.Build(buffer, index, length).Parse(out byte playerCountByte).Parse(out gameMode).CheckPadding();
                    PickNames(playerCountByte, gameMode);
                    break;
                case ServerMessageType.NAMES_AND_POSITIONS_OF_USERS:
                    if (NamesAndPositionsOfUsers == null) break;
                    ServerMessageParsers.NAMES_AND_POSITIONS_OF_USERS.Build(buffer, index, length).Parse(out player).Parse(out name).CheckPadding();
                    NamesAndPositionsOfUsers(player, name);
                    break;
                case ServerMessageType.ROLE_AND_POSITION:
                    if (RoleAndPosition == null) break;
                    ServerMessageParsers.ROLE_AND_POSITION.Build(buffer, index, length).Parse(out role).Parse(out player).Parse(out Option<Player> optionalPlayer).CheckPadding();
                    RoleAndPosition(role, player, optionalPlayer);
                    break;
                case ServerMessageType.START_NIGHT:
                    if (StartNight == null) break;
                    ServerMessageParsers.START_NIGHT.Build(buffer, index, length).CheckPadding();
                    StartNight();
                    break;
                case ServerMessageType.START_DAY:
                    if (StartDay == null) break;
                    ServerMessageParsers.START_DAY.Build(buffer, index, length).CheckPadding();
                    StartDay();
                    break;
                case ServerMessageType.WHO_DIED_AND_HOW:
                    if (WhoDiedAndHow == null) break;
                    ServerMessageParsers.WHO_DIED_AND_HOW.Build(buffer, index, length).Parse(out player).Parse(out role).Parse(out bool announce).Parse(parser => parser.Parse(p => p.CheckPadding()), out IEnumerable<DeathCause> deathCauses).CheckPadding();
                    WhoDiedAndHow(player, role, announce, deathCauses);
                    break;
                case ServerMessageType.START_DISCUSSION:
                    if (StartDiscussion == null) break;
                    ServerMessageParsers.START_DISCUSSION.Build(buffer, index, length).CheckPadding();
                    StartDiscussion();
                    break;
                case ServerMessageType.START_VOTING:
                    if (StartVoting == null) break;
                    ServerMessageParsers.START_VOTING.Build(buffer, index, length).Parse(out byte votesNeeded).CheckPadding();
                    StartVoting(votesNeeded);
                    break;
                case ServerMessageType.START_DEFENSE_TRANSITION:
                    if (StartDefenseTransition == null) break;
                    ServerMessageParsers.START_DEFENSE_TRANSITION.Build(buffer, index, length).Parse(out player).CheckPadding();
                    StartDefenseTransition(player);
                    break;
                case ServerMessageType.START_JUDGEMENT:
                    if (StartJudgement == null) break;
                    ServerMessageParsers.START_JUDGEMENT.Build(buffer, index, length).CheckPadding();
                    StartJudgement();
                    break;
                case ServerMessageType.TRIAL_FOUND_GUILTY:
                    if (TrialFoundGuilty == null) break;
                    ServerMessageParsers.TRIAL_FOUND_GUILTY.Build(buffer, index, length).Parse(out byte guiltyVotes).Parse(out byte innocentVotes).CheckPadding();
                    TrialFoundGuilty(guiltyVotes, innocentVotes);
                    break;
                case ServerMessageType.TRIAL_FOUND_NOT_GUILTY:
                    if (TrialFoundNotGuilty == null) break;
                    ServerMessageParsers.TRIAL_FOUND_NOT_GUILTY.Build(buffer, index, length).Parse(out guiltyVotes).Parse(out innocentVotes).CheckPadding();
                    TrialFoundNotGuilty(guiltyVotes, innocentVotes);
                    break;
                case ServerMessageType.LOOKOUT_NIGHT_ABILITY_MESSAGE:
                    if (LookoutNightAbilityMessage == null) break;
                    ServerMessageParsers.LOOKOUT_NIGHT_ABILITY_MESSAGE.Build(buffer, index, length).Parse(out player).CheckPadding();
                    LookoutNightAbilityMessage(player);
                    break;
                case ServerMessageType.USER_VOTED:
                    if (UserVoted == null) break;
                    ServerMessageParsers.USER_VOTED.Build(buffer, index, length).Parse(out player).Parse(out Player player3).Parse(out byte voteCount).CheckPadding();
                    UserVoted(player, player3, voteCount);
                    break;
                case ServerMessageType.USER_CANCELED_VOTE:
                    if (UserCanceledVote == null) break;
                    ServerMessageParsers.USER_CANCELED_VOTE.Build(buffer, index, length).Parse(out player).Parse(out player3).Parse(out voteCount).CheckPadding();
                    UserCanceledVote(player, player3, voteCount);
                    break;
                case ServerMessageType.USER_CHANGED_VOTE:
                    if (UserChangedVote == null) break;
                    ServerMessageParsers.USER_CHANGED_VOTE.Build(buffer, index, length).Parse(out player).Parse(out player3).Parse(out Player player4).Parse(out voteCount).CheckPadding();
                    UserChangedVote(player, player3, player4, voteCount);
                    break;
                case ServerMessageType.USER_DIED:
                    if (UserDied == null) break;
                    ServerMessageParsers.USER_DIED.Build(buffer, index, length).Parse(out bool silent).CheckPadding();
                    UserDied(silent);
                    break;
                case ServerMessageType.RESURRECTION:
                    if (Resurrection == null) break;
                    ServerMessageParsers.RESURRECTION.Build(buffer, index, length).Parse(out player).Parse(out role).CheckPadding();
                    Resurrection(player, role);
                    break;
                case ServerMessageType.TELL_ROLE_LIST:
                    if (TellRoleList == null) break;
                    ServerMessageParsers.TELL_ROLE_LIST.Build(buffer, index, length).Parse(parser => parser.Parse(p => p.CheckPadding()), out IEnumerable<Role> roles).CheckPadding();
                    TellRoleList(roles);
                    break;
                case ServerMessageType.USER_CHOSEN_NAME:
                    if (UserChosenName == null) break;
                    ServerMessageParsers.USER_CHOSEN_NAME.Build(buffer, index, length).Parse(out tableMessage).Parse(out player).Parse(out name).CheckPadding();
                    UserChosenName(tableMessage, player, name);
                    break;
                case ServerMessageType.OTHER_MAFIA:
                    if (OtherMafia == null) break;
                    ServerMessageParsers.OTHER_MAFIA.Build(buffer, index, length).Parse(parser => parser.Parse((player2, role2) => (player2, role2), p => p.Parse(p2 => p2.CheckPadding())), out IEnumerable<(Player player, Role role)> teammates).CheckPadding();
                    OtherMafia(teammates);
                    break;
                case ServerMessageType.TELL_TOWN_AMNESIAC_CHANGED_ROLE:
                    if (TellTownAmnesiacChangedRole == null) break;
                    ServerMessageParsers.TELL_TOWN_AMNESIAC_CHANGED_ROLE.Build(buffer, index, length).Parse(out role).CheckPadding();
                    TellTownAmnesiacChangedRole(role);
                    break;
                case ServerMessageType.AMNESIAC_CHANGED_ROLE:
                    if (AmnesiacChangedRole == null) break;
                    ServerMessageParsers.AMNESIAC_CHANGED_ROLE.Build(buffer, index, length).Parse(out role).Parse(out optionalPlayer).CheckPadding();
                    AmnesiacChangedRole(role, optionalPlayer);
                    break;
                case ServerMessageType.BROUGHT_BACK_TO_LIFE:
                    if (BroughtBackToLife == null) break;
                    ServerMessageParsers.BROUGHT_BACK_TO_LIFE.Build(buffer, index, length).CheckPadding();
                    BroughtBackToLife();
                    break;
                case ServerMessageType.START_FIRST_DAY:
                    if (StartFirstDay == null) break;
                    ServerMessageParsers.START_FIRST_DAY.Build(buffer, index, length).CheckPadding();
                    StartFirstDay();
                    break;
                case ServerMessageType.BEING_JAILED:
                    if (BeingJailed == null) break;
                    ServerMessageParsers.BEING_JAILED.Build(buffer, index, length).CheckPadding();
                    BeingJailed();
                    break;
                case ServerMessageType.JAILED_TARGET:
                    if (JailedTarget == null) break;
                    ServerMessageParsers.JAILED_TARGET.Build(buffer, index, length).Parse(out player).Parse(out bool canExecute).Parse(out bool executedTown).CheckPadding();
                    JailedTarget(player, canExecute, executedTown);
                    break;
                case ServerMessageType.USER_JUDGEMENT_VOTED:
                    if (UserJudgementVoted == null) break;
                    ServerMessageParsers.USER_JUDGEMENT_VOTED.Build(buffer, index, length).Parse(out player).CheckPadding();
                    UserJudgementVoted(player);
                    break;
                case ServerMessageType.USER_CHANGED_JUDGEMENT_VOTE:
                    if (UserChangedJudgementVote == null) break;
                    ServerMessageParsers.USER_CHANGED_JUDGEMENT_VOTE.Build(buffer, index, length).Parse(out player).CheckPadding();
                    UserChangedJudgementVote(player);
                    break;
                case ServerMessageType.USER_CANCELED_JUDGEMENT_VOTE:
                    if (UserCanceledJudgementVote == null) break;
                    ServerMessageParsers.USER_CANCELED_JUDGEMENT_VOTE.Build(buffer, index, length).Parse(out player).CheckPadding();
                    UserCanceledJudgementVote(player);
                    break;
                case ServerMessageType.TELL_JUDGEMENT_VOTES:
                    if (TellJudgementVotes == null) break;
                    ServerMessageParsers.TELL_JUDGEMENT_VOTES.Build(buffer, index, length).Parse(out player).Parse(out JudgementVote judgementVote).CheckPadding();
                    TellJudgementVotes(player, judgementVote);
                    break;
                case ServerMessageType.EXECUTIONER_COMPLETED_GOAL:
                    if (ExecutionerCompletedGoal == null) break;
                    ServerMessageParsers.EXECUTIONER_COMPLETED_GOAL.Build(buffer, index, length).CheckPadding();
                    ExecutionerCompletedGoal();
                    break;
                case ServerMessageType.JESTER_COMPLETED_GOAL:
                    if (JesterCompletedGoal == null) break;
                    ServerMessageParsers.JESTER_COMPLETED_GOAL.Build(buffer, index, length).CheckPadding();
                    JesterCompletedGoal();
                    break;
                case ServerMessageType.MAYOR_REVEALED:
                    if (MayorRevealed == null) break;
                    ServerMessageParsers.MAYOR_REVEALED.Build(buffer, index, length).Parse(out player).CheckPadding();
                    MayorRevealed(player);
                    break;
                case ServerMessageType.MAYOR_REVEALED_AND_ALREADY_VOTED:
                    if (MayorRevealedAndAlreadyVoted == null) break;
                    ServerMessageParsers.MAYOR_REVEALED_AND_ALREADY_VOTED.Build(buffer, index, length).Parse(out player).CheckPadding();
                    MayorRevealedAndAlreadyVoted(player);
                    break;
                case ServerMessageType.DISGUISER_STOLE_YOUR_IDENTITY:
                    if (DisguiserStoleYourIdentity == null) break;
                    ServerMessageParsers.DISGUISER_STOLE_YOUR_IDENTITY.Build(buffer, index, length).Parse(out player).CheckPadding();
                    DisguiserStoleYourIdentity(player);
                    break;
                case ServerMessageType.DISGUISER_CHANGED_IDENTITY:
                    if (DisguiserChangedIdentity == null) break;
                    ServerMessageParsers.DISGUISER_CHANGED_IDENTITY.Build(buffer, index, length).Parse(out player).CheckPadding();
                    DisguiserChangedIdentity(player);
                    break;
                case ServerMessageType.DISGUISER_CHANGED_UPDATE_MAFIA:
                    if (DisguiserChangedUpdateMafia == null) break;
                    ServerMessageParsers.DISGUISER_CHANGED_UPDATE_MAFIA.Build(buffer, index, length).Parse(out player).Parse(out player3).CheckPadding();
                    DisguiserChangedUpdateMafia(player, player3);
                    break;
                case ServerMessageType.MEDIUM_IS_TALKING_TO_US:
                    if (MediumIsTalkingToUs == null) break;
                    ServerMessageParsers.MEDIUM_IS_TALKING_TO_US.Build(buffer, index, length).CheckPadding();
                    MediumIsTalkingToUs();
                    break;
                case ServerMessageType.MEDIUM_COMMUNICATING:
                    if (MediumCommunicating == null) break;
                    ServerMessageParsers.MEDIUM_COMMUNICATING.Build(buffer, index, length).CheckPadding();
                    MediumCommunicating();
                    break;
                case ServerMessageType.TELL_LAST_WILL:
                    if (TellLastWill == null) break;
                    string lastWill = null;
                    ServerMessageParsers.TELL_LAST_WILL.Build(buffer, index, length).Parse(out player).Parse(out bool hasLastWill).Parse(hasLastWill, parser => parser.Parse(out lastWill), parser => parser).CheckPadding();
                    TellLastWill(player, lastWill);
                    break;
                case ServerMessageType.HOW_MANY_ABILITIES_LEFT:
                    if (HowManyAbilitiesLeft == null) break;
                    ServerMessageParsers.HOW_MANY_ABILITIES_LEFT.Build(buffer, index, length).Parse(out byte abilitiesLeft).CheckPadding();
                    HowManyAbilitiesLeft(abilitiesLeft);
                    break;
                case ServerMessageType.MAFIA_TARGETING:
                    if (MafiaTargeting == null) break;
                    ServerMessageParsers.MAFIA_TARGETING.Build(buffer, index, length).Parse(out player).Parse(out role).Parse(out player3).Parse(out byte mod1).Parse(out Option<byte> mod2).Parse(out Option<byte> mod3).CheckPadding();
                    MafiaTargeting(player, role, player3, mod1, mod2.ToNullable(), mod3.ToNullable());
                    break;
                case ServerMessageType.TELL_JANITOR_TARGETS_ROLE:
                    if (TellJanitorTargetsRole == null) break;
                    ServerMessageParsers.TELL_JANITOR_TARGETS_ROLE.Build(buffer, index, length).Parse(out role).CheckPadding();
                    TellJanitorTargetsRole(role);
                    break;
                case ServerMessageType.TELL_JANITOR_TARGETS_WILL:
                    if (TellJanitorTargetsWill == null) break;
                    ServerMessageParsers.TELL_JANITOR_TARGETS_WILL.Build(buffer, index, length).Parse(out player).Parse(out lastWill).CheckPadding();
                    TellJanitorTargetsWill(player, lastWill);
                    break;
                case ServerMessageType.SOMEONE_HAS_WON:
                    if (SomeoneHasWon == null) break;
                    ServerMessageParsers.SOMEONE_HAS_WON.Build(buffer, index, length).Parse(out Faction faction).Parse(parser => parser.Parse(p => p.CheckPadding()), out IEnumerable<Player> players).CheckPadding();
                    SomeoneHasWon(faction, players);
                    break;
                case ServerMessageType.MAFIOSO_PROMOTED_TO_GODFATHER:
                    if (MafiosoPromotedToGodfather == null) break;
                    ServerMessageParsers.MAFIOSO_PROMOTED_TO_GODFATHER.Build(buffer, index, length).CheckPadding();
                    MafiosoPromotedToGodfather();
                    break;
                case ServerMessageType.MAFIOSO_PROMOTED_TO_GODFATHER_UPDATE_MAFIA:
                    if (MafiosoPromotedToGodfatherUpdateMafia == null) break;
                    ServerMessageParsers.MAFIOSO_PROMOTED_TO_GODFATHER_UPDATE_MAFIA.Build(buffer, index, length).Parse(out player).CheckPadding();
                    MafiosoPromotedToGodfatherUpdateMafia(player);
                    break;
                case ServerMessageType.MAFIA_PROMOTED_TO_MAFIOSO:
                    if (MafiaPromotedToMafioso == null) break;
                    ServerMessageParsers.MAFIA_PROMOTED_TO_MAFIOSO.Build(buffer, index, length).CheckPadding();
                    MafiaPromotedToMafioso();
                    break;
                case ServerMessageType.TELL_MAFIA_ABOUT_MAFIOSO_PROMOTION:
                    if (TellMafiaAboutMafiosoPromotion == null) break;
                    ServerMessageParsers.TELL_MAFIA_ABOUT_MAFIOSO_PROMOTION.Build(buffer, index, length).Parse(out player).CheckPadding();
                    TellMafiaAboutMafiosoPromotion(player);
                    break;
                case ServerMessageType.EXECUTIONER_CONVERTED_TO_JESTER:
                    if (ExecutionerConvertedToJester == null) break;
                    ServerMessageParsers.EXECUTIONER_CONVERTED_TO_JESTER.Build(buffer, index, length).CheckPadding();
                    ExecutionerConvertedToJester();
                    break;
                case ServerMessageType.AMNESIAC_BECAME_MAFIA_OR_WITCH:
                    if (AmnesiacBecameMafiaOrWitch == null) break;
                    ServerMessageParsers.AMNESIAC_BECAME_MAFIA_OR_WITCH.Build(buffer, index, length).Parse(out player).Parse(out role).CheckPadding();
                    AmnesiacBecameMafiaOrWitch(player, role);
                    break;
                case ServerMessageType.USER_DISCONNECTED:
                    if (UserDisconnected == null) break;
                    ServerMessageParsers.USER_DISCONNECTED.Build(buffer, index, length).Parse(out player).CheckPadding();
                    UserDisconnected(player);
                    break;
                case ServerMessageType.MAFIA_WAS_JAILED:
                    if (MafiaWasJailed == null) break;
                    ServerMessageParsers.MAFIA_WAS_JAILED.Build(buffer, index, length).Parse(out player).CheckPadding();
                    MafiaWasJailed(player);
                    break;
                case ServerMessageType.INVALID_NAME_MESSAGE:
                    if (InvalidNameMessage == null) break;
                    ServerMessageParsers.INVALID_NAME_MESSAGE.Build(buffer, index, length).Parse(out InvalidNameStatus invalidNameStatus).CheckPadding();
                    InvalidNameMessage(invalidNameStatus);
                    break;
                case ServerMessageType.START_NIGHT_TRANSITION:
                    if (StartNightTransition == null) break;
                    ServerMessageParsers.START_NIGHT_TRANSITION.Build(buffer, index, length).CheckPadding();
                    StartNightTransition();
                    break;
                case ServerMessageType.START_DAY_TRANSITION:
                    if (StartDayTransition == null) break;
                    ServerMessageParsers.START_DAY_TRANSITION.Build(buffer, index, length).Parse(parser => parser.Parse(p => p.CheckPadding()), out players).CheckPadding();
                    StartDayTransition(players);
                    break;
                case ServerMessageType.LYNCH_USER:
                    if (LynchUser == null) break;
                    ServerMessageParsers.LYNCH_USER.Build(buffer, index, length).CheckPadding();
                    LynchUser();
                    break;
                case ServerMessageType.DEATH_NOTE:
                    if (DeathNote == null) break;
                    ServerMessageParsers.DEATH_NOTE.Build(buffer, index, length).Parse(out player).Parse(out bool longTimer).Parse(out string deathNote).CheckPadding();
                    DeathNote(player, longTimer, deathNote);
                    break;
                case ServerMessageType.HOUSES_CHOSEN:
                    if (HousesChosen == null) break;
                    ServerMessageParsers.HOUSES_CHOSEN.Build(buffer, index, length).Parse(parser => parser.Parse((player2, house2) => (player2, house2), p => p.Parse(p2 => p2.CheckPadding())), out IEnumerable<(Player player, House house)> chosenHouses).CheckPadding();
                    HousesChosen(chosenHouses);
                    break;
                case ServerMessageType.FIRST_DAY_TRANSITION:
                    if (FirstDayTransition == null) break;
                    ServerMessageParsers.FIRST_DAY_TRANSITION.Build(buffer, index, length).CheckPadding();
                    FirstDayTransition();
                    break;
                case ServerMessageType.CHARACTERS_CHOSEN:
                    if (CharactersChosen == null) break;
                    ServerMessageParsers.CHARACTERS_CHOSEN.Build(buffer, index, length).Parse(parser => parser.Parse((player2, character2) => (player2, character2), p => p.Parse(p2 => p2.CheckPadding())), out IEnumerable<(Player player, Character character)> chosenCharacters).CheckPadding();
                    CharactersChosen(chosenCharacters);
                    break;
                case ServerMessageType.RESURRECTION_SET_ALIVE:
                    if (ResurrectionSetAlive == null) break;
                    ServerMessageParsers.RESURRECTION_SET_ALIVE.Build(buffer, index, length).Parse(out player).CheckPadding();
                    ResurrectionSetAlive(player);
                    break;
                case ServerMessageType.START_DEFENSE:
                    if (StartDefense == null) break;
                    ServerMessageParsers.START_DEFENSE.Build(buffer, index, length).CheckPadding();
                    StartDefense();
                    break;
                case ServerMessageType.USER_LEFT_DURING_SELECTION:
                    if (UserLeftDuringSelection == null) break;
                    ServerMessageParsers.USER_LEFT_DURING_SELECTION.Build(buffer, index, length).Parse(out player);
                    UserLeftDuringSelection(player);
                    break;
                case ServerMessageType.VIGILANTE_KILLED_TOWN:
                    if (VigilanteKilledTown == null) break;
                    ServerMessageParsers.VIGILANTE_KILLED_TOWN.Build(buffer, index, length).CheckPadding();
                    VigilanteKilledTown();
                    break;
                case ServerMessageType.NOTIFY_USERS_OF_PRIVATE_MESSAGE:
                    if (NotifyUsersOfPrivateMessage == null) break;
                    ServerMessageParsers.NOTIFY_USERS_OF_PRIVATE_MESSAGE.Build(buffer, index, length).Parse(out player).Parse(out player3).CheckPadding();
                    NotifyUsersOfPrivateMessage(player, player3);
                    break;
                case ServerMessageType.PRIVATE_MESSAGE:
                    if (PrivateMessage == null) break;
                    player3 = default;
                    message = null;
                    ServerMessageParsers.PRIVATE_MESSAGE.Build(buffer, index, length).Parse(out PrivateMessageType pmType).Parse(out player).Parse(pmType != PrivateMessageType.FROM_TO, parser => parser.Parse(out message), parser => parser.Parse(out player3).Parse(out message)).CheckPadding();
                    PrivateMessage(pmType, player, message, pmType == PrivateMessageType.FROM_TO ? (Player?)player3 : null);
                    break;
                case ServerMessageType.EARNED_ACHIEVEMENTS_161:
                    if (EarnedAchievements161 == null) break;
                    ServerMessageParsers.EARNED_ACHIEVEMENTS_161.Build(buffer, index, length).Parse(parser => parser.Parse(p => p.CheckPadding()), out achievements).CheckPadding();
                    EarnedAchievements161(achievements);
                    break;
                case ServerMessageType.AUTHENTICATION_FAILED:
                    if (AuthenticationFailed == null) break;
                    queueTimer = 0;
                    ServerMessageParsers.AUTHENTICATION_FAILED.Build(buffer, index, length).Parse(out AuthenticationResult authResult).Parse(authResult == AuthenticationResult.ACCOUNT_SUSPENDED, parser => parser.Parse(out queueTimer), parser => parser).CheckPadding();
                    AuthenticationFailed(authResult, authResult == AuthenticationResult.ACCOUNT_SUSPENDED ? (uint?)queueTimer : null);
                    break;
                case ServerMessageType.SPY_NIGHT_ABILITY_MESSAGE:
                    if (SpyNightAbilityMessage == null) break;
                    ServerMessageParsers.SPY_NIGHT_ABILITY_MESSAGE.Build(buffer, index, length).Parse(out bool isCoven).Parse(out player).CheckPadding();
                    SpyNightAbilityMessage(isCoven, player);
                    break;
                case ServerMessageType.ONE_DAY_BEFORE_STALEMATE:
                    if (OneDayBeforeStalemate == null) break;
                    ServerMessageParsers.ONE_DAY_BEFORE_STALEMATE.Build(buffer, index, length).CheckPadding();
                    OneDayBeforeStalemate();
                    break;
                case ServerMessageType.PETS_CHOSEN:
                    if (PetsChosen == null) break;
                    ServerMessageParsers.PETS_CHOSEN.Build(buffer, index, length).Parse(parser => parser.Parse((player2, pet2) => (player2, pet2), p => p.Parse(p2 => p2.CheckPadding())), out IEnumerable<(Player player, Pet pet)> chosenPets);
                    PetsChosen(chosenPets);
                    break;
                case ServerMessageType.FACEBOOK_SHARE_ACHIEVEMENT:
                    if (FacebookShareAchievement == null) break;
                    ServerMessageParsers.FACEBOOK_SHARE_ACHIEVEMENT.Build(buffer, index, length).Parse(out Achievement achievement).CheckPadding();
                    FacebookShareAchievement(achievement);
                    break;
                case ServerMessageType.FACEBOOK_SHARE_WIN:
                    if (FacebookShareWin == null) break;
                    ServerMessageParsers.FACEBOOK_SHARE_WIN.Build(buffer, index, length).Parse(out faction).CheckPadding();
                    FacebookShareWin(faction);
                    break;
                case ServerMessageType.DEATH_ANIMATIONS_CHOSEN:
                    if (DeathAnimationsChosen == null) break;
                    ServerMessageParsers.DEATH_ANIMATIONS_CHOSEN.Build(buffer, index, length).Parse(parser => parser.Parse((player2, deathAnimation2) => (player2, deathAnimation2), p => p.Parse(p2 => p2.CheckPadding())), out IEnumerable<(Player player, DeathAnimation deathAnimation)> chosenDeathAnimations).CheckPadding();
                    DeathAnimationsChosen(chosenDeathAnimations);
                    break;
                case ServerMessageType.FULL_MOON_NIGHT:
                    if (FullMoonNight == null) break;
                    ServerMessageParsers.FULL_MOON_NIGHT.Build(buffer, index, length).CheckPadding();
                    FullMoonNight();
                    break;
                case ServerMessageType.IDENTIFY:
                    if (Identify == null) break;
                    ServerMessageParsers.IDENTIFY.Build(buffer, index, length).Parse(out message).CheckPadding();
                    Identify(message);
                    break;
                case ServerMessageType.END_GAME_INFO:
                    if (EndGameInfo == null) break;
                    ServerMessageParsers.END_GAME_INFO.Build(buffer, index, length).Parse(out uint timeout).Parse(out gameMode).Parse(out faction).Parse(out bool won).Parse(out byte ratingChange).Parse(out byte mpGain).Parse(parser => parser.Parse((name2, rest) => (name2, rest.username2, rest.player2, rest.roles2), p => p.Parse((username2, rest) => (username2, rest.player2, rest.roles2), p2 => p2.Parse((player2, roles2) => (player2, roles2), p3 => p3.Parse(p4 => p4.Parse(p5 => p5.CheckPadding()), p4 => p4.Parse(out _).CheckPadding())))), out IEnumerable<(string name, string username, Player player, IEnumerable<Role> roles)> endGameInfo).CheckPadding();
                    EndGameInfo(timeout, gameMode, faction, won, ratingChange, mpGain, endGameInfo);
                    break;
                case ServerMessageType.END_GAME_CHAT_MESSAGE:
                    if (EndGameChatMessage == null) break;
                    ServerMessageParsers.END_GAME_CHAT_MESSAGE.Build(buffer, index, length).Parse(out player).Parse(out message).CheckPadding();
                    EndGameChatMessage(player, message);
                    break;
                case ServerMessageType.END_GAME_USER_UPDATE:
                    if (EndGameUserUpdate == null) break;
                    ServerMessageParsers.END_GAME_USER_UPDATE.Build(buffer, index, length).Parse(parser => parser.Parse((player2, left) => (player2, left), p => p.Parse(p2 => p2.CheckPadding())), out IEnumerable<(Player player, bool left)> userUpdates).CheckPadding();
                    EndGameUserUpdate(userUpdates);
                    break;
                case ServerMessageType.ROLE_LOTS_INFO_MESSAGE:
                    if (RoleLotsInfoMessage == null) break;
                    ServerMessageParsers.ROLE_LOTS_INFO_MESSAGE.Build(buffer, index, length).Parse(parser => parser.Parse((role2, rest) => (role2, rest.totalSlots, rest.yourSlots), p => p.Parse((totalSlots, yourSlots) => (totalSlots, yourSlots), p2 => p2.Parse(p3 => p3.CheckPadding()))), out IEnumerable<(Role role, uint totalSlots, uint yourSlots)> roleLots).CheckPadding();
                    RoleLotsInfoMessage(roleLots);
                    break;
                case ServerMessageType.EXTERNAL_PURCHASE:
                    if (ExternalPurchase == null) break;
                    ServerMessageParsers.EXTERNAL_PURCHASE.Build(buffer, index, length).Parse(out Uri uri).CheckPadding();
                    ExternalPurchase(uri);
                    break;
                case ServerMessageType.VAMPIRE_PROMOTION:
                    if (VampirePromotion == null) break;
                    ServerMessageParsers.VAMPIRE_PROMOTION.Build(buffer, index, length).CheckPadding();
                    VampirePromotion();
                    break;
                case ServerMessageType.OTHER_VAMPIRES:
                    if (OtherVampires == null) break;
                    ServerMessageParsers.OTHER_VAMPIRES.Build(buffer, index, length).Parse(parser => parser.Parse((player2, youngest2) => (player2, youngest2), p => p.Parse(p2 => p2.CheckPadding())), out IEnumerable<(Player player, bool youngest)> vampires).CheckPadding();
                    OtherVampires(vampires);
                    break;
                case ServerMessageType.ADD_VAMPIRE:
                    if (AddVampire == null) break;
                    ServerMessageParsers.ADD_VAMPIRE.Build(buffer, index, length).Parse(out player).Parse(out bool youngest).CheckPadding();
                    AddVampire(player, youngest);
                    break;
                case ServerMessageType.CAN_VAMPIRES_CONVERT:
                    if (CanVampiresConvert == null) break;
                    ServerMessageParsers.CAN_VAMPIRES_CONVERT.Build(buffer, index, length).Parse(out bool canConvert).CheckPadding();
                    CanVampiresConvert(canConvert);
                    break;
                case ServerMessageType.VAMPIRE_DIED:
                    if (VampireDied == null) break;
                    ServerMessageParsers.VAMPIRE_DIED.Build(buffer, index, length).Parse(out player).Parse(out optionalPlayer).CheckPadding();
                    VampireDied(player, optionalPlayer);
                    break;
                case ServerMessageType.VAMPIRE_HUNTER_PROMOTED:
                    if (VampireHunterPromoted == null) break;
                    ServerMessageParsers.VAMPIRE_HUNTER_PROMOTED.Build(buffer, index, length).CheckPadding();
                    VampireHunterPromoted();
                    break;
                case ServerMessageType.VAMPIRE_VISITED_MESSAGE:
                    if (VampireVisitedMessage == null) break;
                    ServerMessageParsers.VAMPIRE_VISITED_MESSAGE.Build(buffer, index, length).Parse(out player).CheckPadding();
                    VampireVisitedMessage(player);
                    break;
                case ServerMessageType.CHECK_USERNAME_RESULT:
                    if (CheckUsernameResult == null) break;
                    ServerMessageParsers.CHECK_USERNAME_RESULT.Build(buffer, index, length).Parse(out bool available).CheckPadding();
                    CheckUsernameResult(available);
                    break;
                case ServerMessageType.NAME_CHANGE_RESULT:
                    if (NameChangeResult == null) break;
                    ServerMessageParsers.NAME_CHANGE_RESULT.Build(buffer, index, length).Parse(out NameChangeResult nameChangeResult).CheckPadding();
                    NameChangeResult(nameChangeResult);
                    break;
                case ServerMessageType.ACCOUNT_STATE:
                    if (AccountState == null) break;
                    ServerMessageParsers.ACCOUNT_STATE.Build(buffer, index, length).Parse(out AccountState accountState).CheckPadding();
                    AccountState(accountState);
                    break;
                case ServerMessageType.PURCHASED_ACCOUNT_ITEMS:
                    if (PurchasedAccountItems == null) break;
                    ServerMessageParsers.PURCHASED_ACCOUNT_ITEMS.Build(buffer, index, length).Parse(parser => parser.Parse(p => p.CheckPadding()), out IEnumerable<AccountItem> accountItems).CheckPadding();
                    PurchasedAccountItems(accountItems);
                    break;
                case ServerMessageType.ACCOUNT_ITEM_CONSUMED:
                    if (AccountItemConsumed == null) break;
                    ServerMessageParsers.ACCOUNT_ITEM_CONSUMED.Build(buffer, index, length).Parse(out AccountItem accountItem).Parse(out uint consumed).Parse(out uint remaining).CheckPadding();
                    AccountItemConsumed(accountItem, consumed, remaining);
                    break;
                case ServerMessageType.TRANSPORTER_NOTIFICATION:
                    if (TransporterNotification == null) break;
                    ServerMessageParsers.TRANSPORTER_NOTIFICATION.Build(buffer, index, length).Parse(out player).Parse(out player3).CheckPadding();
                    TransporterNotification(player, player3);
                    break;
                case ServerMessageType.PRODUCT_PURCHASE_RESULT:
                    if (ProductPurchaseResult == null) break;
                    ServerMessageParsers.PRODUCT_PURCHASE_RESULT.Build(buffer, index, length).Parse(out ShopItem shopItem).Parse(out uint quantity).Parse(out PurchaseSource purchaseSource).Parse(out uint sourceData).Parse(out PurchaseResult purchaseResult).Parse(out ItemType itemType).Parse(parser => parser.Parse((itemType2, id) => (itemType2, id), p => p.Parse(p2 => p2.CheckPadding())), out IEnumerable<(ItemType itemType, uint id)> items).CheckPadding();
                    ProductPurchaseResult(shopItem, quantity, purchaseSource, sourceData, purchaseResult, itemType, items);
                    break;
                case ServerMessageType.UPDATE_FREE_CURRENCY:
                    if (UpdateFreeCurrency == null) break;
                    ServerMessageParsers.UPDATE_FREE_CURRENCY.Build(buffer, index, length).Parse(out meritPoints).CheckPadding();
                    UpdateFreeCurrency(meritPoints);
                    break;
                case ServerMessageType.ACTIVE_EVENTS:
                    if (ActiveEvents == null) break;
                    ServerMessageParsers.ACTIVE_EVENTS.Build(buffer, index, length).Parse(parser => parser.Parse((type, rest) => (type, rest.uiFilter, rest.startingSeconds, rest.endingSeconds), p => p.Parse((uiFilter, rest) => (uiFilter, rest.startingSeconds, rest.endingSeconds), p2 => p2.Parse((startingSeconds, endingSeconds) => (startingSeconds, endingSeconds), p3 => p3.Parse(p4 => p4.CheckPadding())))), out IEnumerable<(uint type, string uiFilter, uint startingSeconds, uint endingSeconds)> events).CheckPadding();
                    ActiveEvents(events);
                    break;
                case ServerMessageType.CAULDRON_STATUS:
                    if (CauldronStatus == null) break;
                    ServerMessageParsers.CAULDRON_STATUS.Build(buffer, index, length).Parse(out CauldronRewardType rewardType).Parse(out uint progress).Parse(out uint progressTarget).Parse(out bool complete).Parse(out uint freePotionCooldown).Parse(parser => parser.Parse(p => p.CheckPadding()), out IEnumerable<CauldronPotion> cauldronPotions).Parse(parser => parser.Parse((type, rest) => (type, rest.id, rest.amount), p => p.Parse((id, amount) => (id, amount), p2 => p2.Parse(p3 => p3.CheckPadding()))), out IEnumerable<(ItemType type, uint id, uint amount)> rewards).CheckPadding();
                    CauldronStatus(rewardType, progress, progressTarget, complete, freePotionCooldown, cauldronPotions, rewards);
                    break;
                case ServerMessageType.TAUNT_RESULT:
                    if (TauntResult == null) break;
                    ServerMessageParsers.TAUNT_RESULT.Build(buffer, index, length).Parse(out player).Parse(out TauntTargetType targetType).Parse(out Taunt taunt).Parse(out success).CheckPadding();
                    TauntResult(player, targetType, taunt, success);
                    break;
                case ServerMessageType.TAUNT_ACTIVATED:
                    if (TauntActivated == null) break;
                    ServerMessageParsers.TAUNT_ACTIVATED.Build(buffer, index, length).Parse(out player).Parse(out targetType).Parse(out taunt).CheckPadding();
                    TauntActivated(player, targetType, taunt);
                    break;
                case ServerMessageType.TAUNT_CONSUMED:
                    if (TauntConsumed == null) break;
                    ServerMessageParsers.TAUNT_CONSUMED.Build(buffer, index, length).Parse(out taunt).CheckPadding();
                    TauntConsumed(taunt);
                    break;
                case ServerMessageType.TRACKER_NIGHT_ABILITY:
                    if (TrackerNightAbility == null) break;
                    ServerMessageParsers.TRACKER_NIGHT_ABILITY.Build(buffer, index, length).Parse(out player).CheckPadding();
                    TrackerNightAbility(player);
                    break;
                case ServerMessageType.AMBUSHER_NIGHT_ABILITY:
                    if (AmbusherNightAbility == null) break;
                    ServerMessageParsers.AMBUSHER_NIGHT_ABILITY.Build(buffer, index, length).Parse(out player).CheckPadding();
                    AmbusherNightAbility(player);
                    break;
                case ServerMessageType.GUARDIAN_ANGEL_PROTECTION:
                    if (GuardianAngelProtection == null) break;
                    ServerMessageParsers.GUARDIAN_ANGEL_PROTECTION.Build(buffer, index, length).Parse(out player).CheckPadding();
                    GuardianAngelProtection(player);
                    break;
                case ServerMessageType.PIRATE_DUEL:
                    if (PirateDuel == null) break;
                    ServerMessageParsers.PIRATE_DUEL.Build(buffer, index, length).CheckPadding();
                    PirateDuel();
                    break;
                case ServerMessageType.DUEL_TARGET:
                    if (DuelTarget == null) break;
                    ServerMessageParsers.DUEL_TARGET.Build(buffer, index, length).Parse(out player).CheckPadding();
                    DuelTarget(player);
                    break;
                case ServerMessageType.POTION_MASTER_POTIONS:
                    if (PotionMasterPotions == null) break;
                    ServerMessageParsers.POTION_MASTER_POTIONS.Build(buffer, index, length).Parse(out byte healCooldown).Parse(out byte attackCooldown).Parse(out byte investigateCooldown).CheckPadding();
                    PotionMasterPotions(healCooldown, attackCooldown, investigateCooldown);
                    break;
                case ServerMessageType.HAS_NECRONOMICON:
                    if (HasNecronomicon == null) break;
                    byte nightsUntil = 0;
                    ServerMessageParsers.HAS_NECRONOMICON.Build(buffer, index, length).Parse(out bool noNecronomicon).Parse(!noNecronomicon, parser => parser, parser => parser.Parse(out nightsUntil)).CheckPadding();
                    HasNecronomicon(noNecronomicon ? (byte?)nightsUntil : null);
                    break;
                case ServerMessageType.OTHER_WITCHES:
                    if (OtherWitches == null) break;
                    ServerMessageParsers.OTHER_WITCHES.Build(buffer, index, length).Parse(parser => parser.Parse((player2, role2) => (player2, role2), p => p.Parse(p2 => p2.CheckPadding())), out teammates).CheckPadding();
                    OtherWitches(teammates);
                    break;
                case ServerMessageType.PSYCHIC_NIGHT_ABILITY:
                    if (PsychicNightAbility == null) break;
                    player4 = default;
                    ServerMessageParsers.PSYCHIC_NIGHT_ABILITY.Build(buffer, index, length).Parse(out bool isEvil).Parse(out player).Parse(out player3).Parse(!isEvil, parser => parser, parser => parser.Parse(out player4)).CheckPadding();
                    PsychicNightAbility(player, player3, isEvil ? (Player?)player4 : null);
                    break;
                case ServerMessageType.TRAPPER_NIGHT_ABILITY:
                    if (TrapperNightAbility == null) break;
                    ServerMessageParsers.TRAPPER_NIGHT_ABILITY.Build(buffer, index, length).Parse(out role).CheckPadding();
                    TrapperNightAbility(role);
                    break;
                case ServerMessageType.TRAPPER_TRAP_STATUS:
                    if (TrapperTrapStatus == null) break;
                    ServerMessageParsers.TRAPPER_TRAP_STATUS.Build(buffer, index, length).Parse(out TrapStatus trapStatus).CheckPadding();
                    TrapperTrapStatus(trapStatus);
                    break;
                case ServerMessageType.PESTILENCE_CONVERSION:
                    if (PestilenceConversion == null) break;
                    ServerMessageParsers.PESTILENCE_CONVERSION.Build(buffer, index, length).CheckPadding();
                    PestilenceConversion();
                    break;
                case ServerMessageType.JUGGERNAUT_KILL_COUNT:
                    if (JuggernautKillCount == null) break;
                    ServerMessageParsers.JUGGERNAUT_KILL_COUNT.Build(buffer, index, length).Parse(out byte killCount).CheckPadding();
                    JuggernautKillCount(killCount);
                    break;
                case ServerMessageType.COVEN_GOT_NECRONOMICON:
                    if (CovenGotNecronomicon == null) break;
                    player3 = default;
                    ServerMessageParsers.COVEN_GOT_NECRONOMICON.Build(buffer, index, length).Parse(out bool newOwner).Parse(out player).Parse(!newOwner, parser => parser, parser => parser.Parse(out player3)).CheckPadding();
                    CovenGotNecronomicon(player, newOwner ? (Player?)player3 : null);
                    break;
                case ServerMessageType.GUARDIAN_ANGEL_PROMOTED:
                    if (GuardianAngelPromoted == null) break;
                    ServerMessageParsers.GUARDIAN_ANGEL_PROMOTED.Build(buffer, index, length).CheckPadding();
                    GuardianAngelPromoted();
                    break;
                case ServerMessageType.VIP_TARGET:
                    if (VIPTarget == null) break;
                    ServerMessageParsers.VIP_TARGET.Build(buffer, index, length).Parse(out player).CheckPadding();
                    VIPTarget(player);
                    break;
                case ServerMessageType.PIRATE_DUEL_OUTCOME:
                    if (PirateDuelOutcome == null) break;
                    ServerMessageParsers.PIRATE_DUEL_OUTCOME.Build(buffer, index, length).Parse(out DuelAttack duelAttack).Parse(out DuelDefense duelDefense).CheckPadding();
                    PirateDuelOutcome(duelAttack, duelDefense);
                    break;
                case ServerMessageType.HOST_SET_PARTY_CONFIG_RESULT:
                    if (HostSetPartyConfigResult == null) break;
                    ServerMessageParsers.HOST_SET_PARTY_CONFIG_RESULT.Build(buffer, index, length).Parse(out brand).Parse(out gameMode).Parse(out SetConfigResult setConfigResult).CheckPadding();
                    HostSetPartyConfigResult(brand, gameMode, setConfigResult);
                    break;
                case ServerMessageType.ACTIVE_GAME_MODES:
                    if (ActiveGameModes == null) break;
                    ServerMessageParsers.ACTIVE_GAME_MODES.Build(buffer, index, length).Parse(parser => parser.Parse(p => p.CheckPadding()), out IEnumerable<GameMode> gameModes).CheckPadding();
                    ActiveGameModes(gameModes);
                    break;
                case ServerMessageType.ACCOUNT_FLAGS:
                    if (AccountFlags == null) break;
                    ServerMessageParsers.ACCOUNT_FLAGS.Build(buffer, index, length).Parse(out AccountFlags accountFlags).CheckPadding();
                    AccountFlags(accountFlags);
                    break;
                case ServerMessageType.ZOMBIE_ROTTED:
                    if (ZombieRotted == null) break;
                    ServerMessageParsers.ZOMBIE_ROTTED.Build(buffer, index, length).Parse(out player).CheckPadding();
                    ZombieRotted(player);
                    break;
                case ServerMessageType.LOVER_TARGET:
                    if (LoverTarget == null) break;
                    ServerMessageParsers.LOVER_TARGET.Build(buffer, index, length).Parse(out player).CheckPadding();
                    LoverTarget(player);
                    break;
                case ServerMessageType.PLAGUE_SPREAD:
                    if (PlagueSpread == null) break;
                    ServerMessageParsers.PLAGUE_SPREAD.Build(buffer, index, length).Parse(out player).CheckPadding();
                    PlagueSpread(player);
                    break;
                case ServerMessageType.RIVAL_TARGET:
                    if (RivalTarget == null) break;
                    ServerMessageParsers.RIVAL_TARGET.Build(buffer, index, length).Parse(out player).CheckPadding();
                    RivalTarget(player);
                    break;
                case ServerMessageType.RANKED_INFO:
                    if (RankedInfo == null) break;
                    ServerMessageParsers.RANKED_INFO.Build(buffer, index, length).Parse(out gameMode).Parse(out uint practiceGamesPlayed).Parse(out uint careerWins).Parse(out uint careerLosses).Parse(out uint careerDraws).Parse(out uint careerLeaves).Parse(out uint careerHighRating).Parse(out uint seasonNumber).Parse(out bool offseason).Parse(out uint placementGamesNeeded).Parse(out uint seasonWins).Parse(out uint seasonLosses).Parse(out uint seasonDraws).Parse(out uint seasonLeaves).Parse(out uint seasonHighRating).Parse(out uint seasonRating).CheckPadding();
                    RankedInfo(gameMode, practiceGamesPlayed, careerWins, careerLosses, careerDraws, careerLeaves, careerHighRating, seasonNumber, offseason, placementGamesNeeded, seasonWins, seasonLosses, seasonDraws, seasonLeaves, seasonHighRating, seasonRating);
                    break;
                case ServerMessageType.JAILOR_DEATH_NOTE:
                    if (JailorDeathNote == null) break;
                    ServerMessageParsers.JAILOR_DEATH_NOTE.Build(buffer, index, length).Parse(out player).Parse(out longTimer).Parse(out ExecuteReason executeReason).CheckPadding();
                    JailorDeathNote(player, longTimer, executeReason);
                    break;
                case ServerMessageType.DISCONNECTED:
                    if (Disconnected == null) break;
                    ServerMessageParsers.DISCONNECTED.Build(buffer, index, length).Parse(out DisconnectReason disconnectReason).CheckPadding();
                    Disconnected(disconnectReason);
                    break;
                case ServerMessageType.SPY_NIGHT_INFO:
                    if (SpyNightInfo == null) break;
                    ServerMessageParsers.SPY_NIGHT_INFO.Build(buffer, index, length).Parse(parser => parser.Parse(p => p.CheckPadding()), out IEnumerable<LocalizationTable> tableMessages).CheckPadding();
                    SpyNightInfo(tableMessages);
                    break;
                case ServerMessageType.SERVER_FLAGS:
                    if (ServerFlags == null) break;
                    ServerMessageParsers.SERVER_FLAGS.Build(buffer, index, length).Parse(parser => parser.Parse(p => p.CheckPadding()), out IEnumerable<bool> serverFlags).CheckPadding();
                    ServerFlags(serverFlags);
                    break;
            }
        }
    }
}
