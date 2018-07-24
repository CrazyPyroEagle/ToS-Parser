using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToSParser
{
    public enum ClientMessageType : byte
    {
        RESERVED,
        AUTHENTICATE_FACEBOOK,
        AUTHENTICATE,
        SEND_CHAT_BOX_MESSAGE,
        CLICKED_ON_CATALOG,
        CLICKED_ON_POSSIBLE_ROLES,
        CLICKED_ON_ADD_BUTTON,
        CLICKED_ON_REMOVE_BUTTON,
        SEND_PRIVATE_MESSAGE,
        CLICKED_ON_START_BUTTON,
        SET_VOTE,
        SET_TARGET,
        SET_SECOND_TARGET,
        UNKNOWN_TYPE_13,
        JUDGEMENT_VOTE_GUILTY,
        JUDGEMENT_VOTE_INNOCENT,
        SET_DAY_CHOICE,
        SAVE_LAST_WILL,
        SAVE_DEATH_NOTE,
        SET_TARGET_MAFIA_OR_WITCH,
        UPDATE_CUSTOMIZATIONS,
        CHOOSE_NAME,
        REPORT_PLAYER,
        VOTE_TO_REPICK_HOST,
        SEND_SYSTEM_MESSAGE,
        REQUEST_FRIEND,
        ACCEPT_FRIEND,
        REMOVE_FRIEND,
        DECLINE_FRIEND_REQUEST,
        SEND_FRIEND_MESSAGE,
        JOIN_LOBBY,
        CREATE_PARTY,
        INVITE_TO_PARTY,
        RESPOND_PARTY_INVITE,
        REQUEST_LEAVE_PARTY,
        PARTY_START,
        SEND_PARTY_MESSAGE,
        UPDATE_SETTINGS,
        UPDATE_AFK_STATUS,
        LEAVE_GAME,
        UNKNOWN_TYPE_40,
        UNKNOWN_TYPE_41,
        UNKNOWN_TYPE_42,
        UNKNOWN_TYPE_43,
        UNKNOWN_TYPE_44,
        REDEEM_CODE,
        UNKNOWN_TYPE_46,
        UNKNOWN_TYPE_47,
        UNKNOWN_TYPE_48,
        UNKNOWN_TYPE_49,
        UNKNOWN_TYPE_50,
        UNKNOWN_TYPE_51,
        SET_PARTY_HOST,
        KICK_FROM_PARTY,
        GIVE_PARTY_INVITE_POWER,
        REQUEST_PURCHASE_STEAM,
        UNKNOWN_TYPE_56,
        REGISTER_STEAM,
        REGISTER_FORUMS,
        LINK_STEAM,
        JOIN_RANKED_QUEUE,
        LEAVE_RANKED_QUEUE,
        ACCEPT_RANKED,
        LEAVE_POST_GAME_LOBBY,
        SAVE_FORGED_WILL,
        REQUEST_PLAYER_STATISTICS,
        UNKNOWN_TYPE_66,
        ACCEPT_PROMOTION,
        UNKNOWN_TYPE_68,
        UNKNOWN_TYPE_69,
        CHECK_USERNAME,
        UNKNOWN_TYPE_71,
        UNKNOWN_TYPE_72,
        REQUEST_NAME_CHANGE,
        REQUEST_PURCHASE,
        REQUEST_CAULDRON_STATUS,
        COLLECT_CAULDRON_PRIZE,
        USE_TAUNT,
        SET_PIRATE_CHOICE,
        SET_POTION_MASTER_CHOICE,
        SET_PARTY_CONFIG,
        NOTIFY_OF_BRAND_OWNERSHIP,
        SET_HYPNOTIST_CHOICE,
        SET_JAILOR_DEATH_NOTE
    }

    public static class ClientMessageParsers
    {
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> AUTHENTICATE_FACEBOOK = Parsers.STRING;
        public static readonly ParserBuilder<Parser<AuthenticationMode, ConditionalParser<Parser<bool, Parser<bool, Parser<uint, ConditionalParser<Parser<string, Parser<string, ConditionalParser<Parser<string, RootParser>, RootParser>>>, RootParser>>>>, Parser<string, RootParser>>>, Writer<AuthenticationMode, ConditionalWriter<Writer<bool, Writer<bool, Writer<uint, ConditionalWriter<Writer<string, Writer<string, ConditionalWriter<Writer<string, RootWriter>, RootWriter>>>, RootWriter>>>>, Writer<string, RootWriter>>>> AUTHENTICATE = Parsers.ROOT.After(Converters.STRING, 0x1E).Condition(Parsers.ROOT).After(Converters.STRING, 0x1E).After(Converters.STRING, 0x1E).Condition(Parsers.ROOT).After(Converters.UInt<uint>()).After(Converters.BOOLEAN1).After(Converters.BOOLEAN1).Condition(Parsers.STRING).After(Converters.Byte<AuthenticationMode>());
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> SEND_CHAT_BOX_MESSAGE = Parsers.STRING;
        public static readonly ParserBuilder<Parser<Catalog, RootParser>, Writer<Catalog, RootWriter>> CLICKED_ON_CATALOG = Parsers.CATALOG;
        public static readonly ParserBuilder<Parser<byte, Parser<byte, RootParser>>, Writer<byte, Writer<byte, RootWriter>>> CLICKED_ON_POSSIBLE_ROLES = Parsers.BYTE2;
        public static readonly ParserBuilder<Parser<Role, RootParser>, Writer<Role, RootWriter>> CLICKED_ON_ADD_BUTTON = Parsers.ROLE;
        public static readonly ParserBuilder<Parser<byte, RootParser>, Writer<byte, RootWriter>> CLICKED_ON_REMOVE_BUTTON = Parsers.BYTE;
        public static readonly ParserBuilder<Parser<Player, Parser<string, RootParser>>, Writer<Player, Writer<string, RootWriter>>> SEND_PRIVATE_MESSAGE = Parsers.PLAYER_STRING;
        public static readonly RootBuilder CLICKED_ON_START_BUTTON = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> SET_VOTE = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> SET_TARGET = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> SET_SECOND_TARGET = Parsers.PLAYER;
        public static readonly RootBuilder JUDGEMENT_VOTE_GUILTY = Parsers.ROOT;
        public static readonly RootBuilder JUDGEMENT_VOTE_INNOCENT = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<Player, RootParser>, Writer<Player, RootWriter>> SET_DAY_CHOICE = Parsers.PLAYER;
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> SAVE_LAST_WILL = Parsers.STRING;
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> SAVE_DEATH_NOTE = Parsers.STRING;
        public static readonly ParserBuilder<Parser<Player, Parser<TargetType, RootParser>>, Writer<Player, Writer<TargetType, RootWriter>>> SET_TARGET_MAFIA_OR_WITCH = Parsers.ROOT.After(Converters.Byte<TargetType>()).After(Converters.Byte<Player>());
        public static readonly ParserBuilder<Parser<Character, Parser<House, Parser<Background, Parser<Pet?, Parser<LobbyIcon, Parser<DeathAnimation, Parser<Scroll?, Parser<Scroll?, Parser<Scroll?, Parser<string, RootParser>>>>>>>>>>, Writer<Character, Writer<House, Writer<Background, Writer<Pet?, Writer<LobbyIcon, Writer<DeathAnimation, Writer<Scroll?, Writer<Scroll?, Writer<Scroll?, Writer<string, RootWriter>>>>>>>>>>> UPDATE_CUSTOMIZATIONS = Parsers.ROOT.After(Converters.STRING, 0x2C).After(Converters.Safe(Converters.UInt<Scroll>(), "-2"), 0x2C).After(Converters.Safe(Converters.UInt<Scroll>(), "-2"), 0x2C).After(Converters.Safe(Converters.UInt<Scroll>(), "-2"), 0x2C).After(Converters.UInt<DeathAnimation>(), 0x2C).After(Converters.UInt<LobbyIcon>(), 0x2C).After(Converters.Safe(Converters.UInt<Pet>(), "-2"), 0x2C).After(Converters.UInt<Background>(), 0x2C).After(Converters.UInt<House>(), 0x2C).After(Converters.UInt<Character>());
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> CHOOSE_NAME = Parsers.STRING;
        public static readonly ParserBuilder<Parser<Player, Parser<ReportReason, Parser<string, RootParser>>>, Writer<Player, Writer<ReportReason, Writer<string, RootWriter>>>> REPORT_PLAYER = Parsers.ROOT.After(Converters.STRING).After(Converters.Byte<ReportReason>()).After(Converters.Byte<Player>());
        public static readonly RootBuilder VOTE_TO_REPICK_HOST = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<SystemCommand, Parser<string, RootParser>>, Writer<SystemCommand, Writer<string, RootWriter>>> SEND_SYSTEM_MESSAGE = Parsers.STRING.After(Converters.Byte<SystemCommand>());
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> REQUEST_FRIEND = Parsers.STRING;
        public static readonly ParserBuilder<Parser<string, Parser<uint, RootParser>>, Writer<string, Writer<uint, RootWriter>>> ACCEPT_FRIEND = Parsers.STRING_UINT_ASTERISK;
        public static readonly ParserBuilder<Parser<string, Parser<uint, RootParser>>, Writer<string, Writer<uint, RootWriter>>> REMOVE_FRIEND = Parsers.STRING_UINT_ASTERISK;
        public static readonly ParserBuilder<Parser<uint, RootParser>, Writer<uint, RootWriter>> DECLINE_FRIEND_REQUEST = Parsers.UINT;
        public static readonly ParserBuilder<Parser<string, Parser<string, RootParser>>, Writer<string, Writer<string, RootWriter>>> SEND_FRIEND_MESSAGE = Parsers.STRING2_ASTERISK;
        public static readonly ParserBuilder<Parser<GameMode, RootParser>, Writer<GameMode, RootWriter>> JOIN_LOBBY = Parsers.GAMEMODE;
        public static readonly ParserBuilder<Parser<Brand, RootParser>, Writer<Brand, RootWriter>> CREATE_PARTY = Parsers.BRAND;
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> INVITE_TO_PARTY = Parsers.STRING;
        public static readonly RootBuilder REQUEST_LEAVE_PARTY = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<PartyInviteResponse, Parser<uint, RootParser>>, Writer<PartyInviteResponse, Writer<uint, RootWriter>>> RESPOND_PARTY_INVITE = Parsers.ROOT.After(Converters.UInt<uint>()).After(Converters.Byte<PartyInviteResponse>());
        public static readonly ParserBuilder<Parser<GameMode, RootParser>, Writer<GameMode, RootWriter>> PARTY_START = Parsers.GAMEMODE;
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> SEND_PARTY_MESSAGE = Parsers.STRING;
        public static readonly ParserBuilder<Parser<Setting, Parser<byte, RootParser>>, Writer<Setting, Writer<byte, RootWriter>>> UPDATE_SETTINGS = Parsers.ROOT.After(Converters.Byte<byte>()).After(Converters.Byte<Setting>());
        public static readonly ParserBuilder<Parser<AFKStatus, RootParser>, Writer<AFKStatus, RootWriter>> UPDATE_AFK_STATUS = Parsers.ROOT.After(Converters.Byte<AFKStatus>());
        public static readonly RootBuilder LEAVE_GAME = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> REDEEM_CODE = Parsers.STRING;
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> SET_PARTY_HOST = Parsers.STRING;
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> KICK_FROM_PARTY = Parsers.STRING;
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> GIVE_PARTY_INVITE_POWER = Parsers.STRING;
        public static readonly ParserBuilder<Parser<SteamItem, Parser<string, RootParser>>, Writer<SteamItem, Writer<string, RootWriter>>> REQUEST_PURCHASE_STEAM = Parsers.STRING.After(Converters.Byte<SteamItem>());
        public static readonly ParserBuilder<Parser<byte, Parser<byte, Parser<byte, Parser<byte, Parser<string, Parser<string, Parser<string, Parser<string, Parser<string, RootParser>>>>>>>>>, Writer<byte, Writer<byte, Writer<byte, Writer<byte, Writer<string, Writer<string, Writer<string, Writer<string, Writer<string, RootWriter>>>>>>>>>> REGISTER_STEAM = Parsers.STRING.After(Converters.STRING).After(Converters.STRING).After(Converters.STRING).After(Converters.STRING).After(Converters.Byte<byte>()).After(Converters.Byte<byte>()).After(Converters.Byte<byte>()).After(Converters.Byte<byte>());
        public static readonly ParserBuilder<Parser<byte, Parser<byte, Parser<byte, Parser<string, Parser<string, Parser<string, Parser<string, RootParser>>>>>>>, Writer<byte, Writer<byte, Writer<byte, Writer<string, Writer<string, Writer<string, Writer<string, RootWriter>>>>>>>> REGISTER_FORUMS = Parsers.STRING.After(Converters.STRING).After(Converters.STRING).After(Converters.STRING).After(Converters.Byte<byte>()).After(Converters.Byte<byte>()).After(Converters.Byte<byte>());
        public static readonly ParserBuilder<Parser<byte, Parser<byte, Parser<string, Parser<string, Parser<string, RootParser>>>>>, Writer<byte, Writer<byte, Writer<string, Writer<string, Writer<string, RootWriter>>>>>> LINK_STEAM = Parsers.STRING.After(Converters.STRING).After(Converters.STRING).After(Converters.Byte<byte>()).After(Converters.Byte<byte>());
        public static readonly ParserBuilder<Parser<GameMode, RootParser>, Writer<GameMode, RootWriter>> JOIN_RANKED_QUEUE = Parsers.GAMEMODE;
        public static readonly RootBuilder LEAVE_RANKED_QUEUE = Parsers.ROOT;
        public static readonly RootBuilder ACCEPT_RANKED = Parsers.ROOT;
        public static readonly RootBuilder LEAVE_POST_GAME_LOBBY = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> SAVE_FORGED_WILL = Parsers.STRING;
        public static readonly RootBuilder REQUEST_PLAYER_STATISTICS = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<uint, RootParser>, Writer<uint, RootWriter>> ACCEPT_PROMOTION = Parsers.UINT;
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> CHECK_USERNAME = Parsers.STRING;
        public static readonly ParserBuilder<Parser<string, RootParser>, Writer<string, RootWriter>> REQUEST_NAME_CHANGE = Parsers.STRING;
        public static readonly ParserBuilder<Parser<ShopItem, Parser<uint, RootParser>>, Writer<ShopItem, Writer<uint, RootWriter>>> REQUEST_PURCHASE = Parsers.ROOT.After(Converters.UInt<uint>(), 0x2C).After(Converters.UInt<ShopItem>());
        public static readonly RootBuilder REQUEST_CAULDRON_STATUS = Parsers.ROOT;
        public static readonly RootBuilder COLLECT_CAULDRON_PRIZE = Parsers.ROOT;
        public static readonly ParserBuilder<Parser<Player, Parser<TauntTargetType, Parser<Taunt, RootParser>>>, Writer<Player, Writer<TauntTargetType, Writer<Taunt, RootWriter>>>> USE_TAUNT = Parsers.PLAYER_TYPE_TAUNT;
        public static readonly ParserBuilder<Parser<byte, RootParser>, Writer<byte, RootWriter>> SET_PIRATE_CHOICE = Parsers.BYTE;
        public static readonly ParserBuilder<Parser<Potion, RootParser>, Writer<Potion, RootWriter>> SET_POTION_MASTER_CHOICE = Parsers.ROOT.After(Converters.Byte<Potion>());
        public static readonly ParserBuilder<Parser<Brand, Parser<GameMode, RootParser>>, Writer<Brand, Writer<GameMode, RootWriter>>> SET_PARTY_CONFIG = Parsers.ROOT.After(Converters.Byte<GameMode>()).After(Converters.Byte<Brand>());
        public static readonly ParserBuilder<Parser<Brand, RootParser>, Writer<Brand, RootWriter>> NOTIFY_OF_BRAND_OWNERSHIP = Parsers.BRAND;
        public static readonly ParserBuilder<Parser<LocalizationTable, RootParser>, Writer<LocalizationTable, RootWriter>> SET_HYPNOTIST_CHOICE = Parsers.ROOT.After(Converters.UInt<LocalizationTable>());
        public static readonly ParserBuilder<Parser<ExecuteReason, RootParser>, Writer<ExecuteReason, RootWriter>> SET_JAILOR_DEATH_NOTE = Parsers.ROOT.After(Converters.Byte<ExecuteReason>());

        public static void AuthenticateFacebook(this MessageParser parser, string accessToken) => parser.Parse((byte)ClientMessageType.AUTHENTICATE_FACEBOOK, (buffer, index) => AUTHENTICATE_FACEBOOK.Build(buffer, index).Parse(accessToken));
        public static void Authenticate(this MessageParser parser, AuthenticationMode mode, bool encrypted = false, uint buildID = 0, string username = null, string password = null, string userID = null) => parser.Parse((byte)ClientMessageType.AUTHENTICATE, (buffer, index) => AUTHENTICATE.Build(buffer, index).Parse(mode).Parse(mode != AuthenticationMode.STEAM, p => p.Parse(encrypted).Parse(userID != null).Parse(buildID).Parse(mode != AuthenticationMode.VERIFIED_FACEBOOK, p2 => p2.Parse(username).Parse(userID ?? password).Parse(userID != null, p3 => p3.Parse(password), p3 => p3), p2 => p2), p => p.Parse(userID)));
        public static void SendChatBoxMessage(this MessageParser parser, string message) => parser.Parse((byte)ClientMessageType.SEND_CHAT_BOX_MESSAGE, (buffer, index) => SEND_CHAT_BOX_MESSAGE.Build(buffer, index).Parse(message));
        public static void ClickedOnCatalog(this MessageParser parser, Catalog catalog) => parser.Parse((byte)ClientMessageType.CLICKED_ON_CATALOG, (buffer, index) => CLICKED_ON_CATALOG.Build(buffer, index).Parse(catalog));
        public static void ClickedOnPossibleRoles(this MessageParser parser, byte selectedIndex, byte scrollPosition) => parser.Parse((byte)ClientMessageType.CLICKED_ON_POSSIBLE_ROLES, (buffer, index) => CLICKED_ON_POSSIBLE_ROLES.Build(buffer, index).Parse(selectedIndex).Parse(scrollPosition));
        public static void ClickedOnAddButton(this MessageParser parser, Role role) => parser.Parse((byte)ClientMessageType.CLICKED_ON_ADD_BUTTON, (buffer, index) => CLICKED_ON_ADD_BUTTON.Build(buffer, index).Parse(role));
        public static void ClickedOnRemoveButton(this MessageParser parser, byte slotIndex) => parser.Parse((byte)ClientMessageType.CLICKED_ON_REMOVE_BUTTON, (buffer, index) => CLICKED_ON_REMOVE_BUTTON.Build(buffer, index).Parse(slotIndex));
        public static void SendPrivateMessage(this MessageParser parser, Player dst, string msg) => parser.Parse((byte)ClientMessageType.SEND_PRIVATE_MESSAGE, (buffer, index) => SEND_PRIVATE_MESSAGE.Build(buffer, index).Parse(dst).Parse(msg));
        public static void ClickedOnStartButton(this MessageParser parser) => parser.Parse((byte)ClientMessageType.CLICKED_ON_START_BUTTON, CLICKED_ON_START_BUTTON.Build);
        public static void SetVote(this MessageParser parser, Player voted) => parser.Parse((byte)ClientMessageType.SET_VOTE, (buffer, index) => SET_VOTE.Build(buffer, index).Parse(voted));
        public static void SetTarget(this MessageParser parser, Player target) => parser.Parse((byte)ClientMessageType.SET_TARGET, (buffer, index) => SET_TARGET.Build(buffer, index).Parse(target));
        public static void SetSecondTarget(this MessageParser parser, Player target) => parser.Parse((byte)ClientMessageType.SET_SECOND_TARGET, (buffer, index) => SET_SECOND_TARGET.Build(buffer, index).Parse(target));
        public static void JudgementVoteGuilty(this MessageParser parser) => parser.Parse((byte)ClientMessageType.JUDGEMENT_VOTE_GUILTY, JUDGEMENT_VOTE_GUILTY.Build);
        public static void JudgementVoteInnocent(this MessageParser parser) => parser.Parse((byte)ClientMessageType.JUDGEMENT_VOTE_INNOCENT, JUDGEMENT_VOTE_INNOCENT.Build);
        public static void SetDayChoice(this MessageParser parser, Player choice) => parser.Parse((byte)ClientMessageType.SET_DAY_CHOICE, (buffer, index) => SET_DAY_CHOICE.Build(buffer, index).Parse(choice));
        public static void SaveLastWill(this MessageParser parser, string will) => parser.Parse((byte)ClientMessageType.SAVE_LAST_WILL, (buffer, index) => SAVE_LAST_WILL.Build(buffer, index).Parse(will));
        public static void SaveDeathNote(this MessageParser parser, string note) => parser.Parse((byte)ClientMessageType.SAVE_DEATH_NOTE, (buffer, index) => SAVE_DEATH_NOTE.Build(buffer, index).Parse(note));
        public static void SetTargetMafiaOrWitch(this MessageParser parser, Player target, TargetType type) => parser.Parse((byte)ClientMessageType.SET_TARGET_MAFIA_OR_WITCH, (buffer, index) => SET_TARGET_MAFIA_OR_WITCH.Build(buffer, index).Parse(target).Parse(type));
        public static void UpdateCustomizations(this MessageParser parser, Character character, House house, Background background, Pet? pet, LobbyIcon icon, DeathAnimation death, Scroll? scroll1, Scroll? scroll2, Scroll? scroll3, string name) => parser.Parse((byte)ClientMessageType.UPDATE_CUSTOMIZATIONS, (buffer, index) => UPDATE_CUSTOMIZATIONS.Build(buffer, index).Parse(character).Parse(house).Parse(background).Parse(pet).Parse(icon).Parse(death).Parse(scroll1).Parse(scroll2).Parse(scroll3).Parse(name));
        public static void ChooseName(this MessageParser parser, string name) => parser.Parse((byte)ClientMessageType.CHOOSE_NAME, (buffer, index) => CHOOSE_NAME.Build(buffer, index).Parse(name));
        public static void ReportPlayer(this MessageParser parser, Player player, ReportReason reason, string message) => parser.Parse((byte)ClientMessageType.REPORT_PLAYER, (buffer, index) => REPORT_PLAYER.Build(buffer, index).Parse(player).Parse(reason).Parse(message));
        public static void VoteToRepickHost(this MessageParser parser) => parser.Parse((byte)ClientMessageType.VOTE_TO_REPICK_HOST, VOTE_TO_REPICK_HOST.Build);
        public static void SendSystemMessage(this MessageParser parser, SystemCommand command, params string[] args) => parser.Parse((byte)ClientMessageType.SEND_SYSTEM_MESSAGE, (buffer, index) => SEND_SYSTEM_MESSAGE.Build(buffer, index).Parse(command).Parse(string.Join(" ", args)));
        public static void RequestFriend(this MessageParser parser, string username) => parser.Parse((byte)ClientMessageType.REQUEST_FRIEND, (buffer, index) => REQUEST_FRIEND.Build(buffer, index).Parse(username));
        public static void AcceptFriend(this MessageParser parser, string username, uint friend) => parser.Parse((byte)ClientMessageType.ACCEPT_FRIEND, (buffer, index) => ACCEPT_FRIEND.Build(buffer, index).Parse(username).Parse(friend));
        public static void RemoveFriend(this MessageParser parser, string username, uint friend) => parser.Parse((byte)ClientMessageType.REMOVE_FRIEND, (buffer, index) => REMOVE_FRIEND.Build(buffer, index).Parse(username).Parse(friend));
        public static void DeclineFriendRequest(this MessageParser parser, uint friend) => parser.Parse((byte)ClientMessageType.DECLINE_FRIEND_REQUEST, (buffer, index) => DECLINE_FRIEND_REQUEST.Build(buffer, index).Parse(friend));
        public static void SendFriendMessage(this MessageParser parser, string username, string message) => parser.Parse((byte)ClientMessageType.SEND_FRIEND_MESSAGE, (buffer, index) => SEND_FRIEND_MESSAGE.Build(buffer, index).Parse(username).Parse(message));
        public static void JoinLobby(this MessageParser parser, GameMode mode) => parser.Parse((byte)ClientMessageType.JOIN_LOBBY, (buffer, index) => JOIN_LOBBY.Build(buffer, index).Parse(mode));
        public static void CreateParty(this MessageParser parser, Brand brand) => parser.Parse((byte)ClientMessageType.CREATE_PARTY, (buffer, index) => CREATE_PARTY.Build(buffer, index).Parse(brand));
        public static void InviteToParty(this MessageParser parser, string username) => parser.Parse((byte)ClientMessageType.INVITE_TO_PARTY, (buffer, index) => INVITE_TO_PARTY.Build(buffer, index).Parse(username));
        public static void RequestLeaveParty(this MessageParser parser) => parser.Parse((byte)ClientMessageType.REQUEST_LEAVE_PARTY, REQUEST_LEAVE_PARTY.Build);
        public static void RespondPartyInvite(this MessageParser parser, PartyInviteResponse response, uint user) => parser.Parse((byte)ClientMessageType.RESPOND_PARTY_INVITE, (buffer, index) => RESPOND_PARTY_INVITE.Build(buffer, index).Parse(response).Parse(user));
        public static void PartyStart(this MessageParser parser, GameMode mode) => parser.Parse((byte)ClientMessageType.PARTY_START, (buffer, index) => PARTY_START.Build(buffer, index).Parse(mode));
        public static void SendPartyMessage(this MessageParser parser, string message) => parser.Parse((byte)ClientMessageType.SEND_PARTY_MESSAGE, (buffer, index) => SEND_PARTY_MESSAGE.Build(buffer, index).Parse(message));
        public static void UpdateSettings(this MessageParser parser, Setting setting, byte value) => parser.Parse((byte)ClientMessageType.UPDATE_SETTINGS, (buffer, index) => UPDATE_SETTINGS.Build(buffer, index).Parse(setting).Parse(value));
        public static void UpdateAFKStatus(this MessageParser parser, AFKStatus status) => parser.Parse((byte)ClientMessageType.UPDATE_AFK_STATUS, (buffer, index) => UPDATE_AFK_STATUS.Build(buffer, index).Parse(status));
        public static void LeaveGame(this MessageParser parser) => parser.Parse((byte)ClientMessageType.LEAVE_GAME, LEAVE_GAME.Build);
        public static void RedeemCode(this MessageParser parser, string code) => parser.Parse((byte)ClientMessageType.REDEEM_CODE, (buffer, index) => REDEEM_CODE.Build(buffer, index).Parse(code));
        public static void SetPartyHost(this MessageParser parser, string user) => parser.Parse((byte)ClientMessageType.SET_PARTY_HOST, (buffer, index) => SET_PARTY_HOST.Build(buffer, index).Parse(user));
        public static void KickFromParty(this MessageParser parser, string user) => parser.Parse((byte)ClientMessageType.KICK_FROM_PARTY, (buffer, index) => KICK_FROM_PARTY.Build(buffer, index).Parse(user));
        public static void GivePartyInvitePower(this MessageParser parser, string user) => parser.Parse((byte)ClientMessageType.GIVE_PARTY_INVITE_POWER, (buffer, index) => GIVE_PARTY_INVITE_POWER.Build(buffer, index).Parse(user));
        public static void RequestPurchaseSteam(this MessageParser parser, SteamItem item, string steamUserID) => parser.Parse((byte)ClientMessageType.REQUEST_PURCHASE_STEAM, (buffer, index) => REQUEST_PURCHASE_STEAM.Build(buffer, index).Parse(item).Parse(steamUserID));
        public static void RegisterSteam(this MessageParser parser, string username, string password, string email, string referrer, string steamAuthTicket) => parser.Parse((byte)ClientMessageType.REGISTER_STEAM, (buffer, index) => REGISTER_STEAM.Build(buffer, index).Parse((byte)username.Length).Parse((byte)password.Length).Parse((byte)email.Length).Parse((byte)referrer.Length).Parse(username).Parse(password).Parse(email).Parse(referrer).Parse(steamAuthTicket));
        public static void RegisterForums(this MessageParser parser, string username, string password, string email, string referrer) => parser.Parse((byte)ClientMessageType.REGISTER_FORUMS, (buffer, index) => REGISTER_FORUMS.Build(buffer, index).Parse((byte)username.Length).Parse((byte)password.Length).Parse((byte)email.Length).Parse(username).Parse(password).Parse(email).Parse(referrer));
        public static void LinkSteam(this MessageParser parser, string username, string password, string steamAuthTicket) => parser.Parse((byte)ClientMessageType.LINK_STEAM, (buffer, index) => LINK_STEAM.Build(buffer, index).Parse((byte)username.Length).Parse((byte)password.Length).Parse(username).Parse(password).Parse(steamAuthTicket));
        public static void JoinRankedQueue(this MessageParser parser, GameMode mode) => parser.Parse((byte)ClientMessageType.JOIN_RANKED_QUEUE, (buffer, index) => JOIN_RANKED_QUEUE.Build(buffer, index).Parse(mode));
        public static void LeaveRankedQueue(this MessageParser parser) => parser.Parse((byte)ClientMessageType.LEAVE_RANKED_QUEUE, LEAVE_RANKED_QUEUE.Build);
        public static void AcceptRanked(this MessageParser parser) => parser.Parse((byte)ClientMessageType.ACCEPT_RANKED, ACCEPT_RANKED.Build);
        public static void LeavePostGameLobby(this MessageParser parser) => parser.Parse((byte)ClientMessageType.LEAVE_POST_GAME_LOBBY, LEAVE_POST_GAME_LOBBY.Build);
        public static void SaveForgedWill(this MessageParser parser, string will) => parser.Parse((byte)ClientMessageType.SAVE_FORGED_WILL, (buffer, index) => SAVE_FORGED_WILL.Build(buffer, index).Parse(will));
        public static void RequestPlayerStatistics(this MessageParser parser) => parser.Parse((byte)ClientMessageType.REQUEST_PLAYER_STATISTICS, REQUEST_PLAYER_STATISTICS.Build);
        public static void AcceptPromotion(this MessageParser parser, uint refID) => parser.Parse((byte)ClientMessageType.ACCEPT_PROMOTION, (buffer, index) => ACCEPT_PROMOTION.Build(buffer, index).Parse(refID));
        public static void CheckUsername(this MessageParser parser, string username) => parser.Parse((byte)ClientMessageType.CHECK_USERNAME, (buffer, index) => CHECK_USERNAME.Build(buffer, index).Parse(username));
        public static void RequestNameChange(this MessageParser parser, string username) => parser.Parse((byte)ClientMessageType.REQUEST_NAME_CHANGE, (buffer, index) => REQUEST_NAME_CHANGE.Build(buffer, index).Parse(username));
        public static void RequestPurchase(this MessageParser parser, ShopItem item, uint amount) => parser.Parse((byte)ClientMessageType.REQUEST_PURCHASE, (buffer, index) => REQUEST_PURCHASE.Build(buffer, index).Parse(item).Parse(amount));
        public static void RequestCauldronStatus(this MessageParser parser) => parser.Parse((byte)ClientMessageType.REQUEST_CAULDRON_STATUS, REQUEST_CAULDRON_STATUS.Build);
        public static void CollectCauldronPrize(this MessageParser parser) => parser.Parse((byte)ClientMessageType.COLLECT_CAULDRON_PRIZE, COLLECT_CAULDRON_PRIZE.Build);
        public static void UseTaunt(this MessageParser parser, Player target, TauntTargetType type, Taunt taunt) => parser.Parse((byte)ClientMessageType.USE_TAUNT, (buffer, index) => USE_TAUNT.Build(buffer, index).Parse(target).Parse(type).Parse(taunt));
        public static void SetPirateChoice(this MessageParser parser, byte actionCode) => parser.Parse((byte)ClientMessageType.SET_PIRATE_CHOICE, (buffer, index) => SET_PIRATE_CHOICE.Build(buffer, index).Parse(actionCode));
        public static void SetPotionMasterChoice(this MessageParser parser, Potion potion) => parser.Parse((byte)ClientMessageType.SET_POTION_MASTER_CHOICE, (buffer, index) => SET_POTION_MASTER_CHOICE.Build(buffer, index).Parse(potion));
        public static void SetPartyConfig(this MessageParser parser, Brand brand, GameMode mode) => parser.Parse((byte)ClientMessageType.SET_PARTY_CONFIG, (buffer, index) => SET_PARTY_CONFIG.Build(buffer, index).Parse(brand).Parse(mode));
        public static void NotifyOfBrandOwnership(this MessageParser parser, Brand brand) => parser.Parse((byte)ClientMessageType.NOTIFY_OF_BRAND_OWNERSHIP, (buffer, index) => NOTIFY_OF_BRAND_OWNERSHIP.Build(buffer, index).Parse(brand));
        public static void SetHypnotistChoice(this MessageParser parser, LocalizationTable message) => parser.Parse((byte)ClientMessageType.SET_HYPNOTIST_CHOICE, (buffer, index) => SET_HYPNOTIST_CHOICE.Build(buffer, index).Parse(message));
        public static void SetJailorDeathNote(this MessageParser parser, ExecuteReason reason) => parser.Parse((byte)ClientMessageType.SET_JAILOR_DEATH_NOTE, (buffer, index) => SET_JAILOR_DEATH_NOTE.Build(buffer, index).Parse(reason));
    }

    public class ClientMessageParser
    {
        public event Action<string> AuthenticateFacebook;
        public event Action<AuthenticationMode, bool, uint, string, string, string> Authenticate;
        public event Action<string> SendChatBoxMessage;
        public event Action<Catalog> ClickedOnCatalog;
        public event Action<byte, byte> ClickedOnPossibleRoles;
        public event Action<Role> ClickedOnAddButton;
        public event Action<byte> ClickedOnRemoveButton;
        public event Action<Player, string> SendPrivateMessage;
        public event Action ClickedOnStartButton;
        public event Action<Player> SetVote;
        public event Action<Player> SetTarget;
        public event Action<Player> SetSecondTarget;
        public event Action JudgementVoteGuilty;
        public event Action JudgementVoteInnocent;
        public event Action<Player> SetDayChoice;
        public event Action<string> SaveLastWill;
        public event Action<string> SaveDeathNote;
        public event Action<Player, TargetType> SetTargetMafiaOrWitch;
        public event Action<Character, House, Background, Pet?, LobbyIcon, DeathAnimation, Scroll?, Scroll?, Scroll?, string> UpdateCustomizations;
        public event Action<string> ChooseName;
        public event Action<Player, ReportReason, string> ReportPlayer;
        public event Action VoteToRepickHost;
        public event Action<SystemCommand, string> SendSystemMessage;
        public event Action<string> RequestFriend;
        public event Action<string, uint> AcceptFriend;
        public event Action<string, uint> RemoveFriend;
        public event Action<uint> DeclineFriendRequest;
        public event Action<string, string> SendFriendMessage;
        public event Action<GameMode> JoinLobby;
        public event Action<Brand> CreateParty;
        public event Action<string> InviteToParty;
        public event Action RequestLeaveParty;
        public event Action<PartyInviteResponse, uint> RespondPartyInvite;
        public event Action<GameMode> PartyStart;
        public event Action<string> SendPartyMessage;
        public event Action<Setting, byte> UpdateSettings;
        public event Action<AFKStatus> UpdateAFKStatus;
        public event Action LeaveGame;
        public event Action<string> RedeemCode;
        public event Action<string> SetPartyHost;
        public event Action<string> KickFromParty;
        public event Action<string> GivePartyInvitePower;
        public event Action<SteamItem, string> RequestPurchaseSteam;
        public event Action<string, string, string, string, string> RegisterSteam;
        public event Action<string, string, string, string> RegisterForums;
        public event Action<string, string, string> LinkSteam;
        public event Action<GameMode> JoinRankedQueue;
        public event Action LeaveRankedQueue;
        public event Action AcceptRanked;
        public event Action LeavePostGameLobby;
        public event Action<string> SaveForgedWill;
        public event Action RequestPlayerStatistics;
        public event Action<uint> AcceptPromotion;
        public event Action<string> CheckUsername;
        public event Action<string> RequestNameChange;
        public event Action<ShopItem, uint> RequestPurchase;
        public event Action RequestCauldronStatus;
        public event Action CollectCauldronPrize;
        public event Action<Player, TauntTargetType, Taunt> UseTaunt;
        public event Action<byte> SetPirateChoice;
        public event Action<Potion> SetPotionMasterChoice;
        public event Action<Brand, GameMode> SetPartyConfig;
        public event Action<Brand> NotifyOfBrandOwnership;
        public event Action<LocalizationTable> SetHypnotistChoice;
        public event Action<ExecuteReason> SetJailorDeathNote;

        public ClientMessageParser(MessageParser parser) => parser.MessageRead += Parse;

        protected void Parse(byte[] buffer, int index, int length)
        {
            switch ((ClientMessageType)buffer[index++])
            {
                case ClientMessageType.AUTHENTICATE_FACEBOOK:
                    if (AuthenticateFacebook == null) break;
                    ClientMessageParsers.AUTHENTICATE_FACEBOOK.Build(buffer, index, length).Parse(out string accessToken);
                    AuthenticateFacebook(accessToken);
                    break;
                case ClientMessageType.AUTHENTICATE:
                    if (Authenticate == null) break;
                    bool encrypted = false;
                    bool linkSteam = true;
                    uint buildID = 0u;
                    string username = null;
                    string password = null;
                    string extra = null;
                    ClientMessageParsers.AUTHENTICATE.Build(buffer, index, length).Parse(out AuthenticationMode authMode).Parse(authMode != AuthenticationMode.STEAM, p => p.Parse(out encrypted).Parse(out linkSteam).Parse(out buildID).Parse(authMode != AuthenticationMode.VERIFIED_FACEBOOK, p2 => p2.Parse(out username).Parse(out extra).Parse(linkSteam, p3 => p3.Parse(out password), p3 => p3), p2 => p2), p => p.Parse(out extra)).CheckPadding();
                    Authenticate(authMode, encrypted, buildID, username, linkSteam ? password : extra, extra);
                    break;
                case ClientMessageType.SEND_CHAT_BOX_MESSAGE:
                    if (SendChatBoxMessage == null) break;
                    ClientMessageParsers.SEND_CHAT_BOX_MESSAGE.Build(buffer, index, length).Parse(out string message).CheckPadding();
                    SendChatBoxMessage(message);
                    break;
                case ClientMessageType.CLICKED_ON_CATALOG:
                    if (ClickedOnCatalog == null) break;
                    ClientMessageParsers.CLICKED_ON_CATALOG.Build(buffer, index, length).Parse(out Catalog catalog).CheckPadding();
                    ClickedOnCatalog(catalog);
                    break;
                case ClientMessageType.CLICKED_ON_POSSIBLE_ROLES:
                    if (ClickedOnPossibleRoles == null) break;
                    ClientMessageParsers.CLICKED_ON_POSSIBLE_ROLES.Build(buffer, index, length).Parse(out byte selectedIndex).Parse(out byte scrollPosition).CheckPadding();
                    ClickedOnPossibleRoles(selectedIndex, scrollPosition);
                    break;
                case ClientMessageType.CLICKED_ON_ADD_BUTTON:
                    if (ClickedOnAddButton == null) break;
                    ClientMessageParsers.CLICKED_ON_ADD_BUTTON.Build(buffer, index, length).Parse(out Role role).CheckPadding();
                    ClickedOnAddButton(role);
                    break;
                case ClientMessageType.CLICKED_ON_REMOVE_BUTTON:
                    if (ClickedOnRemoveButton == null) break;
                    ClientMessageParsers.CLICKED_ON_REMOVE_BUTTON.Build(buffer, index, length).Parse(out byte slotIndex).CheckPadding();
                    ClickedOnRemoveButton(slotIndex);
                    break;
                case ClientMessageType.SEND_PRIVATE_MESSAGE:
                    if (SendPrivateMessage == null) break;
                    ClientMessageParsers.SEND_PRIVATE_MESSAGE.Build(buffer, index, length).Parse(out Player player).Parse(out message).CheckPadding();
                    SendPrivateMessage(player, message);
                    break;
                case ClientMessageType.CLICKED_ON_START_BUTTON:
                    if (ClickedOnStartButton == null) break;
                    ClientMessageParsers.CLICKED_ON_START_BUTTON.Build(buffer, index, length).CheckPadding();
                    ClickedOnStartButton();
                    break;
                case ClientMessageType.SET_VOTE:
                    if (SetVote == null) break;
                    ClientMessageParsers.SET_VOTE.Build(buffer, index, length).Parse(out player).CheckPadding();
                    SetVote(player);
                    break;
                case ClientMessageType.SET_TARGET:
                    if (SetTarget == null) break;
                    ClientMessageParsers.SET_TARGET.Build(buffer, index, length).Parse(out player).CheckPadding();
                    SetTarget(player);
                    break;
                case ClientMessageType.SET_SECOND_TARGET:
                    if (SetSecondTarget == null) break;
                    ClientMessageParsers.SET_SECOND_TARGET.Build(buffer, index, length).Parse(out player).CheckPadding();
                    SetSecondTarget(player);
                    break;
                case ClientMessageType.JUDGEMENT_VOTE_GUILTY:
                    if (JudgementVoteGuilty == null) break;
                    ClientMessageParsers.JUDGEMENT_VOTE_GUILTY.Build(buffer, index, length).CheckPadding();
                    JudgementVoteGuilty();
                    break;
                case ClientMessageType.JUDGEMENT_VOTE_INNOCENT:
                    if (JudgementVoteInnocent == null) break;
                    ClientMessageParsers.JUDGEMENT_VOTE_INNOCENT.Build(buffer, index, length).CheckPadding();
                    JudgementVoteInnocent();
                    break;
                case ClientMessageType.SET_DAY_CHOICE:
                    if (SetDayChoice == null) break;
                    ClientMessageParsers.SET_DAY_CHOICE.Build(buffer, index, length).Parse(out player).CheckPadding();
                    SetDayChoice(player);
                    break;
                case ClientMessageType.SAVE_LAST_WILL:
                    if (SaveLastWill == null) break;
                    ClientMessageParsers.SAVE_LAST_WILL.Build(buffer, index, length).Parse(out string lastWill).CheckPadding();
                    SaveLastWill(lastWill);
                    break;
                case ClientMessageType.SAVE_DEATH_NOTE:
                    if (SaveDeathNote == null) break;
                    ClientMessageParsers.SAVE_DEATH_NOTE.Build(buffer, index, length).Parse(out string deathNote).CheckPadding();
                    SaveDeathNote(deathNote);
                    break;
                case ClientMessageType.SET_TARGET_MAFIA_OR_WITCH:
                    if (SetTargetMafiaOrWitch == null) break;
                    ClientMessageParsers.SET_TARGET_MAFIA_OR_WITCH.Build(buffer, index, length).Parse(out Player target).Parse(out TargetType targetType).CheckPadding();
                    SetTargetMafiaOrWitch(target, targetType);
                    break;
                case ClientMessageType.UPDATE_CUSTOMIZATIONS:
                    if (UpdateCustomizations == null) break;
                    ClientMessageParsers.UPDATE_CUSTOMIZATIONS.Build(buffer, index, length).Parse(out Character character).Parse(out House house).Parse(out Background background).Parse(out Pet? pet).Parse(out LobbyIcon lobbyIcon).Parse(out DeathAnimation deathAnimation).Parse(out Scroll? scroll1).Parse(out Scroll? scroll2).Parse(out Scroll? scroll3).Parse(out string name).CheckPadding();
                    UpdateCustomizations(character, house, background, pet, lobbyIcon, deathAnimation, scroll1, scroll2, scroll3, name);
                    break;
                case ClientMessageType.CHOOSE_NAME:
                    if (ChooseName == null) break;
                    ClientMessageParsers.CHOOSE_NAME.Build(buffer, index, length).Parse(out name).CheckPadding();
                    ChooseName(name);
                    break;
                case ClientMessageType.REPORT_PLAYER:
                    if (ReportPlayer == null) break;
                    ClientMessageParsers.REPORT_PLAYER.Build(buffer, index, length).Parse(out player).Parse(out ReportReason reportReason).Parse(out message);
                    ReportPlayer(player, reportReason, message);
                    break;
                case ClientMessageType.VOTE_TO_REPICK_HOST:
                    if (VoteToRepickHost == null) break;
                    ClientMessageParsers.VOTE_TO_REPICK_HOST.Build(buffer, index, length).CheckPadding();
                    VoteToRepickHost();
                    break;
                case ClientMessageType.SEND_SYSTEM_MESSAGE:
                    if (SendSystemMessage == null) break;
                    ClientMessageParsers.SEND_SYSTEM_MESSAGE.Build(buffer, index, length).Parse(out SystemCommand systemCommand).Parse(out extra).CheckPadding();
                    SendSystemMessage(systemCommand, extra);
                    break;
                case ClientMessageType.REQUEST_FRIEND:
                    if (RequestFriend == null) break;
                    ClientMessageParsers.REQUEST_FRIEND.Build(buffer, index, length).Parse(out username).CheckPadding();
                    RequestFriend(username);
                    break;
                case ClientMessageType.ACCEPT_FRIEND:
                    if (AcceptFriend == null) break;
                    ClientMessageParsers.ACCEPT_FRIEND.Build(buffer, index, length).Parse(out username).Parse(out uint userID).CheckPadding();
                    AcceptFriend(username, userID);
                    break;
                case ClientMessageType.REMOVE_FRIEND:
                    if (RemoveFriend == null) break;
                    ClientMessageParsers.REMOVE_FRIEND.Build(buffer, index, length).Parse(out username).Parse(out userID).CheckPadding();
                    RemoveFriend(username, userID);
                    break;
                case ClientMessageType.DECLINE_FRIEND_REQUEST:
                    if (DeclineFriendRequest == null) break;
                    ClientMessageParsers.DECLINE_FRIEND_REQUEST.Build(buffer, index, length).Parse(out userID).CheckPadding();
                    DeclineFriendRequest(userID);
                    break;
                case ClientMessageType.SEND_FRIEND_MESSAGE:
                    if (SendFriendMessage == null) break;
                    ClientMessageParsers.SEND_FRIEND_MESSAGE.Build(buffer, index, length).Parse(out username).Parse(out message).CheckPadding();
                    SendFriendMessage(username, message);
                    break;
                case ClientMessageType.JOIN_LOBBY:
                    if (JoinLobby == null) break;
                    ClientMessageParsers.JOIN_LOBBY.Build(buffer, index, length).Parse(out GameMode gameMode).CheckPadding();
                    JoinLobby(gameMode);
                    break;
                case ClientMessageType.CREATE_PARTY:
                    if (CreateParty == null) break;
                    ClientMessageParsers.CREATE_PARTY.Build(buffer, index, length).Parse(out Brand brand).CheckPadding();
                    CreateParty(brand);
                    break;
                case ClientMessageType.INVITE_TO_PARTY:
                    if (InviteToParty == null) break;
                    ClientMessageParsers.INVITE_TO_PARTY.Build(buffer, index, length).Parse(out username).CheckPadding();
                    InviteToParty(username);
                    break;
                case ClientMessageType.REQUEST_LEAVE_PARTY:
                    if (RequestLeaveParty == null) break;
                    ClientMessageParsers.REQUEST_LEAVE_PARTY.Build(buffer, index, length).CheckPadding();
                    RequestLeaveParty();
                    break;
                case ClientMessageType.RESPOND_PARTY_INVITE:
                    if (RespondPartyInvite == null) break;
                    ClientMessageParsers.RESPOND_PARTY_INVITE.Build(buffer, index, length).Parse(out PartyInviteResponse inviteResponse).Parse(out userID).CheckPadding();
                    RespondPartyInvite(inviteResponse, userID);
                    break;
                case ClientMessageType.PARTY_START:
                    if (PartyStart == null) break;
                    ClientMessageParsers.PARTY_START.Build(buffer, index, length).Parse(out gameMode).CheckPadding();
                    PartyStart(gameMode);
                    break;
                case ClientMessageType.SEND_PARTY_MESSAGE:
                    if (SendPartyMessage == null) break;
                    ClientMessageParsers.SEND_PARTY_MESSAGE.Build(buffer, index, length).Parse(out message).CheckPadding();
                    SendPartyMessage(message);
                    break;
                case ClientMessageType.UPDATE_SETTINGS:
                    if (UpdateSettings == null) break;
                    ClientMessageParsers.UPDATE_SETTINGS.Build(buffer, index, length).Parse(out Setting setting).Parse(out byte value).CheckPadding();
                    UpdateSettings(setting, value);
                    break;
                case ClientMessageType.UPDATE_AFK_STATUS:
                    if (UpdateAFKStatus == null) break;
                    ClientMessageParsers.UPDATE_AFK_STATUS.Build(buffer, index, length).Parse(out AFKStatus afkStatus).CheckPadding();
                    UpdateAFKStatus(afkStatus);
                    break;
                case ClientMessageType.LEAVE_GAME:
                    if (LeaveGame == null) break;
                    ClientMessageParsers.LEAVE_GAME.Build(buffer, index, length).CheckPadding();
                    LeaveGame();
                    break;
                case ClientMessageType.REDEEM_CODE:
                    if (RedeemCode == null) break;
                    ClientMessageParsers.REDEEM_CODE.Build(buffer, index, length).Parse(out string code).CheckPadding();
                    RedeemCode(code);
                    break;
                case ClientMessageType.SET_PARTY_HOST:
                    if (SetPartyHost == null) break;
                    ClientMessageParsers.SET_PARTY_HOST.Build(buffer, index, length).Parse(out username).CheckPadding();
                    SetPartyHost(username);
                    break;
                case ClientMessageType.KICK_FROM_PARTY:
                    if (KickFromParty == null) break;
                    ClientMessageParsers.KICK_FROM_PARTY.Build(buffer, index, length).Parse(out username).CheckPadding();
                    KickFromParty(username);
                    break;
                case ClientMessageType.GIVE_PARTY_INVITE_POWER:
                    if (GivePartyInvitePower == null) break;
                    ClientMessageParsers.GIVE_PARTY_INVITE_POWER.Build(buffer, index, length).Parse(out username).CheckPadding();
                    GivePartyInvitePower(username);
                    break;
                case ClientMessageType.REQUEST_PURCHASE_STEAM:
                    if (RequestPurchaseSteam == null) break;
                    ClientMessageParsers.REQUEST_PURCHASE_STEAM.Build(buffer, index, length).Parse(out SteamItem steamItem).Parse(out string steamUserID).CheckPadding();
                    RequestPurchaseSteam(steamItem, steamUserID);
                    break;
                case ClientMessageType.REGISTER_STEAM:
                    if (RegisterSteam == null) break;
                    ClientMessageParsers.REGISTER_STEAM.Build(buffer, index, length).Parse(out byte usernameLength).Parse(out byte passwordLength).Parse(out byte emailLength).Parse(out byte referrerLength).Parse(out username, usernameLength).Parse(out password, passwordLength).Parse(out string email, emailLength).Parse(out string referrer, referrerLength).Parse(out string steamAuthTicket).CheckPadding();
                    RegisterSteam(username, password, email, referrer, steamAuthTicket);
                    break;
                case ClientMessageType.REGISTER_FORUMS:
                    if (RegisterForums == null) break;
                    ClientMessageParsers.REGISTER_FORUMS.Build(buffer, index, length).Parse(out usernameLength).Parse(out passwordLength).Parse(out emailLength).Parse(out username, usernameLength).Parse(out password, passwordLength).Parse(out email, emailLength).Parse(out referrer).CheckPadding();
                    RegisterForums(username, password, email, referrer);
                    break;
                case ClientMessageType.LINK_STEAM:
                    if (LinkSteam == null) break;
                    ClientMessageParsers.LINK_STEAM.Build(buffer, index, length).Parse(out usernameLength).Parse(out passwordLength).Parse(out username, usernameLength).Parse(out password, passwordLength).Parse(out steamAuthTicket).CheckPadding();
                    LinkSteam(username, password, steamAuthTicket);
                    break;
                case ClientMessageType.JOIN_RANKED_QUEUE:
                    if (JoinRankedQueue == null) break;
                    ClientMessageParsers.JOIN_RANKED_QUEUE.Build(buffer, index, length).Parse(out gameMode).CheckPadding();
                    JoinRankedQueue(gameMode);
                    break;
                case ClientMessageType.LEAVE_RANKED_QUEUE:
                    if (LeaveRankedQueue == null) break;
                    ClientMessageParsers.LEAVE_RANKED_QUEUE.Build(buffer, index, length).CheckPadding();
                    LeaveRankedQueue();
                    break;
                case ClientMessageType.ACCEPT_RANKED:
                    if (AcceptRanked == null) break;
                    ClientMessageParsers.ACCEPT_RANKED.Build(buffer, index, length).CheckPadding();
                    AcceptRanked();
                    break;
                case ClientMessageType.LEAVE_POST_GAME_LOBBY:
                    if (LeavePostGameLobby == null) break;
                    ClientMessageParsers.LEAVE_POST_GAME_LOBBY.Build(buffer, index, length).CheckPadding();
                    LeavePostGameLobby();
                    break;
                case ClientMessageType.SAVE_FORGED_WILL:
                    if (SaveForgedWill == null) break;
                    ClientMessageParsers.SAVE_FORGED_WILL.Build(buffer, index, length).Parse(out lastWill).CheckPadding();
                    SaveForgedWill(lastWill);
                    break;
                case ClientMessageType.REQUEST_PLAYER_STATISTICS:
                    if (RequestPlayerStatistics == null) break;
                    ClientMessageParsers.REQUEST_PLAYER_STATISTICS.Build(buffer, index, length).CheckPadding();
                    RequestPlayerStatistics();
                    break;
                case ClientMessageType.ACCEPT_PROMOTION:
                    if (AcceptPromotion == null) break;
                    ClientMessageParsers.ACCEPT_PROMOTION.Build(buffer, index, length).Parse(out uint refID).CheckPadding();
                    AcceptPromotion(refID);
                    break;
                case ClientMessageType.CHECK_USERNAME:
                    if (CheckUsername == null) break;
                    ClientMessageParsers.CHECK_USERNAME.Build(buffer, index, length).Parse(out username).CheckPadding();
                    CheckUsername(username);
                    break;
                case ClientMessageType.REQUEST_NAME_CHANGE:
                    if (RequestNameChange == null) break;
                    ClientMessageParsers.REQUEST_NAME_CHANGE.Build(buffer, index, length).Parse(out username).CheckPadding();
                    RequestNameChange(username);
                    break;
                case ClientMessageType.REQUEST_PURCHASE:
                    if (RequestPurchase == null) break;
                    ClientMessageParsers.REQUEST_PURCHASE.Build(buffer, index, length).Parse(out ShopItem shopItem).Parse(out uint amount).CheckPadding();
                    RequestPurchase(shopItem, amount);
                    break;
                case ClientMessageType.REQUEST_CAULDRON_STATUS:
                    if (RequestCauldronStatus == null) break;
                    ClientMessageParsers.REQUEST_CAULDRON_STATUS.Build(buffer, index, length).CheckPadding();
                    RequestCauldronStatus();
                    break;
                case ClientMessageType.COLLECT_CAULDRON_PRIZE:
                    if (CollectCauldronPrize == null) break;
                    ClientMessageParsers.COLLECT_CAULDRON_PRIZE.Build(buffer, index, length).CheckPadding();
                    CollectCauldronPrize();
                    break;
                case ClientMessageType.USE_TAUNT:
                    if (UseTaunt == null) break;
                    ClientMessageParsers.USE_TAUNT.Build(buffer, index, length).Parse(out player).Parse(out TauntTargetType tauntType).Parse(out Taunt taunt).CheckPadding();
                    UseTaunt(player, tauntType, taunt);
                    break;
                case ClientMessageType.SET_PIRATE_CHOICE:
                    if (SetPirateChoice == null) break;
                    ClientMessageParsers.SET_PIRATE_CHOICE.Build(buffer, index, length).Parse(out byte pirateChoice).CheckPadding();
                    SetPirateChoice(pirateChoice);
                    break;
                case ClientMessageType.SET_POTION_MASTER_CHOICE:
                    if (SetPotionMasterChoice == null) break;
                    ClientMessageParsers.SET_POTION_MASTER_CHOICE.Build(buffer, index, length).Parse(out Potion potion).CheckPadding();
                    SetPotionMasterChoice(potion);
                    break;
                case ClientMessageType.SET_PARTY_CONFIG:
                    if (SetPartyConfig == null) break;
                    ClientMessageParsers.SET_PARTY_CONFIG.Build(buffer, index, length).Parse(out brand).Parse(out gameMode).CheckPadding();
                    SetPartyConfig(brand, gameMode);
                    break;
                case ClientMessageType.NOTIFY_OF_BRAND_OWNERSHIP:
                    if (NotifyOfBrandOwnership == null) break;
                    ClientMessageParsers.NOTIFY_OF_BRAND_OWNERSHIP.Build(buffer, index, length).Parse(out brand).CheckPadding();
                    NotifyOfBrandOwnership(brand);
                    break;
                case ClientMessageType.SET_HYPNOTIST_CHOICE:
                    if (SetHypnotistChoice == null) break;
                    ClientMessageParsers.SET_HYPNOTIST_CHOICE.Build(buffer, index, length).Parse(out LocalizationTable localizationTable).CheckPadding();
                    SetHypnotistChoice(localizationTable);
                    break;
                case ClientMessageType.SET_JAILOR_DEATH_NOTE:
                    if (SetJailorDeathNote == null) break;
                    ClientMessageParsers.SET_JAILOR_DEATH_NOTE.Build(buffer, index, length).Parse(out ExecuteReason executeReason).CheckPadding();
                    SetJailorDeathNote(executeReason);
                    break;
            }
        }
    }
}
