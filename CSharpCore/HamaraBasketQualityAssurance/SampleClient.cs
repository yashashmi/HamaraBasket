namespace HamaraBasketQualityAssurance
{
        /// <summary>
    /// This is a sample client class that represents one of the ways to access the quality checkers.
    /// </summary>
    public class SampleClient
    {
        public void UpdateSellByAndQuality()
        {
            var item = new HamaraBasketItem(10, 20, ItemType.Legendary);
            var qualityChecker = QualityCheckProvider.GetChecker(item.ItemType);
            var sellByUpdater = new SellByUpdater();
            sellByUpdater.UpdateSellBy(item);
            qualityChecker.UpdateQuality(item);
        }
    }
}