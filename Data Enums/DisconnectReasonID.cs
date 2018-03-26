using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetParse
{
    public enum DisconnectReasonID : byte
    {
        UNKNOWN,
        OUTDATED_VERSION,
        INVALID_CREDENTIALS
    }
}
