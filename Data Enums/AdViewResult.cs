using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetParse
{
    public enum AdViewResult : byte
    {
        AD_LIMIT_HIT,
        SET_TOKEN,
        GIVE_PRIZE,
        INVALID_TOKEN
    }
}
