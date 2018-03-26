using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetParse
{
    public enum TutorialTipID : uint
    {
        WELCOME,
        PLAY,
        LOBBY,
        NAME_SELECT,
        ROLE_WHEEL,
        ROLE_SELECTION,
        ROLE_CARD,
        ROLE_SPECIFIC_DAY,
        FIRST_NIGHT,
        ROLE_SPECIFIC_NIGHT,
        LAST_WILL_NIGHT,
        DEATH_NOTE_NIGHT,
        DEATH_ANNOUNCEMENT,
        GRAVEYARD,
        DISCUSSION,
        DISCUSSION_NEXT,
        ROLE_LIST,
        VOTING,
        DEFENSE,
        MY_DEFENSE,
        JUDGEMENT,
        ROLE_SPECIFIC_NIGHT_FLUFF,
        YOUR_DEATH,
        CONGRATULATIONS,
        GO_TO_CUSTOMIZATION,
        CUSTOMIZATION,
        SHOP,
        YOUR_ROLE_WAS_CHANGED,
        // Add all role-specific tips too
    }
}
