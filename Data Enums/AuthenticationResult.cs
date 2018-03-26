using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetParse
{
    public enum AuthenticationResult : byte
    {
        FACEBOOK_RESOLVING,
        FACEBOOK_CONNECTING,
        FACEBOOK_HANDSHAKING,
        FACEBOOK_VERIFYING_1,
        FACEBOOK_VERIFYING_2,
        FACEBOOK_ERROR_VERIFYING,
        ACCOUNT_BANNED,
        ACCOUNT_SUSPENDED,
        SERVER_UNDER_MAINTENANCE,
        FACEBOOK_UNABLE_TO_VERIFY,
        ACCOUNT_FROZEN_STEAM_REFUND
    }
}
