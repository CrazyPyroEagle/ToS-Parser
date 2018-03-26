using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToSParser
{
    [Flags]
    public enum AccountState : byte
    {
        NONE,
        NAME_CHANGE_REQUIRED
    }
}
