using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToSParser
{
    public enum SettingID : byte
    {
        FILTER_CHAT,
        MUTE_EFFECTS,
        MUTE_MUSIC,
        DISPLAY_SKINS,
        CLASSIC_SKINS_ONLY,
        SHOW_PETS,
        SUPPRESS_STEAM_POPUP,
        EFFECTS_VOLUME,
        MUSIC_VOLUME,
        SELECTED_QUEUE_LANGUAGE,
        UNKNOWN_SETTING_10,
        TIP_BEHAVIOUR
    }
}
