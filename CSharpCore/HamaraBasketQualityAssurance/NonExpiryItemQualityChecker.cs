namespace HamaraBasketQualityAssurance
{
    public class NonExpiryItemQualityChecker : QualityChecker
    {
        public override void UpdateQuality(HamaraBasketItem item)
        {
            if (item.Quality >= 50)
            {
                return;
            }
            item.Quality += 1;
        }
    }
}
