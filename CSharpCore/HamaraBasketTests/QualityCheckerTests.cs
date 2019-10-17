using HamaraBasketQualityAssurance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HamaraBasketTests
{
    [TestClass]
    public class QualityCheckerTests
    {
        [TestMethod]
        public void QualityShouldDecreaseByOne()
        {
            var item = new HamaraBasketItem(10, 10, ItemType.Expiring);
            var checker = new QualityChecker();

            checker.UpdateQuality(item);

            Assert.AreEqual(9, item.Quality);
        }

        [TestMethod]
        public void QualityShouldDecreaseTwiceWhenSellByPassed()
        {
            var item = new HamaraBasketItem(0, 10, ItemType.Expiring);
            var checker = new QualityChecker();

            checker.UpdateQuality(item);

            Assert.AreEqual(8, item.Quality);
        }

        [TestMethod]
        public void QualityShouldDecreaseByOneWhenSellByIsZeroAndQualtiyIsOne()
        {
            var item = new HamaraBasketItem(0, 1, ItemType.Expiring);
            var checker = new QualityChecker();

            checker.UpdateQuality(item);

            Assert.AreEqual(0, item.Quality);
        }

        [TestMethod]
        public void QualityShouldNotBeNegative()
        {
            var item = new HamaraBasketItem(1, 0, ItemType.Expiring);
            var checker = new QualityChecker();

            checker.UpdateQuality(item);

            Assert.AreEqual(0, item.Quality);
        }
    }
}
