using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetParse
{
    public enum PurchaseResult : uint
    {
        ALREADY_OWNED,
        UNKNOWN_PRODUCT,
        SHOP_PURCHASE_FAILED,
        NOT_ENOUGH_TOWN_POINTS,
        SUCCESS,
        CANNOT_PURCHASE_ANY_MORE
    }
}
