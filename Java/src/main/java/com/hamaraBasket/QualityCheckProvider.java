package com.hamaraBasket;

   public class QualityCheckProvider
    {
        public static QualityChecker GetChecker(ItemType itemType)
        {
            if(itemType.equals(ItemType.Legendary))
            {
                return new LegengaryItemQualityChecker();
            }
            if (itemType.equals(ItemType.NonExpiry))
            {
                return new NonExpiryItemQualityChecker();
            }
            return new QualityChecker();
        }
    }