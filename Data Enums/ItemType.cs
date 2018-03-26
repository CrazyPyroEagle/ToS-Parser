using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetParse
{
    public enum ItemType : uint
    {
        CHARACTER = 1,
        HOUSE,
        BACKGROUND,
        PET,
        PACK,
        LOBBY_ICON = 8,
        DEATH_ANIMATION,
        SCROLL = 16,
        ACCOUNT_ITEM = 23,
        TAUNT = 25,
        POTION = 26
    }
}
