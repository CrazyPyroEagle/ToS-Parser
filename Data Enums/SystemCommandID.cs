﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToSParser
{
    public enum SystemCommandID : byte
    {
        MESSAGE,
        GAME_MESSAGE,
        BAN,
        IDENTIFY,
        RESTART,
        CANCEL_RESTART,
        GRANT_POINTS,
        SUSPEND,
        RELOAD_XML,
        WHISPER,
        UNBAN,
        ACCOUNT_INFO,
        GRANT_ACHIEVEMENT,
        DEV_LOGIN,
        REQUEST_PROMOTION,
        RESET_ACCOUNT,
        GRANT_CHARACTER,
        GRANT_BACKGROUND,
        GRANT_DEATH_ANIMATION,
        GRANT_HOUSE,
        GRANT_LOBBY_ICON,
        GRANT_PACK,
        GRANT_PET,
        GRANT_SCROLL,
        RESET_TUTORIAL_PROGRESS,
        RELOAD_PROMOTION_XML,
        GRANT_PROMOTION,
        SET_ROLE,
        GRANT_ACCOUNT_ITEM,
        FORCE_NAME_CHANGE,
        GRANT_MERIT,
        DOUBLE_GLOBAL_FREE_CURRENCY_MULTIPLIER,
        RESET_GLOBAL_FREE_CURRENCY_MULTIPLIER,
        GRANT_REFER_A_FRIEND,
        RELOAD_CACHES,
        TOGGLE_TEST_PURCHASES
    }
}