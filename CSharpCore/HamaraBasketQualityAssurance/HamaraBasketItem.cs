namespace HamaraBasketQualityAssurance
{
    public class HamaraBasketItem
    {
        public int SellBy { get; set; }
        public int Quality { get; set; }
        public ItemType ItemType { get; }

        public HamaraBasketItem(int sellBy, int quality, ItemType itemType)
        {
            SellBy = sellBy;
            Quality = quality;
            ItemType = itemType;
        }
    }
}