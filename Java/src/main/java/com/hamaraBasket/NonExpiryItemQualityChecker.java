package com.hamaraBasket;

public class NonExpiryItemQualityChecker extends QualityChecker {
    @Override
    public void updateQuality(HamaraBasketItem item) {
        if (item.getQuality() >= 50) {
            return;
        }
        int quality = item.getQuality();
        item.setQuality(quality + 1);
    }
}