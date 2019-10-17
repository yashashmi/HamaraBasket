package com.hamaraBasket;

public class MovieTicketsQualityChecker extends QualityChecker
    {
       @Override
        public void updateQuality(HamaraBasketItem item)
        {
            if(item.getSellBy()<=0)
            {
                item.setQuality(0);
                return;
            }
            if(item.getSellBy()<=5)
            {
                int quality = item.getQuality();
                item.setQuality(quality+3);
                return;
            }
            if(item.getSellBy()<=10)
            {
                int quality = item.getQuality();
                item.setQuality(quality+ 2);
                return;
            }

            int quality = item.getQuality();
            item.setQuality(quality+ 1);
        }
    }