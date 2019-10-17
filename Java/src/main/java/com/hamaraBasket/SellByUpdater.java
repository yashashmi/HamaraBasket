package com.hamaraBasket;

public class SellByUpdater {
    public void updateSellBy(HamaraBasketItem item) {
        int sellBy = item.getSellBy();
        item.setSellBy(sellBy - 1);
    }
}