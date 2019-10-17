package com.hamaraBasket;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

public class MovieTicketsQualityCheckerTests
    {
        @Test
        public void qualityIncreasesAsSellByValueApproaches()
        {
            HamaraBasketItem item = new HamaraBasketItem(20, 10, ItemType.MovieTicket);
            QualityChecker checker = new MovieTicketsQualityChecker();

            checker.updateQuality(item);

            assertEquals(11, item.getQuality());
        }

        @Test
        public void qualityIncreasesByTwoWhenSellByValueIsLessThan10()
        {
            HamaraBasketItem item = new HamaraBasketItem(10, 10, ItemType.MovieTicket);
            QualityChecker checker = new MovieTicketsQualityChecker();

            checker.updateQuality(item);

            assertEquals(12, item.getQuality());
        }

        @Test
        public void qualityIncreasesByThreeWhenSellByValueIsLessThan10()
        {
            HamaraBasketItem item = new HamaraBasketItem(3, 10, ItemType.MovieTicket);
            QualityChecker checker = new MovieTicketsQualityChecker();

            checker.updateQuality(item);

            assertEquals(13, item.getQuality());
        }

        @Test
        public void qualityDropsToZeroWhenSellByHasPassed()
        {
            HamaraBasketItem item = new HamaraBasketItem(0, 10, ItemType.MovieTicket);
            QualityChecker checker = new MovieTicketsQualityChecker();

            checker.updateQuality(item);

            assertEquals(0, item.getQuality());
        }
    }