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
        public static readonly ParserBuilder<Parser<bool, Parser<GameModeID, RootParser>>, Writer<bool, Writer<GameModeID, RootWriter>>> CREATE_LOBBY = Parsers.ROOT.After(Converters.Byte<GameModeID>()).After(Converters.BOOLEAN1);
        public static readonly RootBuilder SET_HOST = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<bool, Parser<bool, Parser<string, Parser<PlayerID, Parser<LobbyIconID, RootParser>>>>>, Writer<bool, Writer<bool, Writer<string, Writer<PlayerID, Writer<LobbyIconID, RootWriter>>>>>> USER_JOINED_GAME = Parsers.ROOT.After(Converters.Byte<LobbyIconID>()).After(Converters.Byte<PlayerID>(), 0x2A).After(Converters.STRING).After(Converters.BOOLEAN1).After(Converters.BOOLEAN1);
        public static readonly ParserBuilder<Parser<bool, Parser<bool, Parser<PlayerID, RootParser>>>, Writer<bool, Writer<bool, Writer<PlayerID, RootWriter>>>> USER_LEFT_GAME = Parsers.ROOT.After(Converters.Byte<PlayerID>()).After(Converters.BOOLEAN1).After(Converters.BOOLEAN1);
        public static readonly ParserBuilder<ConditionalParser<Parser<PlayerID, Parser<string, RootParser>>, Parser<PlayerID, Parser<string, RootParser>>>, ConditionalWriter<Writer<PlayerID, Writer<string, RootWriter>>, Writer<PlayerID, Writer<string, RootWriter>>>> CHAT_BOX_MESSAGE = Parsers.PLAYER_STRING.Condition(Parsers.STRING.After(Converters.Byte<PlayerID>(), 0xFF));
        public static readonly ParserBuilder<Parser<CatalogID, RootParser>, Writer<CatalogID, RootWriter>> HOST_CLICKED_ON_CATALOG = Parsers.CATALOG;
        public static readonly ParserBuilder<Parser<byte, Parser<byte, RootParser>>, Writer<byte, Writer<byte, RootWriter>>> HOST_CLICKED_ON_POSSIBLE_ROLES = Parsers.BYTE2;
        public static readonly ParserBuilder<Parser<RoleID, RootParser>, Writer<RoleID, RootWriter>> HOST_CLICKED_ON_ADD_BUTTON = Parsers.ROLE;
        public static readonly ParserBuilder<Parser<byte, RootParser>, Writer<byte, RootWriter>> HOST_CLICKED_ON_REMOVE_BUTTON = Parsers.BYTE;
        public static readonly RootBuilder HOST_CLICKED_ON_START_BUTTON = Parsers.ROOT;
        public static readonly RootBuilder CANCEL_START_COOLDOWN = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> ASSIGN_NEW_HOST = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<byte, RootParser>, Writer<byte, RootWriter>> VOTED_TO_REPICK_HOST = Parsers.BYTE;
        public static readonly RootBuilder NO_LONGER_HOST = Parsers.ROOT;
        public static readonly RootBuilder DO_NOT_SPAM = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<uint, Parser<uint, RootParser>>, Writer<uint, Writer<uint, RootWriter>>> HOW_MANY_PLAYERS_AND_GAMES = Parsers.ROOT.After(Converters.UInt<uint>(), 0x2A).After(Converters.UInt<uint>());
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> SYSTEM_MESSAGE = Parsers.STRING;
        public static readonly ParserBuilder<Parser<LocalizationTableID, RootParser>, Writer<LocalizationTableID, RootWriter>> STRING_TABLE_MESSAGE = Parsers.LOCALIZATION;
        public static readonly ParserBuilder<RepeatParser<Parser<string, Parser<uint, Parser<OnlineStatus, Parser<bool, RootParser>>>>, RootParser>, RepeatWriter<Writer<string, Writer<uint, Writer<OnlineStatus, Writer<bool, RootWriter>>>>, RootWriter>> FRIEND_LIST = Parsers.ROOT.Repeat(1, Parsers.STRING_UINT_ONLINE_BOOLEAN_COMMA);
        public static readonly ParserBuilder<RepeatParser<Parser<string, Parser<uint, RootParser>>, RootParser>, RepeatWriter<Writer<string, Writer<uint, RootWriter>>, RootWriter>> FRIEND_REQUEST_NOTIFICATIONS = Parsers.ROOT.Repeat(1, Parsers.ROOT_ASTERISK.After(Converters.UInt<uint>(), 0x2C).After(Converters.STRING));
        public static readonly ParserBuilder<Parser<bool, RootParser>, Writer<bool, RootWriter>> ADD_FRIEND_REQUEST_RESPONSE = Parsers.BOOLEAN;
        public static readonly ParserBuilder<Parser<uint, Parser<OnlineStatus, Parser<bool, RootParser>>>, Writer<uint, Writer<OnlineStatus, Writer<bool, RootWriter>>>> CONFIRM_FRIEND_REQUEST = Parsers.UINT_ONLINE_BOOLEAN_COMMA;
        public static readonly ParserBuilder<Parser<uint, RootParser>, Writer<uint, RootWriter>> SUCCESSFULLY_REMOVED_FRIEND = Parsers.UINT;
        public static readonly RootBuilder SUCCESSFULLY_DECLINED_FRIEND_REQUEST = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<uint, Parser<OnlineStatus, Parser<bool, RootParser>>>, Writer<uint, Writer<OnlineStatus, Writer<bool, RootWriter>>>> FRIEND_UPDATE = Parsers.UINT_ONLINE_BOOLEAN_COMMA;
        public static readonly ParserBuilder<Parser<uint, Parser<bool, Parser<string, RootParser>>>, Writer<uint, Writer<bool, Writer<string, RootWriter>>>> FRIEND_MESSAGE = Parsers.ROOT.After(Converters.STRING, 0x2A).After(Converters.BOOLEAN2, 0x2A).After(Converters.UInt<uint>());
        public static readonly ParserBuilder<Parser<string, Parser<uint, Parser<uint, RootParser>>>, Writer<string, Writer<uint, Writer<uint, RootWriter>>>> USER_INFORMATION = Parsers.ROOT.After(Converters.UInt<uint>(), 0x2A).After(Converters.UInt<uint>(), 0x2A).After(Converters.STRING);
        public static readonly ParserBuilder<Parser<BrandID, RootParser>, Writer<BrandID, RootWriter>> CREATE_PARTY_LOBBY = Parsers.BRAND;
        public static readonly ParserBuilder<Parser<string, Parser<FailedInvitationStatus, RootParser>>, Writer<string, Writer<FailedInvitationStatus, RootWriter>>> PARTY_INVITE_FAILED = Parsers.ROOT.After(Converters.UInt<FailedInvitationStatus>(), 0x2A).After(Converters.STRING);
        public static readonly ParserBuilder<Parser<uint, Parser<string, RootParser>>, Writer<uint, Writer<string, RootWriter>>> PARTY_INVITE_NOTIFICATION = Parsers.ROOT.After(Converters.STRING, 0x2A).After(Converters.UInt<uint>());
        public static readonly ParserBuilder<Parser<AcceptInvitationResult, RootParser>, Writer<AcceptInvitationResult, RootWriter>> ACCEPTED_PARTY_INVITE = Parsers.ROOT.After(Converters.Byte<AcceptInvitationResult>());
        public static readonly ParserBuilder<Parser<string, Parser<PendingInvitationStatus, RootParser>>, Writer<string, Writer<PendingInvitationStatus, RootWriter>>> PENDING_PARTY_INVITE_STATUS = Parsers.ROOT.After(Converters.Byte<PendingInvitationStatus>(), 0x2A).After(Converters.STRING);
        public static readonly RootBuilder SUCCESSFULLY_LEFT_PARTY = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<string, Parser<string, RootParser>>, Writer<string, Writer<string, RootWriter>>> PARTY_CHAT = Parsers.STRING2_ASTERISK;
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> PARTY_MEMBER_LEFT = Parsers.STRING;
        public static readonly ParserBuilder<Parser<bool, Parser<bool, Parser<bool, Parser<bool, Parser<bool, Parser<bool, Parser<byte, Parser<byte, Parser<LanguageID, Parser<byte, Parser<TipBehaviourID, RootParser>>>>>>>>>>>, Writer<bool, Writer<bool, Writer<bool, Writer<bool, Writer<bool, Writer<bool, Writer<byte, Writer<byte, Writer<LanguageID, Writer<byte, Writer<TipBehaviourID, RootWriter>>>>>>>>>>>> SETTINGS_INFORMATION = Parsers.ROOT.After(Converters.Byte<TipBehaviourID>()).After(Converters.Byte<byte>()).After(Converters.Byte<LanguageID>()).After(Converters.Byte<byte>()).After(Converters.Byte<byte>()).After(Converters.BOOLEAN1).After(Converters.BOOLEAN1).After(Converters.BOOLEAN1).After(Converters.BOOLEAN1).After(Converters.BOOLEAN1).After(Converters.BOOLEAN1);
        public static readonly ParserBuilder<Parser<string, Parser<uint, Parser<OnlineStatus, Parser<bool, RootParser>>>>, Writer<string, Writer<uint, Writer<OnlineStatus, Writer<bool, RootWriter>>>>> ADD_FRIEND = Parsers.STRING_UINT_ONLINE_BOOLEAN_COMMA;
        public static readonly RootBuilder FORCED_LOGOUT = Parsers.ROOT;
        public static readonly RootBuilder RETURN_TO_HOME_PAGE = Parsers.ROOT;
        public static readonly RootBuilder SHOP_PURCHASE_SUCCESS = Parsers.ROOT;
        public static readonly ParserBuilder<RepeatParser<Parser<CharacterID, RootParser>, RootParser>, RepeatWriter<Writer<CharacterID, RootWriter>, RootWriter>> PURCHASED_CHARACTERS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<CharacterID>()));
        public static readonly ParserBuilder<RepeatParser<Parser<HouseID, RootParser>, RootParser>, RepeatWriter<Writer<HouseID, RootWriter>, RootWriter>> PURCHASED_HOUSES = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<HouseID>()));
        public static readonly ParserBuilder<RepeatParser<Parser<BackgroundID, RootParser>, RootParser>, RepeatWriter<Writer<BackgroundID, RootWriter>, RootWriter>> PURCHASED_BACKGROUNDS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<BackgroundID>()));
        public static readonly ParserBuilder<Parser<CharacterID, Parser<HouseID, Parser<BackgroundID, Parser<PetID?, Parser<LobbyIconID, Parser<DeathAnimationID, Parser<ScrollID?, Parser<ScrollID?, Parser<ScrollID?, Parser<string, RootParser>>>>>>>>>>, Writer<CharacterID, Writer<HouseID, Writer<BackgroundID, Writer<PetID?, Writer<LobbyIconID, Writer<DeathAnimationID, Writer<ScrollID?, Writer<ScrollID?, Writer<ScrollID?, Writer<string, RootWriter>>>>>>>>>>> SELECTION_SETTINGS = Parsers.ROOT.After(Converters.STRING, 0x2C).After(Converters.Safe(Converters.UInt<ScrollID>(), "-2"), 0x2C).After(Converters.Safe(Converters.UInt<ScrollID>(), "-2"), 0x2C).After(Converters.Safe(Converters.UInt<ScrollID>(), "-2"), 0x2C).After(Converters.UInt<DeathAnimationID>(), 0x2C).After(Converters.UInt<LobbyIconID>(), 0x2C).After(Converters.Safe(Converters.UInt<PetID>(), "-2"), 0x2C).After(Converters.UInt<BackgroundID>(), 0x2C).After(Converters.UInt<HouseID>(), 0x2C).After(Converters.UInt<CharacterID>());
        public static readonly ParserBuilder<Parser<RedeemCodeResult, ConditionalParser<Parser<RedeemCodeRewardID, Parser<string, RootParser>>, RootParser>>, Writer<RedeemCodeResult, ConditionalWriter<Writer<RedeemCodeRewardID, Writer<string, RootWriter>>, RootWriter>>> REDEEM_CODE_MESSAGE = Parsers.STRING.After(Converters.UInt<RedeemCodeRewardID>()).Condition(Parsers.ROOT).After(Converters.Byte<RedeemCodeResult>());
        public static readonly ParserBuilder<Parser<uint, RootParser>, Writer<uint, RootWriter>> UPDATE_PAID_CURRENCY = Parsers.UINT;
        public static readonly ParserBuilder<RepeatParser<Parser<PackID, RootParser>, RootParser>, RepeatWriter<Writer<PackID, RootWriter>, RootWriter>> PURCHASED_PACKS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<PackID>()));
        public static readonly ParserBuilder<RepeatParser<Parser<PetID, RootParser>, RootParser>, RepeatWriter<Writer<PetID, RootWriter>, RootWriter>> PURCHASED_PETS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<PetID>()));
        public static readonly ParserBuilder<Parser<uint, RootParser>, Writer<uint, RootWriter>> SET_LAST_BONUS_WIN_TIME = Parsers.UINT;
        public static readonly ParserBuilder<RepeatParser<Parser<AchievementID, RootParser>, RootParser>, RepeatWriter<Writer<AchievementID, RootWriter>, RootWriter>> EARNED_ACHIEVEMENTS_52 = Parsers.REPEAT_ACHIEVEMENT;
        public static readonly ParserBuilder<RepeatParser<Parser<LobbyIconID, RootParser>, RootParser>, RepeatWriter<Writer<LobbyIconID, RootWriter>, RootWriter>> PURCHASED_LOBBY_ICONS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<LobbyIconID>()));
        public static readonly ParserBuilder<RepeatParser<Parser<DeathAnimationID, RootParser>, RootParser>, RepeatWriter<Writer<DeathAnimationID, RootWriter>, RootWriter>> PURCHASED_DEATH_ANIMATIONS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<DeathAnimationID>()));
        public static readonly RootBuilder FACEBOOK_INVITE_FRIENDS = Parsers.ROOT;
        public static readonly ParserBuilder<RepeatParser<Parser<ScrollID, Parser<uint, RootParser>>, RootParser>, RepeatWriter<Writer<ScrollID, Writer<uint, RootWriter>>, RootWriter>> PURCHASED_SCROLLS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<uint>(), 0x2A).After(Converters.UInt<ScrollID>()));
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
        public static readonly ParserBuilder<Parser<ModeratorMessageID, Parser<string, RootParser>>, Writer<ModeratorMessageID, Writer<string, RootWriter>>> MODERATOR_MESSAGE = Parsers.STRING.After(Converters.Byte<ModeratorMessageID>());
        public static readonly ParserBuilder<Parser<ReferralRewardID, ConditionalParser<Parser<uint, RootParser>, RootParser>>, Writer<ReferralRewardID, ConditionalWriter<Writer<uint, RootWriter>, RootWriter>>> REFER_A_FRIEND_UPDATE = Parsers.UINT.Condition(Parsers.ROOT).After(Converters.Byte<ReferralRewardID>());
        public static readonly ParserBuilder<RepeatParser<Parser<uint, RootParser>, RootParser>, RepeatWriter<Writer<uint, RootWriter>, RootWriter>> PLAYER_STATISTICS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<uint>()));
        public static readonly ParserBuilder<Parser<ScrollID, RootParser>, Writer<ScrollID, RootWriter>> SCROLL_CONSUMED = Parsers.ROOT.After(Converters.UInt<ScrollID>());
        public static readonly ParserBuilder<Parser<AdViewResult, ConditionalParser<ConditionalParser<Parser<byte, RootParser>, Parser<uint, RootParser>>, RootParser>>, Writer<AdViewResult, ConditionalWriter<ConditionalWriter<Writer<byte, RootWriter>, Writer<uint, RootWriter>>, RootWriter>>> AD_VIEW_RESPONSE = Parsers.BYTE.Condition(Parsers.UINT).Condition(Parsers.ROOT).After(Converters.Byte<AdViewResult>());
        public static readonly RootBuilder USER_JOINING_LOBBY_TOO_QUICKLY = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<PromotionID, Parser<uint, Parser<double, Parser<uint, RootParser>>>>, Writer<PromotionID, Writer<uint, Writer<double, Writer<uint, RootWriter>>>>> PROMOTION_POPUP = Parsers.ROOT.After(Converters.UInt<uint>(), 0x2C).After(Converters.DOUBLE, 0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<PromotionID>());
        public static readonly RootBuilder KICKSTARTER_SHARE = Parsers.ROOT;
        public static readonly ParserBuilder<RepeatParser<Parser<TutorialTipID, RootParser>, RootParser>, RepeatWriter<Writer<TutorialTipID, RootWriter>, RootWriter>> TUTORIAL_PROGRESS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<TutorialTipID>()));
        public static readonly ParserBuilder<RepeatParser<Parser<TauntID, Parser<uint, RootParser>>, RootParser>, RepeatWriter<Writer<TauntID, Writer<uint, RootWriter>>, RootWriter>> PURCHASED_TAUNTS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<uint>(), 0x2A).After(Converters.UInt<TauntID>()));
        public static readonly ParserBuilder<RepeatParser<Parser<CurrencyID, Parser<uint, RootParser>>, RootParser>, RepeatWriter<Writer<CurrencyID, Writer<uint, RootWriter>>, RootWriter>> CURRENCY_MULTIPLIER = Parsers.ROOT.Repeat(1, new RootBuilder(0x2A).After(Converters.UInt<uint>()).After(Converters.UInt<CurrencyID>()));
        public static readonly ParserBuilder<Parser<byte, Parser<GameModeID, RootParser>>, Writer<byte, Writer<GameModeID, RootWriter>>> PICK_NAMES = Parsers.ROOT.After(Converters.Byte<GameModeID>()).After(Converters.Byte<byte>());
        public static readonly ParserBuilder<Parser<PlayerID, Parser<string, RootParser>>, Writer<PlayerID, Writer<string, RootWriter>>> NAMES_AND_POSITIONS_OF_USERS = Parsers.PLAYER_STRING;
        public static readonly ParserBuilder<Parser<RoleID, Parser<PlayerID, Parser<Option<PlayerID>, RootParser>>>, Writer<RoleID, Writer<PlayerID, Writer<Option<PlayerID>, RootWriter>>>> ROLE_AND_POSITION = Parsers.ROOT.After(Converters.Optional(Converters.Byte<PlayerID>())).After(Converters.Byte<PlayerID>()).After(Converters.Byte<RoleID>());
        public static readonly RootBuilder START_NIGHT = Parsers.ROOT;
        public static readonly RootBuilder START_DAY = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<PlayerID, Parser<RoleID, Parser<bool, RepeatParser<Parser<DeathCauseID, RootParser>, RootParser>>>>, Writer<PlayerID, Writer<RoleID, Writer<bool, RepeatWriter<Writer<DeathCauseID, RootWriter>, RootWriter>>>>> WHO_DIED_AND_HOW = Parsers.ROOT.Repeat(0, Parsers.ROOT.After(Converters.Byte<DeathCauseID>())).After(Converters.BOOLEAN1).After(Converters.Byte<RoleID>()).After(Converters.Byte<PlayerID>());
        public static readonly RootBuilder START_DISCUSSION = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<bool, RootParser>, Writer<bool, RootWriter>> START_VOTING = Parsers.ROOT.After(Converters.Boolean(Converters.Byte<byte>(30u)));
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> START_DEFENSE_TRANSITION = Parsers.PLAYER;
        public static readonly RootBuilder START_JUDGEMENT = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<byte, Parser<byte, RootParser>>, Writer<byte, Writer<byte, RootWriter>>> TRIAL_FOUND_GUILTY = Parsers.BYTE2;
        public static readonly ParserBuilder<Parser<byte, Parser<byte, RootParser>>, Writer<byte, Writer<byte, RootWriter>>> TRIAL_FOUND_NOT_GUILTY = Parsers.BYTE2;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> LOOKOUT_NIGHT_ABILITY_MESSAGE = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<PlayerID, Parser<PlayerID, Parser<byte, RootParser>>>, Writer<PlayerID, Writer<PlayerID, Writer<byte, RootWriter>>>> USER_VOTED = Parsers.PLAYER2_RAWBYTE;
        public static readonly ParserBuilder<Parser<PlayerID, Parser<PlayerID, Parser<byte, RootParser>>>, Writer<PlayerID, Writer<PlayerID, Writer<byte, RootWriter>>>> USER_CANCELED_VOTE = Parsers.PLAYER2_RAWBYTE;
        public static readonly ParserBuilder<Parser<PlayerID, Parser<PlayerID, Parser<PlayerID, Parser<byte, RootParser>>>>, Writer<PlayerID, Writer<PlayerID, Writer<PlayerID, Writer<byte, RootWriter>>>>> USER_CHANGED_VOTE = Parsers.ROOT.After(Converters.Byte<byte>(0u)).After(Converters.Byte<PlayerID>()).After(Converters.Byte<PlayerID>()).After(Converters.Byte<PlayerID>());
        public static readonly ParserBuilder<Parser<bool, RootParser>, Writer<bool, RootWriter>> USER_DIED = Parsers.BOOLEAN;
        public static readonly ParserBuilder<Parser<PlayerID, Parser<RoleID, RootParser>>, Writer<PlayerID, Writer<RoleID, RootWriter>>> RESURRECTION = Parsers.PLAYER_ROLE;
        public static readonly ParserBuilder<RepeatParser<Parser<RoleID, RootParser>, RootParser>, RepeatWriter<Writer<RoleID, RootWriter>, RootWriter>> TELL_ROLE_LIST = Parsers.ROOT.Repeat(0, Parsers.ROLE);
        public static readonly ParserBuilder<Parser<LocalizationTableID, Parser<PlayerID, Parser<string, RootParser>>>, Writer<LocalizationTableID, Writer<PlayerID, Writer<string, RootWriter>>>> USER_CHOSEN_NAME = Parsers.ROOT.After(Converters.STRING).After(Converters.Byte<PlayerID>()).After(Converters.Byte<LocalizationTableID>());
        public static readonly ParserBuilder<RepeatParser<Parser<PlayerID, Parser<RoleID, RootParser>>, RootParser>, RepeatWriter<Writer<PlayerID, Writer<RoleID, RootWriter>>, RootWriter>> OTHER_MAFIA = Parsers.REPEAT_PLAYER_ROLE;
        public static readonly ParserBuilder<Parser<RoleID, RootParser>, Writer<RoleID, RootWriter>> TELL_TOWN_AMNESIAC_CHANGED_ROLE = Parsers.ROLE;
        public static readonly ParserBuilder<Parser<RoleID, Parser<Option<PlayerID>, RootParser>>, Writer<RoleID, Writer<Option<PlayerID>, RootWriter>>> AMNESIAC_CHANGED_ROLE = Parsers.ROOT.After(Converters.Optional(Converters.Byte<PlayerID>())).After(Converters.Byte<RoleID>());
        public static readonly RootBuilder BROUGHT_BACK_TO_LIFE = Parsers.ROOT;
        public static readonly RootBuilder START_FIRST_DAY = Parsers.ROOT;
        public static readonly RootBuilder BEING_JAILED = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<PlayerID, Parser<bool, Parser<bool, RootParser>>>, Writer<PlayerID, Writer<bool, Writer<bool, RootWriter>>>> JAILED_TARGET = Parsers.ROOT.After(Converters.BOOLEAN1).After(Converters.BOOLEAN1).After(Converters.Byte<PlayerID>());
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> USER_JUDGEMENT_VOTED = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> USER_CHANGED_JUDGEMENT_VOTE = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> USER_CANCELED_JUDGEMENT_VOTE = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<PlayerID, Parser<JudgementVoteID, RootParser>>, Writer<PlayerID, Writer<JudgementVoteID, RootWriter>>> TELL_JUDGEMENT_VOTES = Parsers.ROOT.After(Converters.Byte<JudgementVoteID>()).After(Converters.Byte<PlayerID>());
        public static readonly RootBuilder EXECUTIONER_COMPLETED_GOAL = Parsers.ROOT;
        public static readonly RootBuilder JESTER_COMPLETED_GOAL = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> MAYOR_REVEALED = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> MAYOR_REVEALED_AND_ALREADY_VOTED = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> DISGUISER_STOLE_YOUR_IDENTITY = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> DISGUISER_CHANGED_IDENTITY = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<PlayerID, Parser<PlayerID, RootParser>>, Writer<PlayerID, Writer<PlayerID, RootWriter>>> DISGUISER_CHANGED_UPDATE_MAFIA = Parsers.PLAYER2;
        public static readonly RootBuilder MEDIUM_IS_TALKING_TO_US = Parsers.ROOT;
        public static readonly RootBuilder MEDIUM_COMMUNICATING = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<PlayerID, Parser<bool, ConditionalParser<Parser<string, RootParser>, RootParser>>>, Writer<PlayerID, Writer<bool, ConditionalWriter<Writer<string, RootWriter>, RootWriter>>>> TELL_LAST_WILL = Parsers.ROOT.After(Converters.STRING).Condition(Parsers.ROOT).After(Converters.BOOLEAN1).After(Converters.Byte<PlayerID>());
        public static readonly ParserBuilder<Parser<byte, RootParser>, Writer<byte, RootWriter>> HOW_MANY_ABILITIES_LEFT = Parsers.BYTE;
        public static readonly ParserBuilder<Parser<PlayerID, Parser<RoleID, Parser<PlayerID, Parser<byte, Parser<Option<byte>, Parser<Option<byte>, RootParser>>>>>>, Writer<PlayerID, Writer<RoleID, Writer<PlayerID, Writer<byte, Writer<Option<byte>, Writer<Option<byte>, RootWriter>>>>>>> MAFIA_TARGETING = Parsers.ROOT.After(Converters.Optional(Converters.Byte<byte>())).After(Converters.Optional(Converters.Byte<byte>())).After(Converters.Byte<byte>()).After(Converters.Byte<PlayerID>()).After(Converters.Byte<RoleID>()).After(Converters.Byte<PlayerID>());
        public static readonly ParserBuilder<Parser<RoleID, RootParser>, Writer<RoleID, RootWriter>> TELL_JANITOR_TARGETS_ROLE = Parsers.ROLE;
        public static readonly ParserBuilder<Parser<PlayerID, Parser<string, RootParser>>, Writer<PlayerID, Writer<string, RootWriter>>> TELL_JANITOR_TARGETS_WILL = Parsers.PLAYER_STRING;
        public static readonly ParserBuilder<Parser<FactionID, RepeatParser<Parser<PlayerID, RootParser>, RootParser>>, Writer<FactionID, RepeatWriter<Writer<PlayerID, RootWriter>, RootWriter>>> SOMEONE_HAS_WON = Parsers.ROOT.Repeat(0, Parsers.PLAYER).After(Converters.Byte<FactionID>());
        public static readonly RootBuilder MAFIOSO_PROMOTED_TO_GODFATHER = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> MAFIOSO_PROMOTED_TO_GODFATHER_UPDATE_MAFIA = Parsers.PLAYER;
        public static readonly RootBuilder MAFIA_PROMOTED_TO_MAFIOSO;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> TELL_MAFIA_ABOUT_MAFIOSO_PROMOTION = Parsers.PLAYER;
        public static readonly RootBuilder EXECUTIONER_CONVERTED_TO_JESTER = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<PlayerID, Parser<RoleID, RootParser>>, Writer<PlayerID, Writer<RoleID, RootWriter>>> AMNESIAC_BECAME_MAFIA_OR_WITCH = Parsers.PLAYER_ROLE;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> USER_DISCONNECTED = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> MAFIA_WAS_JAILED = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<InvalidNameStatus, RootParser>, Writer<InvalidNameStatus, RootWriter>> INVALID_NAME_MESSAGE = Parsers.ROOT.After(Converters.Byte<InvalidNameStatus>());
        public static readonly RootBuilder START_NIGHT_TRANSITION = Parsers.ROOT;
        public static readonly ParserBuilder<RepeatParser<Parser<PlayerID, RootParser>, RootParser>, RepeatWriter<Writer<PlayerID, RootWriter>, RootWriter>> START_DAY_TRANSITION = Parsers.REPEAT_PLAYER;
        public static readonly RootBuilder LYNCH_USER = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<PlayerID, Parser<bool, Parser<string, RootParser>>>, Writer<PlayerID, Writer<bool, Writer<string, RootWriter>>>> DEATH_NOTE = Parsers.ROOT.After(Converters.STRING).After(Converters.BOOLEAN1).After(Converters.Byte<PlayerID>());
        public static readonly ParserBuilder<RepeatParser<Parser<PlayerID, Parser<HouseID, RootParser>>, RootParser>, RepeatWriter<Writer<PlayerID, Writer<HouseID, RootWriter>>, RootWriter>> HOUSES_CHOSEN = Parsers.ROOT.Repeat(0, Parsers.ROOT.After(Converters.Byte<HouseID>()).After(Converters.Byte<PlayerID>()));
        public static readonly RootBuilder FIRST_DAY_TRANSITION = Parsers.ROOT;
        public static readonly ParserBuilder<RepeatParser<Parser<PlayerID, Parser<CharacterID, RootParser>>, RootParser>, RepeatWriter<Writer<PlayerID, Writer<CharacterID, RootWriter>>, RootWriter>> CHARACTERS_CHOSEN = Parsers.ROOT.Repeat(0, Parsers.ROOT.After(Converters.Byte<CharacterID>()).After(Converters.Byte<PlayerID>()));
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> RESURRECTION_SET_ALIVE = Parsers.PLAYER;
        public static readonly RootBuilder START_DEFENSE = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> USER_LEFT_DURING_SELECTION = Parsers.PLAYER;
        public static readonly RootBuilder VIGILANTE_KILLED_TOWN = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<PlayerID, Parser<PlayerID, RootParser>>, Writer<PlayerID, Writer<PlayerID, RootWriter>>> NOTIFY_USERS_OF_PRIVATE_MESSAGE = Parsers.PLAYER2;
        public static readonly ParserBuilder<Parser<PrivateMessageType, Parser<PlayerID, ConditionalParser<Parser<string, RootParser>, Parser<PlayerID, Parser<string, RootParser>>>>>, Writer<PrivateMessageType, Writer<PlayerID, ConditionalWriter<Writer<string, RootWriter>, Writer<PlayerID, Writer<string, RootWriter>>>>>> PRIVATE_MESSAGE = Parsers.ROOT.After(Converters.STRING).Condition(Parsers.PLAYER_STRING).After(Converters.Byte<PlayerID>()).After(Converters.Byte<PrivateMessageType>());
        public static readonly ParserBuilder<RepeatParser<Parser<AchievementID, RootParser>, RootParser>, RepeatWriter<Writer<AchievementID, RootWriter>, RootWriter>> EARNED_ACHIEVEMENTS_161 = Parsers.REPEAT_ACHIEVEMENT;
        public static readonly ParserBuilder<Parser<AuthenticationResult, ConditionalParser<Parser<uint, RootParser>, RootParser>>, Writer<AuthenticationResult, ConditionalWriter<Writer<uint, RootWriter>, RootWriter>>> AUTHENTICATION_FAILED = Parsers.UINT.Condition(Parsers.ROOT).After(Converters.Byte<AuthenticationResult>());
        public static readonly ParserBuilder<Parser<bool, Parser<PlayerID, RootParser>>, Writer<bool, Writer<PlayerID, RootWriter>>> SPY_NIGHT_ABILITY_MESSAGE = Parsers.ROOT.After(Converters.Byte<PlayerID>()).After(Converters.BOOLEAN1);
        public static readonly RootBuilder ONE_DAY_BEFORE_STALEMATE = Parsers.ROOT;
        public static readonly ParserBuilder<RepeatParser<Parser<PlayerID, Parser<PetID, RootParser>>, RootParser>, RepeatWriter<Writer<PlayerID, Writer<PetID, RootWriter>>, RootWriter>> PETS_CHOSEN = Parsers.ROOT.Repeat(0, Parsers.ROOT.After(Converters.Byte<PetID>()).After(Converters.Byte<PlayerID>()));
        public static readonly ParserBuilder<Parser<AchievementID, RootParser>, Writer<AchievementID, RootWriter>> FACEBOOK_SHARE_ACHIEVEMENT = Parsers.ROOT.After(Converters.UInt<AchievementID>());
        public static readonly ParserBuilder<Parser<FactionID, RootParser>, Writer<FactionID, RootWriter>> FACEBOOK_SHARE_WIN = Parsers.ROOT.After(Converters.Byte<FactionID>());
        public static readonly ParserBuilder<RepeatParser<Parser<PlayerID, Parser<DeathAnimationID, RootParser>>, RootParser>, RepeatWriter<Writer<PlayerID, Writer<DeathAnimationID, RootWriter>>, RootWriter>> DEATH_ANIMATIONS_CHOSEN = Parsers.ROOT.Repeat(0, Parsers.ROOT.After(Converters.Byte<DeathAnimationID>()).After(Converters.Byte<PlayerID>()));
        public static readonly RootBuilder FULL_MOON_NIGHT = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> IDENTIFY = Parsers.STRING;
        public static readonly ParserBuilder<Parser<uint, Parser<GameModeID, Parser<FactionID, Parser<bool, Parser<byte, Parser<byte, RepeatParser<Parser<string, Parser<string, Parser<PlayerID, RepeatParser<Parser<RoleID, RootParser>, Parser<object, RootParser>>>>>, RootParser>>>>>>>, Writer<uint, Writer<GameModeID, Writer<FactionID, Writer<bool, Writer<byte, Writer<byte, RepeatWriter<Writer<string, Writer<string, Writer<PlayerID, RepeatWriter<Writer<RoleID, RootWriter>, Writer<object, RootWriter>>>>>, RootWriter>>>>>>>> END_GAME_INFO = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.Default<object>(), 0x29).Repeat(0, Parsers.ROOT.After(Converters.Byte<RoleID>())).After(Converters.Byte<PlayerID>()).After(Converters.STRING, 0x2C).After(Converters.STRING, 0x2C)).After(Converters.Byte<byte>()).After(Converters.Byte<byte>()).After(Converters.BOOLEAN1).After(Converters.Byte<FactionID>()).After(Converters.Byte<GameModeID>(), 0x2C).After(Converters.UInt<uint>());
        public static readonly ParserBuilder<Parser<PlayerID, Parser<string, RootParser>>, Writer<PlayerID, Writer<string, RootWriter>>> END_GAME_CHAT_MESSAGE = Parsers.PLAYER_STRING;
        public static readonly ParserBuilder<RepeatParser<Parser<PlayerID, Parser<bool, RootParser>>, RootParser>, RepeatWriter<Writer<PlayerID, Writer<bool, RootWriter>>, RootWriter>> END_GAME_USER_UPDATE = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.BOOLEAN1, 0x2C).After(Converters.Byte<PlayerID>()));
        public static readonly ParserBuilder<RepeatParser<Parser<RoleID, Parser<uint, Parser<uint, RootParser>>>, RootParser>, RepeatWriter<Writer<RoleID, Writer<uint, Writer<uint, RootWriter>>>, RootWriter>> ROLE_LOTS_INFO_MESSAGE = Parsers.ROOT.Repeat(1, new RootBuilder(0x2A).After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<RoleID>()));
        public static readonly ParserBuilder<Parser<Uri, RootParser>, Writer<Uri, RootWriter>> EXTERNAL_PURCHASE = Parsers.ROOT.After(Converters.URI);
        public static readonly RootBuilder VAMPIRE_PROMOTION = Parsers.ROOT;
        public static readonly ParserBuilder<RepeatParser<Parser<PlayerID, Parser<bool, RootParser>>, RootParser>, RepeatWriter<Writer<PlayerID, Writer<bool, RootWriter>>, RootWriter>> OTHER_VAMPIRES = Parsers.ROOT.Repeat(0, Parsers.BOOLEAN.After(Converters.Byte<PlayerID>()));
        public static readonly ParserBuilder<Parser<PlayerID, Parser<bool, RootParser>>, Writer<PlayerID, Writer<bool, RootWriter>>> ADD_VAMPIRE = Parsers.ROOT.After(Converters.BOOLEAN1).After(Converters.Byte<PlayerID>());
        public static readonly ParserBuilder<Parser<bool, RootParser>, Writer<bool, RootWriter>> CAN_VAMPIRES_CONVERT = Parsers.BOOLEAN;
        public static readonly ParserBuilder<Parser<PlayerID, Parser<Option<PlayerID>, RootParser>>, Writer<PlayerID, Writer<Option<PlayerID>, RootWriter>>> VAMPIRE_DIED = Parsers.ROOT.After(Converters.Optional(Converters.Byte<PlayerID>())).After(Converters.Byte<PlayerID>());
        public static readonly RootBuilder VAMPIRE_HUNTER_PROMOTED = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> VAMPIRE_VISITED_MESSAGE = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<bool, RootParser>, Writer<bool, RootWriter>> CHECK_USERNAME_RESULT = Parsers.BOOLEAN;
        public static readonly ParserBuilder<Parser<NameChangeResult, RootParser>, Writer<NameChangeResult, RootWriter>> NAME_CHANGE_RESULT = Parsers.ROOT.After(Converters.Byte<NameChangeResult>());
        public static readonly ParserBuilder<Parser<AccountState, RootParser>, Writer<AccountState, RootWriter>> ACCOUNT_STATE = Parsers.ROOT.After(Converters.Byte<AccountState>());
        public static readonly ParserBuilder<RepeatParser<Parser<AccountItemID, RootParser>, RootParser>, RepeatWriter<Writer<AccountItemID, RootWriter>, RootWriter>> PURCHASED_ACCOUNT_ITEMS = Parsers.ROOT.Repeat(1, Parsers.ROOT_COMMA.After(Converters.UInt<AccountItemID>()));
        public static readonly ParserBuilder<Parser<AccountItemID, Parser<uint, Parser<uint, RootParser>>>, Writer<AccountItemID, Writer<uint, Writer<uint, RootWriter>>>> ACCOUNT_ITEM_CONSUMED = Parsers.ROOT.After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<AccountItemID>());
        public static readonly ParserBuilder<Parser<PlayerID, Parser<PlayerID, RootParser>>, Writer<PlayerID, Writer<PlayerID, RootWriter>>> TRANSPORTER_NOTIFICATION = Parsers.PLAYER2;
        public static readonly ParserBuilder<Parser<ShopItemID, Parser<uint, Parser<PurchaseSourceID, Parser<uint, Parser<PurchaseResult, Parser<ItemType, ConditionalParser<RepeatParser<Parser<ItemType, Parser<uint, RootParser>>, RootParser>, RootParser>>>>>>>, Writer<ShopItemID, Writer<uint, Writer<PurchaseSourceID, Writer<uint, Writer<PurchaseResult, Writer<ItemType, ConditionalWriter<RepeatWriter<Writer<ItemType, Writer<uint, RootWriter>>, RootWriter>, RootWriter>>>>>>>> PRODUCT_PURCHASE_RESULT = Parsers.ROOT.Repeat(0, Parsers.ROOT.After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<ItemType>(), 0x2C)).Condition(Parsers.ROOT).After(Converters.UInt<ItemType>(), 0x2C).After(Converters.UInt<PurchaseResult>(), 0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<PurchaseSourceID>(), 0x2C).After(Converters.UInt<uint>()).After(Converters.UInt<ShopItemID>());
        public static readonly ParserBuilder<Parser<uint, RootParser>, Writer<uint, RootWriter>> UPDATE_FREE_CURRENCY = Parsers.UINT;
        public static readonly ParserBuilder<RepeatParser<Parser<uint, Parser<string, Parser<uint, Parser<uint, RootParser>>>>, RootParser>, RepeatWriter<Writer<uint, Writer<string, Writer<uint, Writer<uint, RootWriter>>>>, RootWriter>> ACTIVE_EVENTS = Parsers.ROOT.Repeat(1, new RootBuilder(0x2A).After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.STRING, 0x2C).After(Converters.UInt<uint>()));
        public static readonly ParserBuilder<Parser<CauldronRewardType, Parser<uint, Parser<uint, Parser<bool, Parser<uint, RepeatParser<Parser<CauldronPotionID, RootParser>, RepeatParser<Parser<ItemType, Parser<uint, Parser<uint, RootParser>>>, RootParser>>>>>>>, Writer<CauldronRewardType, Writer<uint, Writer<uint, Writer<bool, Writer<uint, RepeatWriter<Writer<CauldronPotionID, RootWriter>, RepeatWriter<Writer<ItemType, Writer<uint, Writer<uint, RootWriter>>>, RootWriter>>>>>>>> CAULDRON_STATUS = Parsers.ROOT.Repeat(1, new RootBuilder(0x2A).After(Converters.UInt<uint>(), 0x7C).After(Converters.UInt<uint>(), 0x7C).After(Converters.UInt<ItemType>()), 0x2C).Repeat(0, Parsers.ROOT.After(Converters.UInt<CauldronPotionID>()), 0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.BOOLEAN2, 0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<CauldronRewardType>());
        public static readonly ParserBuilder<Parser<PlayerID, Parser<TauntTargetType, Parser<TauntID, Parser<bool, RootParser>>>>, Writer<PlayerID, Writer<TauntTargetType, Writer<TauntID, Writer<bool, RootWriter>>>>> TAUNT_RESULT = Parsers.BOOLEAN.After(Converters.Byte<TauntID>()).After(Converters.Byte<TauntTargetType>()).After(Converters.Byte<PlayerID>());
        public static readonly ParserBuilder<Parser<PlayerID, Parser<TauntTargetType, Parser<TauntID, RootParser>>>, Writer<PlayerID, Writer<TauntTargetType, Writer<TauntID, RootWriter>>>> TAUNT_ACTIVATED = Parsers.PLAYER_TYPE_TAUNT;
        public static readonly ParserBuilder<Parser<TauntID, RootParser>, Writer<TauntID, RootWriter>> TAUNT_CONSUMED = Parsers.ROOT.After(Converters.Byte<TauntID>());
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> TRACKER_NIGHT_ABILITY = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> AMBUSHER_NIGHT_ABILITY = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> GUARDIAN_ANGEL_PROTECTION = Parsers.PLAYER;
        public static readonly RootBuilder PIRATE_DUEL = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> DUEL_TARGET = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<byte, Parser<byte, Parser<byte, RootParser>>>, Writer<byte, Writer<byte, Writer<byte, RootWriter>>>> POTION_MASTER_POTIONS = Parsers.ROOT.After(Converters.Byte<byte>()).After(Converters.Byte<byte>()).After(Converters.Byte<byte>());
        public static readonly ParserBuilder<Parser<bool, ConditionalParser<RootParser, Parser<byte, RootParser>>>, Writer<bool, ConditionalWriter<RootWriter, Writer<byte, RootWriter>>>> HAS_NECRONOMICON = Parsers.ROOT.Condition(Parsers.BYTE).After(Converters.BOOLEAN1);
        public static readonly ParserBuilder<RepeatParser<Parser<PlayerID, Parser<RoleID, RootParser>>, RootParser>, RepeatWriter<Writer<PlayerID, Writer<RoleID, RootWriter>>, RootWriter>> OTHER_WITCHES = Parsers.REPEAT_PLAYER_ROLE;
        public static readonly ParserBuilder<Parser<bool, Parser<PlayerID, Parser<PlayerID, ConditionalParser<RootParser, Parser<PlayerID, RootParser>>>>>, Writer<bool, Writer<PlayerID, Writer<PlayerID, ConditionalWriter<RootWriter, Writer<PlayerID, RootWriter>>>>>> PSYCHIC_NIGHT_ABILITY = Parsers.ROOT.Condition(Parsers.PLAYER).After(Converters.Byte<PlayerID>()).After(Converters.Byte<PlayerID>()).After(Converters.BOOLEAN1);
        public static readonly ParserBuilder<Parser<RoleID, RootParser>, Writer<RoleID, RootWriter>> TRAPPER_NIGHT_ABILITY = Parsers.ROLE;
        public static readonly ParserBuilder<Parser<TrapStatus, RootParser>, Writer<TrapStatus, RootWriter>> TRAPPER_TRAP_STATUS = Parsers.ROOT.After(Converters.Byte<TrapStatus>());
        public static readonly RootBuilder PESTILENCE_CONVERSION = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<byte, RootParser>, Writer<byte, RootWriter>> JUGGERNAUT_KILL_COUNT = Parsers.BYTE;
        public static readonly ParserBuilder<Parser<bool, Parser<PlayerID, ConditionalParser<RootParser, Parser<PlayerID, RootParser>>>>, Writer<bool, Writer<PlayerID, ConditionalWriter<RootWriter, Writer<PlayerID, RootWriter>>>>> COVEN_GOT_NECRONOMICON = Parsers.ROOT.Condition(Parsers.PLAYER).After(Converters.Byte<PlayerID>()).After(Converters.BOOLEAN1);
        public static readonly RootBuilder GUARDIAN_ANGEL_PROMOTED = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> VIP_TARGET = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<DuelAttackID, Parser<DuelDefenseID, RootParser>>, Writer<DuelAttackID, Writer<DuelDefenseID, RootWriter>>> PIRATE_DUEL_OUTCOME = Parsers.ROOT.After(Converters.Byte<DuelDefenseID>()).After(Converters.Byte<DuelAttackID>());
        public static readonly ParserBuilder<Parser<BrandID, Parser<GameModeID, Parser<SetConfigResult, RootParser>>>, Writer<BrandID, Writer<GameModeID, Writer<SetConfigResult, RootWriter>>>> HOST_SET_PARTY_CONFIG_RESULT = Parsers.ROOT.After(Converters.Byte<SetConfigResult>()).After(Converters.Byte<GameModeID>()).After(Converters.Byte<BrandID>());
        public static readonly ParserBuilder<RepeatParser<Parser<GameModeID, RootParser>, RootParser>, RepeatWriter<Writer<GameModeID, RootWriter>, RootWriter>> ACTIVE_GAME_MODES = Parsers.ROOT.Repeat(0, Parsers.GAMEMODE);
        public static readonly ParserBuilder<Parser<AccountFlags, RootParser>, Writer<AccountFlags, RootWriter>> ACCOUNT_FLAGS = Parsers.ROOT.After(Converters.Byte<AccountFlags>());
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> ZOMBIE_ROTTED = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> LOVER_TARGET = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> PLAGUE_SPREAD = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<PlayerID, RootParser>, Writer<PlayerID, RootWriter>> RIVAL_TARGET = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<GameModeID, Parser<uint, Parser<uint, Parser<uint, Parser<uint, Parser<uint, Parser<uint, Parser<uint, Parser<bool, Parser<uint, Parser<uint, Parser<uint, Parser<uint, Parser<uint, Parser<uint, Parser<uint, RootParser>>>>>>>>>>>>>>>>, Writer<GameModeID, Writer<uint, Writer<uint, Writer<uint, Writer<uint, Writer<uint, Writer<uint, Writer<uint, Writer<bool, Writer<uint, Writer<uint, Writer<uint, Writer<uint, Writer<uint, Writer<uint, Writer<uint, RootWriter>>>>>>>>>>>>>>>>> RANKED_INFO = Parsers.UINT5_COMMA.After(Converters.UInt<uint>()).After(Converters.UInt<uint>()).After(Converters.BOOLEAN2).After(Converters.UInt<uint>()).After(Converters.UInt<uint>()).After(Converters.UInt<uint>()).After(Converters.UInt<uint>()).After(Converters.UInt<uint>()).After(Converters.UInt<uint>()).After(Converters.UInt<uint>()).After(Converters.Byte<GameModeID>());
        public static readonly ParserBuilder<Parser<PlayerID, Parser<bool, Parser<ExecuteReasonID, RootParser>>>, Writer<PlayerID, Writer<bool, Writer<ExecuteReasonID, RootWriter>>>> JAILOR_DEATH_NOTE = Parsers.ROOT.After(Converters.Byte<ExecuteReasonID>()).After(Converters.BOOLEAN1).After(Converters.Byte<PlayerID>());
        public static readonly ParserBuilder<Parser<DisconnectReasonID, RootParser>, Writer<DisconnectReasonID, RootWriter>> DISCONNECTED = Parsers.ROOT.After(Converters.Byte<DisconnectReasonID>());
        public static readonly ParserBuilder<RepeatParser<Parser<LocalizationTableID, RootParser>, RootParser>, RepeatWriter<Writer<LocalizationTableID, RootWriter>, RootWriter>> SPY_NIGHT_INFO = Parsers.ROOT.Repeat(0, Parsers.LOCALIZATION);
        public static readonly ParserBuilder<RepeatParser<Parser<bool, RootParser>, RootParser>, RepeatWriter<Writer<bool, RootWriter>, RootWriter>> SERVER_FLAGS = Parsers.ROOT.Repeat(0, Parsers.BOOLEAN);

        public static void Authenticated(this MessageParser parser, bool registered) => parser.Parse((byte)ServerMessageType.AUTHENTICATED, (buffer, index) => AUTHENTICATED.Build(buffer, index).Parse(registered));
        public static void CreateLobby(this MessageParser parser, bool host, GameModeID mode) => parser.Parse((byte)ServerMessageType.CREATE_LOBBY, (buffer, index) => CREATE_LOBBY.Build(buffer, index).Parse(host).Parse(mode));
        public static void SetHost(this MessageParser parser) => parser.Parse((byte)ServerMessageType.SET_HOST, SET_HOST.Build);
        public static void UserJoinedGame(this MessageParser parser, bool host, bool display, string username, PlayerID id, LobbyIconID icon) => parser.Parse((byte)ServerMessageType.USER_JOINED_GAME, (buffer, index) => USER_JOINED_GAME.Build(buffer, index).Parse(host).Parse(display).Parse(username).Parse(id).Parse(icon));
        public static void UserLeftGame(this MessageParser parser, bool update, bool display, PlayerID id) => parser.Parse((byte)ServerMessageType.USER_LEFT_GAME, (buffer, index) => USER_LEFT_GAME.Build(buffer, index).Parse(update).Parse(display).Parse(id));
        public static void ChatBoxMessage(this MessageParser parser, PlayerID id, string message, bool inGame) => parser.Parse((byte)ServerMessageType.CHAT_BOX_MESSAGE, (buffer, index) => CHAT_BOX_MESSAGE.Build(buffer, index).Parse(inGame, p => p.Parse(id).Parse(message), p => p.Parse(id).Parse(message)));
        public static void HostClickedOnCatalog(this MessageParser parser, CatalogID catalog) => parser.Parse((byte)ServerMessageType.HOST_CLICKED_ON_CATALOG, (buffer, index) => HOST_CLICKED_ON_CATALOG.Build(buffer, index).Parse(catalog));
        public static void HostClickedOnPossibleRoles(this MessageParser parser, byte selectedIndex, byte scrollPosition) => parser.Parse((byte)ServerMessageType.HOST_CLICKED_ON_POSSIBLE_ROLES, (buffer, index) => HOST_CLICKED_ON_POSSIBLE_ROLES.Build(buffer, index).Parse(selectedIndex).Parse(scrollPosition));
        public static void HostClickedOnAddButton(this MessageParser parser, RoleID role) => parser.Parse((byte)ServerMessageType.HOST_CLICKED_ON_ADD_BUTTON, (buffer, index) => HOST_CLICKED_ON_ADD_BUTTON.Build(buffer, index).Parse(role));
        public static void HostClickedOnRemoveButton(this MessageParser parser, byte slotIndex) => parser.Parse((byte)ServerMessageType.HOST_CLICKED_ON_REMOVE_BUTTON, (buffer, index) => HOST_CLICKED_ON_REMOVE_BUTTON.Build(buffer, index).Parse(slotIndex));
        public static void HostClickedOnStartButton(this MessageParser parser) => parser.Parse((byte)ServerMessageType.HOST_CLICKED_ON_START_BUTTON, HOST_CLICKED_ON_START_BUTTON.Build);
        public static void CancelStartCooldown(this MessageParser parser) => parser.Parse((byte)ServerMessageType.CANCEL_START_COOLDOWN, CANCEL_START_COOLDOWN.Build);
        public static void AssignNewHost(this MessageParser parser, PlayerID newHost) => parser.Parse((byte)ServerMessageType.ASSIGN_NEW_HOST, (buffer, index) => ASSIGN_NEW_HOST.Build(buffer, index).Parse(newHost));
        public static void VotedToRepickHost(this MessageParser parser, byte votesUntilRepick) => parser.Parse((byte)ServerMessageType.VOTED_TO_REPICK_HOST, (buffer, index) => VOTED_TO_REPICK_HOST.Build(buffer, index).Parse(votesUntilRepick));
        public static void NoLongerHost(this MessageParser parser) => parser.Parse((byte)ServerMessageType.NO_LONGER_HOST, NO_LONGER_HOST.Build);
        public static void DoNotSpam(this MessageParser parser) => parser.Parse((byte)ServerMessageType.DO_NOT_SPAM, DO_NOT_SPAM.Build);
        public static void HowManyPlayersAndGames(this MessageParser parser, uint playerCount, uint gameCount) => parser.Parse((byte)ServerMessageType.HOW_MANY_PLAYERS_AND_GAMES, (buffer, index) => HOW_MANY_PLAYERS_AND_GAMES.Build(buffer, index).Parse(gameCount).Parse(playerCount));
        public static void SystemMessage(this MessageParser parser, string message) => parser.Parse((byte)ServerMessageType.SYSTEM_MESSAGE, (buffer, index) => SYSTEM_MESSAGE.Build(buffer, index).Parse(message));
        public static void StringTableMessage(this MessageParser parser, LocalizationTableID message) => parser.Parse((byte)ServerMessageType.STRING_TABLE_MESSAGE, (buffer, index) => STRING_TABLE_MESSAGE.Build(buffer, index).Parse(message));
        public static void FriendList(this MessageParser parser, params (string username, uint friendID, OnlineStatus status, bool ownsCoven)[] friends) => parser.Parse((byte)ServerMessageType.FRIEND_LIST, (buffer, index) => FRIEND_LIST.Build(buffer, index).Parse(friends, (friend, p) => p.Parse(friend.username).Parse(friend.friendID).Parse(friend.status).Parse(friend.ownsCoven)));
        public static void FriendRequestNotifications(this MessageParser parser, params (string username, uint friendID)[] requests) => parser.Parse((byte)ServerMessageType.FRIEND_REQUEST_NOTIFICATIONS, (buffer, index) => FRIEND_REQUEST_NOTIFICATIONS.Build(buffer, index).Parse(requests, (request, p) => p.Parse(request.username).Parse(request.friendID)));
        public static void AddFriendRequestResponse(this MessageParser parser, bool success) => parser.Parse((byte)ServerMessageType.ADD_FRIEND_REQUEST_RESPONSE, (buffer, index) => ADD_FRIEND_REQUEST_RESPONSE.Build(buffer, index).Parse(success));
        public static void ConfirmFriendRequest(this MessageParser parser, uint friendID, OnlineStatus status, bool ownsCoven) => parser.Parse((byte)ServerMessageType.CONFIRM_FRIEND_REQUEST, (buffer, index) => CONFIRM_FRIEND_REQUEST.Build(buffer, index).Parse(friendID).Parse(status).Parse(ownsCoven));
        public static void SuccessfullyRemovedFriend(this MessageParser parser, uint friendID) => parser.Parse((byte)ServerMessageType.SUCCESSFULLY_REMOVED_FRIEND, (buffer, index) => SUCCESSFULLY_REMOVED_FRIEND.Build(buffer, index).Parse(friendID));
        public static void SuccessfullyDeclinedFriendRequest(this MessageParser parser) => parser.Parse((byte)ServerMessageType.SUCCESSFULLY_DECLINED_FRIEND_REQUEST, SUCCESSFULLY_DECLINED_FRIEND_REQUEST.Build);
        public static void FriendUpdate(this MessageParser parser, uint friendID, OnlineStatus status, bool ownsCoven) => parser.Parse((byte)ServerMessageType.FRIEND_UPDATE, (buffer, index) => FRIEND_UPDATE.Build(buffer, index).Parse(friendID).Parse(status).Parse(ownsCoven));
        public static void FriendMessage(this MessageParser parser, uint friendID, bool sent, string message) => parser.Parse((byte)ServerMessageType.FRIEND_MESSAGE, (buffer, index) => FRIEND_MESSAGE.Build(buffer, index).Parse(friendID).Parse(sent).Parse(message));
        public static void UserInformation(this MessageParser parser, string username, uint townPoints, uint meritPoints) => parser.Parse((byte)ServerMessageType.USER_INFORMATION, (buffer, index) => USER_INFORMATION.Build(buffer, index).Parse(username).Parse(townPoints).Parse(meritPoints));
        public static void CreatePartyLobby(this MessageParser parser, BrandID brand) => parser.Parse((byte)ServerMessageType.CREATE_PARTY_LOBBY, (buffer, index) => CREATE_PARTY_LOBBY.Build(buffer, index).Parse(brand));
        public static void PartyInviteFailed(this MessageParser parser, string username, FailedInvitationStatus status) => parser.Parse((byte)ServerMessageType.PARTY_INVITE_FAILED, (buffer, index) => PARTY_INVITE_FAILED.Build(buffer, index).Parse(username).Parse(status));
        public static void PartyInviteNotification(this MessageParser parser, uint friendID, string username) => parser.Parse((byte)ServerMessageType.PARTY_INVITE_NOTIFICATION, (buffer, index) => PARTY_INVITE_NOTIFICATION.Build(buffer, index).Parse(friendID).Parse(username));
        public static void AcceptedPartyInvite(this MessageParser parser, AcceptInvitationResult result) => parser.Parse((byte)ServerMessageType.ACCEPTED_PARTY_INVITE, (buffer, index) => ACCEPTED_PARTY_INVITE.Build(buffer, index).Parse(result));
        public static void PendingPartyInviteStatus(this MessageParser parser, string username, PendingInvitationStatus status) => parser.Parse((byte)ServerMessageType.PENDING_PARTY_INVITE_STATUS, (buffer, index) => PENDING_PARTY_INVITE_STATUS.Build(buffer, index).Parse(username).Parse(status));
        public static void SuccessfullyLeftParty(this MessageParser parser) => parser.Parse((byte)ServerMessageType.SUCCESSFULLY_LEFT_PARTY, SUCCESSFULLY_LEFT_PARTY.Build);
        public static void PartyChat(this MessageParser parser, string username, string message) => parser.Parse((byte)ServerMessageType.PARTY_CHAT, (buffer, index) => PARTY_CHAT.Build(buffer, index).Parse(username).Parse(message));
        public static void PartyMemberLeft(this MessageParser parser, string username) => parser.Parse((byte)ServerMessageType.PARTY_MEMBER_LEFT, (buffer, index) => PARTY_MEMBER_LEFT.Build(buffer, index).Parse(username));
        public static void SettingsInformation(this MessageParser parser, bool filterChat, bool muteMusic, bool muteEffects, bool shareSkin, bool classicSkinsOnly, bool displayPets, byte effectsVolume, byte musicVolume, LanguageID selectedLanguage, byte unknown, TipBehaviourID tipBehaviour) => parser.Parse((byte)ServerMessageType.SETTINGS_INFORMATION, (buffer, index) => SETTINGS_INFORMATION.Build(buffer, index).Parse(filterChat).Parse(muteMusic).Parse(muteEffects).Parse(shareSkin).Parse(classicSkinsOnly).Parse(displayPets).Parse(effectsVolume).Parse(musicVolume).Parse(selectedLanguage).Parse(unknown).Parse(tipBehaviour));
        public static void AddFriend(this MessageParser parser, string username, uint id, OnlineStatus status, bool ownsCoven) => parser.Parse((byte)ServerMessageType.ADD_FRIEND, (buffer, index) => ADD_FRIEND.Build(buffer, index).Parse(username).Parse(id).Parse(status).Parse(ownsCoven));
        public static void ForcedLogout(this MessageParser parser) => parser.Parse((byte)ServerMessageType.FORCED_LOGOUT, FORCED_LOGOUT.Build);
        public static void ReturnToHomePage(this MessageParser parser) => parser.Parse((byte)ServerMessageType.RETURN_TO_HOME_PAGE, RETURN_TO_HOME_PAGE.Build);
        public static void ShopPurchaseSuccess(this MessageParser parser) => parser.Parse((byte)ServerMessageType.SHOP_PURCHASE_SUCCESS, SHOP_PURCHASE_SUCCESS.Build);
        public static void PurchasedCharacters(this MessageParser parser, params CharacterID[] characters) => parser.Parse((byte)ServerMessageType.PURCHASED_CHARACTERS, (buffer, index) => PURCHASED_CHARACTERS.Build(buffer, index).Parse(characters, (character, p) => p.Parse(character)));
        public static void PurchasedHouses(this MessageParser parser, params HouseID[] houses) => parser.Parse((byte)ServerMessageType.PURCHASED_HOUSES, (buffer, index) => PURCHASED_HOUSES.Build(buffer, index).Parse(houses, (house, p) => p.Parse(house)));
        public static void PurchasedBackgrounds(this MessageParser parser, params BackgroundID[] backgrounds) => parser.Parse((byte)ServerMessageType.PURCHASED_BACKGROUNDS, (buffer, index) => PURCHASED_BACKGROUNDS.Build(buffer, index).Parse(backgrounds, (background, p) => p.Parse(background)));
        public static void SelectionSettings(this MessageParser parser, CharacterID character, HouseID house, BackgroundID background, PetID? pet, LobbyIconID icon, DeathAnimationID death, ScrollID? scroll1, ScrollID? scroll2, ScrollID? scroll3, string name) => parser.Parse((byte)ServerMessageType.SELECTION_SETTINGS, (buffer, index) => SELECTION_SETTINGS.Build(buffer, index).Parse(character).Parse(house).Parse(background).Parse(pet).Parse(icon).Parse(death).Parse(scroll1).Parse(scroll2).Parse(scroll3).Parse(name));
        public static void RedeemCodeMessage(this MessageParser parser, RedeemCodeResult result, RedeemCodeRewardID? reward = null, string rewardArgs = "") => parser.Parse((byte)ServerMessageType.REDEEM_CODE_MESSAGE, (buffer, index) => REDEEM_CODE_MESSAGE.Build(buffer, index).Parse(result).Parse(reward != null, p => p.Parse(reward ?? default(RedeemCodeRewardID)).Parse(rewardArgs), p => p));
        public static void UpdatePaidCurrency(this MessageParser parser, uint amount) => parser.Parse((byte)ServerMessageType.UPDATE_PAID_CURRENCY, (buffer, index) => UPDATE_PAID_CURRENCY.Build(buffer, index).Parse(amount));
        public static void PurchasedPacks(this MessageParser parser, params PackID[] packs) => parser.Parse((byte)ServerMessageType.PURCHASED_PACKS, (buffer, index) => PURCHASED_PACKS.Build(buffer, index).Parse(packs, (pack, p) => p.Parse(pack)));
        public static void PurchasedPets(this MessageParser parser, params PetID[] pets) => parser.Parse((byte)ServerMessageType.PURCHASED_PETS, (buffer, index) => PURCHASED_PETS.Build(buffer, index).Parse(pets, (pet, p) => p.Parse(pet)));
        public static void SetLastBonusWinTime(this MessageParser parser, uint time) => parser.Parse((byte)ServerMessageType.SET_LAST_BONUS_WIN_TIME, (buffer, index) => SET_LAST_BONUS_WIN_TIME.Build(buffer, index).Parse(time));
        public static void EarnedAchievements52(this MessageParser parser, params AchievementID[] achievements) => parser.Parse((byte)ServerMessageType.EARNED_ACHIEVEMENTS_52, (buffer, index) => EARNED_ACHIEVEMENTS_52.Build(buffer, index).Parse(achievements, (achievement, p) => p.Parse(achievement)));
        public static void PurchasedLobbyIcons(this MessageParser parser, params LobbyIconID[] icons) => parser.Parse((byte)ServerMessageType.PURCHASED_LOBBY_ICONS, (buffer, index) => PURCHASED_LOBBY_ICONS.Build(buffer, index).Parse(icons, (icon, p) => p.Parse(icon)));
        public static void PurchasedDeathAnimations(this MessageParser parser, params DeathAnimationID[] deaths) => parser.Parse((byte)ServerMessageType.PURCHASED_DEATH_ANIMATIONS, (buffer, index) => PURCHASED_DEATH_ANIMATIONS.Build(buffer, index).Parse(deaths, (death, p) => p.Parse(death)));
        public static void FacebookInviteFriends(this MessageParser parser) => parser.Parse((byte)ServerMessageType.FACEBOOK_INVITE_FRIENDS, FACEBOOK_INVITE_FRIENDS.Build);
        public static void PurchasedScrolls(this MessageParser parser, params (ScrollID scroll, uint amount)[] scrolls) => parser.Parse((byte)ServerMessageType.PURCHASED_SCROLLS, (buffer, index) => PURCHASED_SCROLLS.Build(buffer, index).Parse(scrolls, (scroll, p) => p.Parse(scroll.scroll).Parse(scroll.amount)));
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
        public static void ModeratorMessage(this MessageParser parser, ModeratorMessageID message, string args) => parser.Parse((byte)ServerMessageType.MODERATOR_MESSAGE, (buffer, index) => MODERATOR_MESSAGE.Build(buffer, index).Parse(message).Parse(args));
        public static void ReferAFriendUpdate(this MessageParser parser, ReferralRewardID reward, uint? tpReward = null) => parser.Parse((byte)ServerMessageType.REFER_A_FRIEND_UPDATE, (buffer, index) => REFER_A_FRIEND_UPDATE.Build(buffer, index).Parse(reward).Parse(tpReward != null, p => p.Parse(tpReward ?? 0), p => p));
        public static void PlayerStatistics(this MessageParser parser, params uint[] statistics) => parser.Parse((byte)ServerMessageType.PLAYER_STATISTICS, (buffer, index) => PLAYER_STATISTICS.Build(buffer, index).Parse(statistics, (stat, p) => p.Parse(stat)));
        public static void ScrollConsumed(this MessageParser parser, ScrollID scroll) => parser.Parse((byte)ServerMessageType.SCROLL_CONSUMED, (buffer, index) => SCROLL_CONSUMED.Build(buffer, index).Parse(scroll));
        public static void AdViewResponse(this MessageParser parser, AdViewResult result, uint value = 0) => parser.Parse((byte)ServerMessageType.AD_VIEW_RESPONSE, (buffer, index) => AD_VIEW_RESPONSE.Build(buffer, index).Parse(result).Parse(result == AdViewResult.GIVE_PRIZE || result == AdViewResult.SET_TOKEN, p => p.Parse(result == AdViewResult.GIVE_PRIZE, p2 => p2.Parse((byte)value), p2 => p2.Parse(value)), p => p));
        public static void UserJoiningLobbyTooQuickly(this MessageParser parser) => parser.Parse((byte)ServerMessageType.USER_JOINING_LOBBY_TOO_QUICKLY_MESSAGE, USER_JOINING_LOBBY_TOO_QUICKLY.Build);
        public static void PromotionPopup(this MessageParser parser, PromotionID promotion, uint secondsActive, double discount, uint refID) => parser.Parse((byte)ServerMessageType.PROMOTION_POPUP, (buffer, index) => PROMOTION_POPUP.Build(buffer, index).Parse(promotion).Parse(secondsActive).Parse(discount).Parse(refID));
        public static void KickstarterShare(this MessageParser parser) => parser.Parse((byte)ServerMessageType.KICKSTARTER_SHARE, KICKSTARTER_SHARE.Build);
        public static void TutorialProgress(this MessageParser parser, params TutorialTipID[] triggeredTips) => parser.Parse((byte)ServerMessageType.TUTORIAL_PROGRESS, (buffer, index) => TUTORIAL_PROGRESS.Build(buffer, index).Parse(triggeredTips, (tip, p) => p.Parse(tip)));
        public static void PurchasedTaunts(this MessageParser parser, params (TauntID id, uint amount)[] taunts) => parser.Parse((byte)ServerMessageType.PURCHASED_TAUNTS, (buffer, index) => PURCHASED_TAUNTS.Build(buffer, index).Parse(taunts, (taunt, p) => p.Parse(taunt.id).Parse(taunt.amount)));
        public static void CurrencyMultiplier(this MessageParser parser, params (CurrencyID currency, uint multiplier)[] multipliers) => parser.Parse((byte)ServerMessageType.CURRENCY_MULTIPLIER, (buffer, index) => CURRENCY_MULTIPLIER.Build(buffer, index).Parse(multipliers, (multiplier, p) => p.Parse(multiplier.currency).Parse(multiplier.multiplier)));
        public static void PickNames(this MessageParser parser, byte playerCount, GameModeID mode) => parser.Parse((byte)ServerMessageType.PICK_NAMES, (buffer, index) => PICK_NAMES.Build(buffer, index).Parse(playerCount).Parse(mode));
        public static void NamesAndPositionsOfUsers(this MessageParser parser, PlayerID id, string name) => parser.Parse((byte)ServerMessageType.NAMES_AND_POSITIONS_OF_USERS, (buffer, index) => NAMES_AND_POSITIONS_OF_USERS.Build(buffer, index).Parse(id).Parse(name));
        public static void RoleAndPosition(this MessageParser parser, RoleID role, PlayerID id, PlayerID? target = null) => parser.Parse((byte)ServerMessageType.ROLE_AND_POSITION, (buffer, index) => ROLE_AND_POSITION.Build(buffer, index).Parse(role).Parse(id).Parse(target.ToOption()));
        public static void StartNight(this MessageParser parser) => parser.Parse((byte)ServerMessageType.START_NIGHT, START_NIGHT.Build);
        public static void StartDay(this MessageParser parser) => parser.Parse((byte)ServerMessageType.START_DAY, START_DAY.Build);
        public static void WhoDiedAndHow(this MessageParser parser, PlayerID player, RoleID role, bool announce, params DeathCauseID[] causes) => parser.Parse((byte)ServerMessageType.WHO_DIED_AND_HOW, (buffer, index) => WHO_DIED_AND_HOW.Build(buffer, index).Parse(player).Parse(role).Parse(announce).Parse(causes, (cause, p) => p.Parse(cause)));
        public static void StartDiscussion(this MessageParser parser) => parser.Parse((byte)ServerMessageType.START_DISCUSSION, START_DISCUSSION.Build);
        public static void StartVoting(this MessageParser parser, bool showVotesNeeded) => parser.Parse((byte)ServerMessageType.START_VOTING, (buffer, index) => START_VOTING.Build(buffer, index).Parse(showVotesNeeded));
        public static void StartDefenseTransition(this MessageParser parser, PlayerID player) => parser.Parse((byte)ServerMessageType.START_DEFENSE_TRANSITION, (buffer, index) => START_DEFENSE_TRANSITION.Build(buffer, index).Parse(player));
        public static void StartJudgement(this MessageParser parser) => parser.Parse((byte)ServerMessageType.START_JUDGEMENT, START_JUDGEMENT.Build);
        public static void TrialFoundGuilty(this MessageParser parser, byte guiltyVotes, byte innocentVotes) => parser.Parse((byte)ServerMessageType.TRIAL_FOUND_GUILTY, (buffer, index) => TRIAL_FOUND_GUILTY.Build(buffer, index).Parse(guiltyVotes).Parse(innocentVotes));
        public static void TrialFoundNotGuilty(this MessageParser parser, byte guiltyVotes, byte innocentVotes) => parser.Parse((byte)ServerMessageType.TRIAL_FOUND_NOT_GUILTY, (buffer, index) => TRIAL_FOUND_NOT_GUILTY.Build(buffer, index).Parse(guiltyVotes).Parse(innocentVotes));
        public static void LookoutNightAbilityMessage(this MessageParser parser, PlayerID player) => parser.Parse((byte)ServerMessageType.LOOKOUT_NIGHT_ABILITY_MESSAGE, (buffer, index) => LOOKOUT_NIGHT_ABILITY_MESSAGE.Build(buffer, index).Parse(player));
        public static void UserVoted(this MessageParser parser, PlayerID voter, PlayerID voted, byte voteCount) => parser.Parse((byte)ServerMessageType.USER_VOTED, (buffer, index) => USER_VOTED.Build(buffer, index).Parse(voter).Parse(voted).Parse(voteCount));
        public static void UserCanceledVote(this MessageParser parser, PlayerID voter, PlayerID voted, byte voteCount) => parser.Parse((byte)ServerMessageType.USER_CANCELED_VOTE, (buffer, index) => USER_CANCELED_VOTE.Build(buffer, index).Parse(voter).Parse(voted).Parse(voteCount));
        public static void UserChangedVote(this MessageParser parser, PlayerID voter, PlayerID newVoted, PlayerID oldVoted, byte voteCount) => parser.Parse((byte)ServerMessageType.USER_CHANGED_VOTE, (buffer, index) => USER_CHANGED_VOTE.Build(buffer, index).Parse(voter).Parse(newVoted).Parse(oldVoted).Parse(voteCount));
        public static void UserDied(this MessageParser parser, bool silent) => parser.Parse((byte)ServerMessageType.USER_DIED, (buffer, index) => USER_DIED.Build(buffer, index).Parse(silent));
        public static void Resurrection(this MessageParser parser, PlayerID player, RoleID role) => parser.Parse((byte)ServerMessageType.RESURRECTION, (buffer, index) => RESURRECTION.Build(buffer, index).Parse(player).Parse(role));
        public static void TellRoleList(this MessageParser parser, params RoleID[] roles) => parser.Parse((byte)ServerMessageType.TELL_ROLE_LIST, (buffer, index) => TELL_ROLE_LIST.Build(buffer, index).Parse(roles, (role, p) => p.Parse(role)));
        public static void UserChosenName(this MessageParser parser, LocalizationTableID message, PlayerID player, string name) => parser.Parse((byte)ServerMessageType.USER_CHOSEN_NAME, (buffer, index) => USER_CHOSEN_NAME.Build(buffer, index).Parse(message).Parse(player).Parse(name));
        public static void OtherMafia(this MessageParser parser, params (PlayerID player, RoleID role)[] mafiaMembers) => parser.Parse((byte)ServerMessageType.OTHER_MAFIA, (buffer, index) => OTHER_MAFIA.Build(buffer, index).Parse(mafiaMembers, (member, p) => p.Parse(member.player).Parse(member.role)));
        public static void TellTownAmnesiacChangedRole(this MessageParser parser, RoleID role) => parser.Parse((byte)ServerMessageType.TELL_TOWN_AMNESIAC_CHANGED_ROLE, (buffer, index) => TELL_TOWN_AMNESIAC_CHANGED_ROLE.Build(buffer, index).Parse(role));
        public static void AmnesiacChangedRole(this MessageParser parser, RoleID role, PlayerID? target = null) => parser.Parse((byte)ServerMessageType.AMNESIAC_CHANGED_ROLE, (buffer, index) => AMNESIAC_CHANGED_ROLE.Build(buffer, index).Parse(role).Parse(target.ToOption()));
        public static void BroughtBackToLife(this MessageParser parser) => parser.Parse((byte)ServerMessageType.BROUGHT_BACK_TO_LIFE, BROUGHT_BACK_TO_LIFE.Build);
        public static void StartFirstDay(this MessageParser parser) => parser.Parse((byte)ServerMessageType.START_FIRST_DAY, START_FIRST_DAY.Build);
        public static void BeingJailed(this MessageParser parser) => parser.Parse((byte)ServerMessageType.BEING_JAILED, BEING_JAILED.Build);
        public static void JailedTarget(this MessageParser parser, PlayerID jailed, bool canExecute, bool executedTown) => parser.Parse((byte)ServerMessageType.JAILED_TARGET, (buffer, index) => JAILED_TARGET.Build(buffer, index).Parse(jailed).Parse(canExecute).Parse(executedTown));
        public static void UserJudgementVoted(this MessageParser parser, PlayerID player) => parser.Parse((byte)ServerMessageType.USER_JUDGEMENT_VOTED, (buffer, index) => USER_JUDGEMENT_VOTED.Build(buffer, index).Parse(player));
        public static void UserChangedJudgementVote(this MessageParser parser, PlayerID player) => parser.Parse((byte)ServerMessageType.USER_CHANGED_JUDGEMENT_VOTE, (buffer, index) => USER_CHANGED_JUDGEMENT_VOTE.Build(buffer, index).Parse(player));
        public static void UserCanceledJudgementVote(this MessageParser parser, PlayerID player) => parser.Parse((byte)ServerMessageType.USER_CANCELED_JUDGEMENT_VOTE, (buffer, index) => USER_CANCELED_JUDGEMENT_VOTE.Build(buffer, index).Parse(player));
        public static void TellJudgementVotes(this MessageParser parser, PlayerID player, JudgementVoteID vote) => parser.Parse((byte)ServerMessageType.TELL_JUDGEMENT_VOTES, (buffer, index) => TELL_JUDGEMENT_VOTES.Build(buffer, index).Parse(player).Parse(vote));
        public static void ExecutionerCompletedGoal(this MessageParser parser) => parser.Parse((byte)ServerMessageType.EXECUTIONER_COMPLETED_GOAL, EXECUTIONER_COMPLETED_GOAL.Build);
        public static void JesterCompletedGoal(this MessageParser parser) => parser.Parse((byte)ServerMessageType.JESTER_COMPLETED_GOAL, JESTER_COMPLETED_GOAL.Build);
        public static void MayorRevealed(this MessageParser parser, PlayerID player) => parser.Parse((byte)ServerMessageType.MAYOR_REVEALED, (buffer, index) => MAYOR_REVEALED.Build(buffer, index).Parse(player));
        public static void MayorRevealedAndAlreadyVoted(this MessageParser parser, PlayerID player) => parser.Parse((byte)ServerMessageType.MAYOR_REVEALED_AND_ALREADY_VOTED, (buffer, index) => MAYOR_REVEALED_AND_ALREADY_VOTED.Build(buffer, index).Parse(player));
        public static void DisguiserStoleYourIdentity(this MessageParser parser, PlayerID player) => parser.Parse((byte)ServerMessageType.DISGUISER_STOLE_YOUR_IDENTITY, (buffer, index) => DISGUISER_STOLE_YOUR_IDENTITY.Build(buffer, index).Parse(player));
        public static void DisguiserChangedIdentity(this MessageParser parser, PlayerID player) => parser.Parse((byte)ServerMessageType.DISGUISER_CHANGED_IDENTITY, (buffer, index) => DISGUISER_CHANGED_IDENTITY.Build(buffer, index).Parse(player));
        public static void DisguiserChangedUpdateMafia(this MessageParser parser, PlayerID newPlayer, PlayerID oldPlayer) => parser.Parse((byte)ServerMessageType.DISGUISER_CHANGED_UPDATE_MAFIA, (buffer, index) => DISGUISER_CHANGED_UPDATE_MAFIA.Build(buffer, index).Parse(newPlayer).Parse(oldPlayer));
        public static void MediumIsTalkingToUs(this MessageParser parser) => parser.Parse((byte)ServerMessageType.MEDIUM_IS_TALKING_TO_US, MEDIUM_IS_TALKING_TO_US.Build);
        public static void MediumCommunicating(this MessageParser parser) => parser.Parse((byte)ServerMessageType.MEDIUM_COMMUNICATING, MEDIUM_COMMUNICATING.Build);
        public static void TellLastWill(this MessageParser parser, PlayerID player, string will) => parser.Parse((byte)ServerMessageType.TELL_LAST_WILL, (buffer, index) => TELL_LAST_WILL.Build(buffer, index).Parse(player).Parse(will != null).Parse(will != null, p => p.Parse(will), p => p));
        public static void HowManyAbilitiesLeft(this MessageParser parser, byte abilitiesLeft) => parser.Parse((byte)ServerMessageType.HOW_MANY_ABILITIES_LEFT, (buffer, index) => HOW_MANY_ABILITIES_LEFT.Build(buffer, index).Parse(abilitiesLeft));
        public static void MafiaTargeting(this MessageParser parser, PlayerID player, RoleID role, PlayerID target, byte mod1, byte? mod2 = null, byte? mod3 = null) => parser.Parse((byte)ServerMessageType.MAFIA_TARGETING, (buffer, index) => MAFIA_TARGETING.Build(buffer, index).Parse(player).Parse(role).Parse(target).Parse(mod1).Parse(mod2.ToOption()).Parse(mod3.ToOption()));
        public static void TellJanitorTargetsRole(this MessageParser parser, RoleID role) => parser.Parse((byte)ServerMessageType.TELL_JANITOR_TARGETS_ROLE, (buffer, index) => TELL_JANITOR_TARGETS_ROLE.Build(buffer, index).Parse(role));
        public static void TellJanitorTargetsWill(this MessageParser parser, PlayerID player, string will) => parser.Parse((byte)ServerMessageType.TELL_JANITOR_TARGETS_WILL, (buffer, index) => TELL_JANITOR_TARGETS_WILL.Build(buffer, index).Parse(player).Parse(will));
        public static void SomeoneHasWon(this MessageParser parser, FactionID faction, params PlayerID[] winners) => parser.Parse((byte)ServerMessageType.SOMEONE_HAS_WON, (buffer, index) => SOMEONE_HAS_WON.Build(buffer, index).Parse(faction).Parse(winners, (player, p) => p.Parse(player)));
        public static void MafiosoPromotedToGodfather(this MessageParser parser) => parser.Parse((byte)ServerMessageType.MAFIOSO_PROMOTED_TO_GODFATHER, MAFIOSO_PROMOTED_TO_GODFATHER.Build);
        public static void MafiosoPromotedToGodfatherUpdateMafia(this MessageParser parser, PlayerID promoted) => parser.Parse((byte)ServerMessageType.MAFIOSO_PROMOTED_TO_GODFATHER_UPDATE_MAFIA, (buffer, index) => MAFIOSO_PROMOTED_TO_GODFATHER_UPDATE_MAFIA.Build(buffer, index).Parse(promoted));
        public static void MafiaPromotedToMafioso(this MessageParser parser) => parser.Parse((byte)ServerMessageType.MAFIA_PROMOTED_TO_MAFIOSO, MAFIA_PROMOTED_TO_MAFIOSO.Build);
        public static void TellMafiaAboutMafiosoPromotion(this MessageParser parser, PlayerID promoted) => parser.Parse((byte)ServerMessageType.TELL_MAFIA_ABOUT_MAFIOSO_PROMOTION, (buffer, index) => TELL_MAFIA_ABOUT_MAFIOSO_PROMOTION.Build(buffer, index).Parse(promoted));
        public static void ExecutionerConvertedToJester(this MessageParser parser) => parser.Parse((byte)ServerMessageType.EXECUTIONER_CONVERTED_TO_JESTER, EXECUTIONER_CONVERTED_TO_JESTER.Build);
        public static void AmnesiacBecameMafiaOrWitch(this MessageParser parser, PlayerID player, RoleID role) => parser.Parse((byte)ServerMessageType.AMNESIAC_BECAME_MAFIA_OR_WITCH, (buffer, index) => AMNESIAC_BECAME_MAFIA_OR_WITCH.Build(buffer, index).Parse(player).Parse(role));
        public static void UserDisconnected(this MessageParser parser, PlayerID player) => parser.Parse((byte)ServerMessageType.USER_DISCONNECTED, (buffer, index) => USER_DISCONNECTED.Build(buffer, index).Parse(player));
        public static void MafiaWasJailed(this MessageParser parser, PlayerID jailed) => parser.Parse((byte)ServerMessageType.MAFIA_WAS_JAILED, (buffer, index) => MAFIA_WAS_JAILED.Build(buffer, index).Parse(jailed));
        public static void InvalidNameMessage(this MessageParser parser, InvalidNameStatus status) => parser.Parse((byte)ServerMessageType.INVALID_NAME_MESSAGE, (buffer, index) => INVALID_NAME_MESSAGE.Build(buffer, index).Parse(status));
        public static void StartNightTransition(this MessageParser parser) => parser.Parse((byte)ServerMessageType.START_NIGHT_TRANSITION, START_NIGHT_TRANSITION.Build);
        public static void StartDayTransition(this MessageParser parser, params PlayerID[] deaths) => parser.Parse((byte)ServerMessageType.START_DAY_TRANSITION, (buffer, index) => START_DAY_TRANSITION.Build(buffer, index).Parse(deaths, (death, p) => p.Parse(death)));
        public static void LynchUser(this MessageParser parser) => parser.Parse((byte)ServerMessageType.LYNCH_USER, LYNCH_USER.Build);
        public static void DeathNote(this MessageParser parser, PlayerID player, bool longTimer, string note) => parser.Parse((byte)ServerMessageType.DEATH_NOTE, (buffer, index) => DEATH_NOTE.Build(buffer, index).Parse(player).Parse(longTimer).Parse(note));
        public static void HousesChosen(this MessageParser parser, params (PlayerID player, HouseID house)[] choices) => parser.Parse((byte)ServerMessageType.HOUSES_CHOSEN, (buffer, index) => HOUSES_CHOSEN.Build(buffer, index).Parse(choices, (choice, p) => p.Parse(choice.player).Parse(choice.house)));
        public static void FirstDayTransition(this MessageParser parser) => parser.Parse((byte)ServerMessageType.FIRST_DAY_TRANSITION, FIRST_DAY_TRANSITION.Build);
        public static void CharactersChosen(this MessageParser parser, params (PlayerID player, CharacterID character)[] choices) => parser.Parse((byte)ServerMessageType.CHARACTERS_CHOSEN, (buffer, index) => CHARACTERS_CHOSEN.Build(buffer, index).Parse(choices, (choice, p) => p.Parse(choice.player).Parse(choice.character)));
        public static void ResurrectionSetAlive(this MessageParser parser, PlayerID player) => parser.Parse((byte)ServerMessageType.RESURRECTION_SET_ALIVE, (buffer, index) => RESURRECTION_SET_ALIVE.Build(buffer, index).Parse(player));
        public static void StartDefense(this MessageParser parser) => parser.Parse((byte)ServerMessageType.START_DEFENSE, START_DEFENSE.Build);
        public static void UserLeftDuringSelection(this MessageParser parser, PlayerID player) => parser.Parse((byte)ServerMessageType.USER_LEFT_DURING_SELECTION, (buffer, index) => USER_LEFT_DURING_SELECTION.Build(buffer, index).Parse(player));
        public static void VigilanteKilledTown(this MessageParser parser) => parser.Parse((byte)ServerMessageType.VIGILANTE_KILLED_TOWN, VIGILANTE_KILLED_TOWN.Build);
        public static void NotifyUsersOfPrivateMessage(this MessageParser parser, PlayerID src, PlayerID dst) => parser.Parse((byte)ServerMessageType.NOTIFY_USERS_OF_PRIVATE_MESSAGE, (buffer, index) => NOTIFY_USERS_OF_PRIVATE_MESSAGE.Build(buffer, index).Parse(src).Parse(dst));
        public static void PrivateMessage(this MessageParser parser, PrivateMessageType type, PlayerID with, string message, PlayerID? dst = null) => parser.Parse((byte)ServerMessageType.PRIVATE_MESSAGE, (buffer, index) => PRIVATE_MESSAGE.Build(buffer, index).Parse(type).Parse(with).Parse(dst == null, p => p.Parse(message), p => p.Parse(dst ?? default(PlayerID)).Parse(message)));
        public static void EarnedAchievements161(this MessageParser parser, params AchievementID[] achievements) => parser.Parse((byte)ServerMessageType.EARNED_ACHIEVEMENTS_161, (buffer, index) => EARNED_ACHIEVEMENTS_161.Build(buffer, index).Parse(achievements, (achievement, p) => p.Parse(achievement)));
        public static void AuthenticationFailed(this MessageParser parser, AuthenticationResult result, uint? timer = null) => parser.Parse((byte)ServerMessageType.AUTHENTICATION_FAILED, (buffer, index) => AUTHENTICATION_FAILED.Build(buffer, index).Parse(result).Parse(timer != null, p => p.Parse(timer ?? 0), p => p));
        public static void SpyNightAbilityMessage(this MessageParser parser, bool isCoven, PlayerID visited) => parser.Parse((byte)ServerMessageType.SPY_NIGHT_ABILITY_MESSAGE, (buffer, index) => SPY_NIGHT_ABILITY_MESSAGE.Build(buffer, index).Parse(isCoven).Parse(visited));
        public static void OneDayBeforeStalemate(this MessageParser parser) => parser.Parse((byte)ServerMessageType.ONE_DAY_BEFORE_STALEMATE, ONE_DAY_BEFORE_STALEMATE.Build);
        public static void PetsChosen(this MessageParser parser, params (PlayerID player, PetID pet)[] pets) => parser.Parse((byte)ServerMessageType.PETS_CHOSEN, (buffer, index) => PETS_CHOSEN.Build(buffer, index).Parse(pets, (pet, p) => p.Parse(pet.player).Parse(pet.pet)));
        public static void FacebookShareAchievement(this MessageParser parser, AchievementID achievement) => parser.Parse((byte)ServerMessageType.FACEBOOK_SHARE_ACHIEVEMENT, (buffer, index) => FACEBOOK_SHARE_ACHIEVEMENT.Build(buffer, index).Parse(achievement));
        public static void FacebookShareWin(this MessageParser parser, FactionID faction) => parser.Parse((byte)ServerMessageType.FACEBOOK_SHARE_WIN, (buffer, index) => FACEBOOK_SHARE_WIN.Build(buffer, index).Parse(faction));
        public static void DeathAnimationsChosen(this MessageParser parser, params (PlayerID player, DeathAnimationID animation)[] animations) => parser.Parse((byte)ServerMessageType.DEATH_ANIMATIONS_CHOSEN, (buffer, index) => DEATH_ANIMATIONS_CHOSEN.Build(buffer, index).Parse(animations, (animation, p) => p.Parse(animation.player).Parse(animation.animation)));
        public static void FullMoonNight(this MessageParser parser) => parser.Parse((byte)ServerMessageType.FULL_MOON_NIGHT, FULL_MOON_NIGHT.Build);
        public static void Identify(this MessageParser parser, string message) => parser.Parse((byte)ServerMessageType.IDENTIFY, (buffer, index) => IDENTIFY.Build(buffer, index).Parse(message));
        public static void EndGameInfo(this MessageParser parser, uint timeout, GameModeID mode, FactionID winningFaction, bool won, byte eloChange, byte mpGain, params (string name, string username, PlayerID id, RoleID[] roles)[] players) => parser.Parse((byte)ServerMessageType.END_GAME_INFO, (buffer, index) => END_GAME_INFO.Build(buffer, index).Parse(timeout).Parse(mode).Parse(winningFaction).Parse(won).Parse(eloChange).Parse(mpGain).Parse(players, (player, p) => p.Parse(player.name).Parse(player.username).Parse(player.id).Parse(player.roles, (role, p2) => p2.Parse(role)).Parse(null)));
        public static void EndGameChatMessage(this MessageParser parser, PlayerID player, string message) => parser.Parse((byte)ServerMessageType.END_GAME_CHAT_MESSAGE, (buffer, index) => END_GAME_CHAT_MESSAGE.Build(buffer, index).Parse(player).Parse(message));
        public static void EndGameUserUpdate(this MessageParser parser, params (PlayerID player, bool left)[] updates) => parser.Parse((byte)ServerMessageType.END_GAME_USER_UPDATE, (buffer, index) => END_GAME_USER_UPDATE.Build(buffer, index).Parse(updates, (update, p) => p.Parse(update.player).Parse(update.left)));
        public static void RoleLotsInfoMessage(this MessageParser parser, params (RoleID role, uint totalSlots, uint yourSlots)[] lots) => parser.Parse((byte)ServerMessageType.ROLE_LOTS_INFO_MESSAGE, (buffer, index) => ROLE_LOTS_INFO_MESSAGE.Build(buffer, index).Parse(lots, (lot, p) => p.Parse(lot.role).Parse(lot.totalSlots).Parse(lot.yourSlots)));
        public static void ExternalPurchase(this MessageParser parser, Uri uri) => parser.Parse((byte)ServerMessageType.EXTERNAL_PURCHASE, (buffer, index) => EXTERNAL_PURCHASE.Build(buffer, index).Parse(uri));
        public static void VampirePromotion(this MessageParser parser) => parser.Parse((byte)ServerMessageType.VAMPIRE_PROMOTION, VAMPIRE_PROMOTION.Build);
        public static void OtherVampires(this MessageParser parser, params (PlayerID player, bool youngest)[] vampires) => parser.Parse((byte)ServerMessageType.OTHER_VAMPIRES, (buffer, index) => OTHER_VAMPIRES.Build(buffer, index).Parse(vampires, (vampire, p) => p.Parse(vampire.player).Parse(vampire.youngest)));
        public static void AddVampire(this MessageParser parser, PlayerID player, bool youngest) => parser.Parse((byte)ServerMessageType.ADD_VAMPIRE, (buffer, index) => ADD_VAMPIRE.Build(buffer, index).Parse(player).Parse(youngest));
        public static void CanVampiresConvert(this MessageParser parser, bool canConvert) => parser.Parse((byte)ServerMessageType.CAN_VAMPIRES_CONVERT, (buffer, index) => CAN_VAMPIRES_CONVERT.Build(buffer, index).Parse(canConvert));
        public static void VampireDied(this MessageParser parser, PlayerID player, PlayerID? newYoungest = null) => parser.Parse((byte)ServerMessageType.VAMPIRE_DIED, (buffer, index) => VAMPIRE_DIED.Build(buffer, index).Parse(player).Parse(newYoungest.ToOption()));
        public static void VampireHunterPromoted(this MessageParser parser) => parser.Parse((byte)ServerMessageType.VAMPIRE_HUNTER_PROMOTED, VAMPIRE_HUNTER_PROMOTED.Build);
        public static void VampireVisitedMessage(this MessageParser parser, PlayerID player) => parser.Parse((byte)ServerMessageType.VAMPIRE_VISITED_MESSAGE, (buffer, index) => VAMPIRE_VISITED_MESSAGE.Build(buffer, index).Parse(player));
        public static void CheckUsernameResult(this MessageParser parser, bool available) => parser.Parse((byte)ServerMessageType.CHECK_USERNAME_RESULT, (buffer, index) => CHECK_USERNAME_RESULT.Build(buffer, index).Parse(available));
        public static void NameChangeResult(this MessageParser parser, NameChangeResult result) => parser.Parse((byte)ServerMessageType.NAME_CHANGE_RESULT, (buffer, index) => NAME_CHANGE_RESULT.Build(buffer, index).Parse(result));
        public static void AccountState(this MessageParser parser, AccountState state) => parser.Parse((byte)ServerMessageType.ACCOUNT_STATE, (buffer, index) => ACCOUNT_STATE.Build(buffer, index).Parse(state));
        public static void PurchasedAccountItems(this MessageParser parser, params AccountItemID[] items) => parser.Parse((byte)ServerMessageType.PURCHASED_ACCOUNT_ITEMS, (buffer, index) => PURCHASED_ACCOUNT_ITEMS.Build(buffer, index).Parse(items, (item, p) => p.Parse(item)));
        public static void AccountItemConsumed(this MessageParser parser, AccountItemID item, uint consumed, uint remaining) => parser.Parse((byte)ServerMessageType.ACCOUNT_ITEM_CONSUMED, (buffer, index) => ACCOUNT_ITEM_CONSUMED.Build(buffer, index).Parse(item).Parse(consumed).Parse(remaining));
        public static void TransporterNotification(this MessageParser parser, PlayerID player1, PlayerID player2) => parser.Parse((byte)ServerMessageType.TRANSPORTER_NOTIFICATION, (buffer, index) => TRANSPORTER_NOTIFICATION.Build(buffer, index).Parse(player1).Parse(player2));
        public static void ProductPurchaseResult(this MessageParser parser, ShopItemID purchasedItem, uint quantity, PurchaseSourceID source, uint sourceData, PurchaseResult result, ItemType itemType, params (ItemType type, uint id)[] items) => parser.Parse((byte)ServerMessageType.PRODUCT_PURCHASE_RESULT, (buffer, index) => PRODUCT_PURCHASE_RESULT.Build(buffer, index).Parse(purchasedItem).Parse(quantity).Parse(source).Parse(sourceData).Parse(result).Parse(itemType).Parse(items.Length > 0, p => p.Parse(items, (item, p2) => p2.Parse(item.type).Parse(item.id)), p => p));
        public static void UpdateFreeCurrency(this MessageParser parser, uint amount) => parser.Parse((byte)ServerMessageType.UPDATE_FREE_CURRENCY, (buffer, index) => UPDATE_FREE_CURRENCY.Build(buffer, index).Parse(amount));
        public static void ActiveEvents(this MessageParser parser, params (uint type, string uiFilter, uint startingSeconds, uint endingSeconds)[] events) => parser.Parse((byte)ServerMessageType.ACTIVE_EVENTS, (buffer, index) => ACTIVE_EVENTS.Build(buffer, index).Parse(events, (evt, p) => p.Parse(evt.type).Parse(evt.uiFilter).Parse(evt.startingSeconds).Parse(evt.endingSeconds)));
        public static void CauldronStatus(this MessageParser parser, CauldronRewardType rewardType, uint progress, uint progressTarget, bool complete, uint freePotionCooldown, IEnumerable<CauldronPotionID> purchasablePotions, params (ItemType type, uint id, uint quantity)[] rewards) => parser.Parse((byte)ServerMessageType.CAULDRON_STATUS, (buffer, index) => CAULDRON_STATUS.Build(buffer, index).Parse(rewardType).Parse(progress).Parse(progressTarget).Parse(complete).Parse(freePotionCooldown).Parse(purchasablePotions, (potion, p) => p.Parse(potion)).Parse(rewards, (reward, p) => p.Parse(reward.type).Parse(reward.id).Parse(reward.quantity)));
        public static void TauntResult(this MessageParser parser, PlayerID player, TauntTargetType type, TauntID taunt, bool success) => parser.Parse((byte)ServerMessageType.TAUNT_RESULT, (buffer, index) => TAUNT_RESULT.Build(buffer, index).Parse(player).Parse(type).Parse(taunt).Parse(success));
        public static void TauntActivated(this MessageParser parser, PlayerID player, TauntTargetType type, TauntID taunt) => parser.Parse((byte)ServerMessageType.TAUNT_ACTIVATED, (buffer, index) => TAUNT_ACTIVATED.Build(buffer, index).Parse(player).Parse(type).Parse(taunt));
        public static void TauntConsumed(this MessageParser parser, TauntID taunt) => parser.Parse((byte)ServerMessageType.TAUNT_CONSUMED, (buffer, index) => TAUNT_CONSUMED.Build(buffer, index).Parse(taunt));
        public static void TrackerNightAbility(this MessageParser parser, PlayerID visited) => parser.Parse((byte)ServerMessageType.TRACKER_NIGHT_ABILITY, (buffer, index) => TRACKER_NIGHT_ABILITY.Build(buffer, index).Parse(visited));
        public static void AmbusherNightAbility(this MessageParser parser, PlayerID ambusher) => parser.Parse((byte)ServerMessageType.AMBUSHER_NIGHT_ABILITY, (buffer, index) => AMBUSHER_NIGHT_ABILITY.Build(buffer, index).Parse(ambusher));
        public static void GuardianAngelProtection(this MessageParser parser, PlayerID target) => parser.Parse((byte)ServerMessageType.GUARDIAN_ANGEL_PROTECTION, (buffer, index) => GUARDIAN_ANGEL_PROTECTION.Build(buffer, index).Parse(target));
        public static void PirateDuel(this MessageParser parser) => parser.Parse((byte)ServerMessageType.PIRATE_DUEL, PIRATE_DUEL.Build);
        public static void DuelTarget(this MessageParser parser, PlayerID target) => parser.Parse((byte)ServerMessageType.DUEL_TARGET, (buffer, index) => DUEL_TARGET.Build(buffer, index).Parse(target));
        public static void PotionMasterPotions(this MessageParser parser, byte healCooldown, byte attackCooldown, byte investigateCooldown) => parser.Parse((byte)ServerMessageType.POTION_MASTER_POTIONS, (buffer, index) => POTION_MASTER_POTIONS.Build(buffer, index).Parse(healCooldown).Parse(attackCooldown).Parse(investigateCooldown));
        public static void HasNecronomicon(this MessageParser parser, byte? nightsUntil = null) => parser.Parse((byte)ServerMessageType.HAS_NECRONOMICON, (buffer, index) => HAS_NECRONOMICON.Build(buffer, index).Parse(nightsUntil != null).Parse(nightsUntil == null, p => p, p => p.Parse(nightsUntil ?? 0)));
        public static void OtherWitches(this MessageParser parser, params (PlayerID id, RoleID role)[] witches) => parser.Parse((byte)ServerMessageType.OTHER_WITCHES, (buffer, index) => OTHER_WITCHES.Build(buffer, index).Parse(witches, (witch, p) => p.Parse(witch.id).Parse(witch.role)));
        public static void PsychicNightAbility(this MessageParser parser, PlayerID player1, PlayerID player2, PlayerID? player3 = null) => parser.Parse((byte)ServerMessageType.PSYCHIC_NIGHT_ABILITY, (buffer, index) => PSYCHIC_NIGHT_ABILITY.Build(buffer, index).Parse(player3 != null).Parse(player1).Parse(player2).Parse(player3 == null, p => p, p => p.Parse(player3 ?? default(PlayerID))));
        public static void TrapperNightAbility(this MessageParser parser, RoleID caughtRole) => parser.Parse((byte)ServerMessageType.TRAPPER_NIGHT_ABILITY, (buffer, index) => TRAPPER_NIGHT_ABILITY.Build(buffer, index).Parse(caughtRole));
        public static void TrapperTrapStatus(this MessageParser parser, TrapStatus status) => parser.Parse((byte)ServerMessageType.TRAPPER_TRAP_STATUS, (buffer, index) => TRAPPER_TRAP_STATUS.Build(buffer, index).Parse(status));
        public static void PestilenceConversion(this MessageParser parser) => parser.Parse((byte)ServerMessageType.PESTILENCE_CONVERSION, PESTILENCE_CONVERSION.Build);
        public static void JuggernautKillCount(this MessageParser parser, byte killCount) => parser.Parse((byte)ServerMessageType.JUGGERNAUT_KILL_COUNT, (buffer, index) => JUGGERNAUT_KILL_COUNT.Build(buffer, index).Parse(killCount));
        public static void CovenGotNecronomicon(this MessageParser parser, PlayerID owner, PlayerID? newOwner = null) => parser.Parse((byte)ServerMessageType.COVEN_GOT_NECRONOMICON, (buffer, index) => COVEN_GOT_NECRONOMICON.Build(buffer, index).Parse(newOwner != null).Parse(owner).Parse(newOwner == null, p => p, p => p.Parse(newOwner ?? default(PlayerID))));
        public static void GuardianAngelPromoted(this MessageParser parser) => parser.Parse((byte)ServerMessageType.GUARDIAN_ANGEL_PROMOTED, GUARDIAN_ANGEL_PROMOTED.Build);
        public static void VIPTarget(this MessageParser parser, PlayerID vip) => parser.Parse((byte)ServerMessageType.VIP_TARGET, (buffer, index) => VIP_TARGET.Build(buffer, index).Parse(vip));
        public static void PirateDuelOutcome(this MessageParser parser, DuelAttackID attack, DuelDefenseID defense) => parser.Parse((byte)ServerMessageType.PIRATE_DUEL_OUTCOME, (buffer, index) => PIRATE_DUEL_OUTCOME.Build(buffer, index).Parse(attack).Parse(defense));
        public static void HostSetPartyConfigResult(this MessageParser parser, BrandID brand, GameModeID mode, SetConfigResult result) => parser.Parse((byte)ServerMessageType.HOST_SET_PARTY_CONFIG_RESULT, (buffer, index) => HOST_SET_PARTY_CONFIG_RESULT.Build(buffer, index).Parse(brand).Parse(mode).Parse(result));
        public static void ActiveGameModes(this MessageParser parser, params GameModeID[] modes) => parser.Parse((byte)ServerMessageType.ACTIVE_GAME_MODES, (buffer, index) => ACTIVE_GAME_MODES.Build(buffer, index).Parse(modes, (mode, p) => p.Parse(mode)));
        public static void AccountFlags(this MessageParser parser, AccountFlags flags) => parser.Parse((byte)ServerMessageType.ACCOUNT_FLAGS, (buffer, index) => ACCOUNT_FLAGS.Build(buffer, index).Parse(flags));
        public static void ZombieRotted(this MessageParser parser, PlayerID player) => parser.Parse((byte)ServerMessageType.ZOMBIE_ROTTED, (buffer, index) => ZOMBIE_ROTTED.Build(buffer, index).Parse(player));
        public static void LoverTarget(this MessageParser parser, PlayerID player) => parser.Parse((byte)ServerMessageType.LOVER_TARGET, (buffer, index) => LOVER_TARGET.Build(buffer, index).Parse(player));
        public static void PlagueSpread(this MessageParser parser, PlayerID player) => parser.Parse((byte)ServerMessageType.PLAGUE_SPREAD, (buffer, index) => PLAGUE_SPREAD.Build(buffer, index).Parse(player));
        public static void RivalTarget(this MessageParser parser, PlayerID player) => parser.Parse((byte)ServerMessageType.RIVAL_TARGET, (buffer, index) => RIVAL_TARGET.Build(buffer, index).Parse(player));
        public static void RankedInfo(this MessageParser parser, GameModeID mode, uint practiceGamesPlayed, uint careerWins, uint careerLosses, uint careerDraws, uint careerLeaves, uint careerHighRating, uint seasonNumber, bool offseason, uint placementGamesNeeded, uint seasonWins, uint seasonLosses, uint seasonDraws, uint seasonLeaves, uint seasonHighRating, uint seasonRating) => parser.Parse((byte)ServerMessageType.RANKED_INFO, (buffer, index) => RANKED_INFO.Build(buffer, index).Parse(mode).Parse(practiceGamesPlayed).Parse(careerWins).Parse(careerLosses).Parse(careerDraws).Parse(careerLeaves).Parse(careerHighRating).Parse(seasonNumber).Parse(offseason).Parse(placementGamesNeeded).Parse(seasonWins).Parse(seasonLosses).Parse(seasonDraws).Parse(seasonLeaves).Parse(seasonHighRating).Parse(seasonRating));
        public static void JailorDeathNote(this MessageParser parser, PlayerID player, bool longTimer, ExecuteReasonID note) => parser.Parse((byte)ServerMessageType.JAILOR_DEATH_NOTE, (buffer, index) => JAILOR_DEATH_NOTE.Build(buffer, index).Parse(player).Parse(longTimer).Parse(note));
        public static void Disconnected(this MessageParser parser, DisconnectReasonID reason) => parser.Parse((byte)ServerMessageType.DISCONNECTED, (buffer, index) => DISCONNECTED.Build(buffer, index).Parse(reason));
        public static void SpyNightInfo(this MessageParser parser, params LocalizationTableID[] messages) => parser.Parse((byte)ServerMessageType.SPY_NIGHT_INFO, (buffer, index) => SPY_NIGHT_INFO.Build(buffer, index).Parse(messages, (message, p) => p.Parse(message)));
        public static void ServerFlags(this MessageParser parser, params bool[] flags) => parser.Parse((byte)ServerMessageType.SERVER_FLAGS, (buffer, index) => SERVER_FLAGS.Build(buffer, index).Parse(flags, (flag, p) => p.Parse(flag)));
    }
}
