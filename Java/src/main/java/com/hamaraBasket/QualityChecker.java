package com.hamaraBasket;   

public class QualityChecker
    {
        public  void updateQuality(HamaraBasketItem item)
        {
            if (item.getSellBy() <= 0 && item.getQuality() > 1)
            {
                int quality = item.getQuality();
                item.setQuality(quality-2);
                return;
            }
            if (item.getQuality() == 0)
            {
                return;
            }
            int quality = item.getQuality();
            item.setQuality(quality - 1);
        }
    }