package com.hamaraBasket;

import static org.junit.Assert.assertEquals;
import org.junit.Test;

public class NonExpiryItemQualityCheckerTests {
    @Test
    public void indianWineQualityShouldIncreaseByOne() {
        HamaraBasketItem item = new HamaraBasketItem(10, 10, ItemType.NonExpiry);
        QualityChecker checker = new NonExpiryItemQualityChecker();

        checker.updateQuality(item);

        assertEquals(11, item.getQuality());
    }

    @Test
    public void indianWineQualityShouldNeverBeMoreThan50() {
        HamaraBasketItem item = new HamaraBasketItem(10, 50, ItemType.NonExpiry);
        QualityChecker checker = new NonExpiryItemQualityChecker();

        checker.updateQuality(item);

        assertEquals(50, item.getQuality());
    }
}