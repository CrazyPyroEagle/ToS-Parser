namespace ToSParser
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
