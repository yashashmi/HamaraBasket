package com.hamaraBasket;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

public class SellByUpdaterTests
    {
        @Test
        public void sellByShouldDecreaseByOne()
        {
            HamaraBasketItem item = new HamaraBasketItem(10, 10, ItemType.Expiring);
            SellByUpdater checker = new SellByUpdater();

            checker.updateSellBy(item);

            assertEquals(9, item.getSellBy());
        }
    }