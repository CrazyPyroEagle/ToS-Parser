using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetParse
{
    public enum AuthenticationModeID : byte
    {
        VERIFIED_FACEBOOK,
        BMG_FORUMS,
        STEAM_LINK,
        STEAM,
        STEAM_WITH_PASSWORD
    }
}
