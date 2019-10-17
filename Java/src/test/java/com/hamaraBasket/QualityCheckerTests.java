package com.hamaraBasket;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

public class QualityCheckerTests
    {
        @Test
        public void qualityShouldDecreaseByOne()
        {
            HamaraBasketItem item = new HamaraBasketItem(10, 10, ItemType.Expiring);
            QualityChecker checker = new QualityChecker();

            checker.updateQuality(item);

            assertEquals(9, item.getQuality());
        }

        @Test
        public void qualityShouldDecreaseTwiceWhenSellByPassed()
        {
            HamaraBasketItem item = new HamaraBasketItem(0, 10, ItemType.Expiring);
            QualityChecker checker = new QualityChecker();

            checker.updateQuality(item);

            assertEquals(8, item.getQuality());
        }

        @Test
        public void qualityShouldDecreaseByOneWhenSellByIsZeroAndQualtiyIsOne()
        {
            HamaraBasketItem item = new HamaraBasketItem(0, 1, ItemType.Expiring);
            QualityChecker checker = new QualityChecker();

            checker.updateQuality(item);

            assertEquals(0, item.getQuality());
        }

        @Test
        public void qualityShouldNotBeNegative()
        {
            HamaraBasketItem item = new HamaraBasketItem(1, 0, ItemType.Expiring);
            QualityChecker checker = new QualityChecker();

            checker.updateQuality(item);

            assertEquals(0, item.getQuality());
        }
    }