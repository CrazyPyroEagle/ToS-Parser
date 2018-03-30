using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToSParser
{
    public enum TargetType : byte
    {
        SET_TARGET_1,
        CANCEL_TARGET_1,
        CHANGE_TARGET_1,
        SET_TARGET_2,
        CANCEL_TARGET_2,
        CHANGE_TARGET_2
    }
}
