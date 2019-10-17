namespace HamaraBasketQualityAssurance
{
    public class QualityChecker
    {
        public virtual void UpdateQuality(HamaraBasketItem item)
        {
            if (item.SellBy <= 0 && item.Quality > 1)
            {
                item.Quality -= 2;
                return;
            }
            if (item.Quality == 0)
            {
                return;
            }
            item.Quality -= 1;
        }
    }
}
