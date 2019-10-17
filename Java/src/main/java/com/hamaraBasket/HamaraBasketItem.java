package com.hamaraBasket;

public class HamaraBasketItem {
    private int sellBy;
    private int quality;
    private ItemType itemType;

    public HamaraBasketItem(int sellBy, int quality, ItemType itemType) {
        this.sellBy = sellBy;
        this.quality = quality;
        this.itemType = itemType;
    }

    public void setSellBy(int sellBy) {
        this.sellBy = sellBy;
    }

    public int getSellBy() {
        return this.sellBy;
    }

    public void setQuality(int quality) {
        this.quality = quality;
    }

    public int getQuality() {
        return this.quality;
    }

    public void setItemType(ItemType itemType) {
        this.itemType = itemType;
    }

    public ItemType getItemType() {
        return this.itemType;
    }

}
