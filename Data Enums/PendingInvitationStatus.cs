using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToSParser
{
    public enum PendingInvitationStatus : byte
    {
        PENDING,
        DENIED,
        ACCEPTED,
        FAILED,
        LOADING,
        CANCELED,
        LEFT,
        LOCALE,
        NO_COVEN
    }
}
