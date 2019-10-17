package com.hamaraBasket;

import static org.junit.Assert.assertEquals;
import org.junit.Test;

public class LegengaryItemQualityCheckerTests {
    @Test
    public void forestHoneyQualityRemainsSame() {
        HamaraBasketItem item = new HamaraBasketItem(10, 10, ItemType.Legendary);
        LegengaryItemQualityChecker checker = new LegengaryItemQualityChecker();

        checker.updateQuality(item);

        assertEquals(10, item.getQuality());

    }
}