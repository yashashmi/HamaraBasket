using HamaraBasketQualityAssurance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HamaraBasketTests
{
    [TestClass]
    public class NonExpiryItemQualityCheckerTests
    {
        [TestMethod]
        public void IndianWineQualityShouldIncreaseByOne()
        {
            var item = new HamaraBasketItem(10, 10, ItemType.NonExpiry);
            var checker = new NonExpiryItemQualityChecker();
            
            checker.UpdateQuality(item);

            Assert.AreEqual(11, item.Quality);
        }

        [TestMethod]
        public void IndianWineQualityShouldNeverBeMoreThan50()
        {
            var item = new HamaraBasketItem(10, 50, ItemType.NonExpiry);
            var checker = new NonExpiryItemQualityChecker();
            
            checker.UpdateQuality(item);

            Assert.AreEqual(50, item.Quality);
        }
    }
}
