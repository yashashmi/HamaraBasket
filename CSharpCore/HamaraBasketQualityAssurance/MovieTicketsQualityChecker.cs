namespace HamaraBasketQualityAssurance
{
    public class MovieTicketsQualityChecker : QualityChecker
    {
       
        public override void UpdateQuality(HamaraBasketItem item)
        {
            if(item.SellBy<=0)
            {
                item.Quality = 0;
                return;
            }
            if(item.SellBy<=5)
            {
                item.Quality += 3;
                return;
            }
            if(item.SellBy<=10)
            {
                item.Quality += 2;
                return;
            }
            item.Quality += 1;
        }
    }
}
