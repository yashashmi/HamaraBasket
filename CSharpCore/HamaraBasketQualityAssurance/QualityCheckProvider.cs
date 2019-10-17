namespace HamaraBasketQualityAssurance
{
    public class QualityCheckProvider
    {
        public static QualityChecker GetChecker(ItemType itemType)
        {
            if(itemType.Equals(ItemType.Legendary))
            {
                return new LegengaryItemQualityChecker();
            }
            if (itemType.Equals(ItemType.NonExpiry))
            {
                return new NonExpiryItemQualityChecker();
            }
            return new QualityChecker();
        }
    }
}
