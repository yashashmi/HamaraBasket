using HamaraBasketQualityAssurance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HamaraBasketTests
{
    [TestClass]
    public class MovieTicketsQualityCheckerTests
    {
        [TestMethod]
        public void QualityIncreasesAsSellByValueApproaches()
        {
            var item = new HamaraBasketItem(20, 10, ItemType.MovieTicket);
            var checker = new MovieTicketsQualityChecker();

            checker.UpdateQuality(item);

            Assert.AreEqual(11, item.Quality);
        }

        [TestMethod]
        public void QualityIncreasesByTwoWhenSellByValueIsLessThan10()
        {
            var item = new HamaraBasketItem(10, 10, ItemType.MovieTicket);
            var checker = new MovieTicketsQualityChecker();

            checker.UpdateQuality(item);

            Assert.AreEqual(12, item.Quality);
        }

        [TestMethod]
        public void QualityIncreasesByThreeWhenSellByValueIsLessThan10()
        {
            var item = new HamaraBasketItem(3, 10, ItemType.MovieTicket);
            var checker = new MovieTicketsQualityChecker();

            checker.UpdateQuality(item);

            Assert.AreEqual(13, item.Quality);
        }

        [TestMethod]
        public void QualityDropsToZeroWhenSellByHasPassed()
        {
            var item = new HamaraBasketItem(0, 10, ItemType.MovieTicket);
            var checker = new MovieTicketsQualityChecker();

            checker.UpdateQuality(item);

            Assert.AreEqual(0, item.Quality);
        }
    }
}