using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetParse
{
    [Flags]
    public enum AccountFlags : byte
    {
        NONE,
        OWNS_STEAM = 1,
        OWNS_COVEN = 2,
        OWNS_WEB_PREMIUM = 4
    }
}
