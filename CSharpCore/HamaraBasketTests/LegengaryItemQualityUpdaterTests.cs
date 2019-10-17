using System;
using HamaraBasketQualityAssurance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HamaraBasketTests
{
    [TestClass]
    public class LegengaryItemQualityCheckerTests
    {
        [TestMethod]
        public void ForestHoneyQualityRemainsSame()
        {
            var item = new HamaraBasketItem(10, 10, ItemType.Legendary);
            var checker = new LegengaryItemQualityChecker();

            checker.UpdateQuality(item);

            Assert.AreEqual(10, item.Quality);

        }
    }
}
