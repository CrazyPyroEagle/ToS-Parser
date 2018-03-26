using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetParse
{
    public enum OnlineStatus : byte
    {
        OFFLINE,
        ONLINE,
        ACTIVE,
        AWAY,
        IN_GAME,
        IN_LOBBY
    }
}
