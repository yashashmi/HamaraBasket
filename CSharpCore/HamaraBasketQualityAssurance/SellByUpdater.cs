namespace HamaraBasketQualityAssurance
{
    public class SellByUpdater
    {
        public void UpdateSellBy(HamaraBasketItem item)
        {
            item.SellBy -= 1;
        }
    }
}