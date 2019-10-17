using HamaraBasketQualityAssurance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HamaraBasketTests
{
    [TestClass]
    public class SellByUpdaterTests
    {
        [TestMethod]
        public void SellByShouldDecreaseByOne()
        {
            var item = new HamaraBasketItem(10, 10, ItemType.Expiring);
            var checker = new SellByUpdater();

            checker.UpdateSellBy(item);

            Assert.AreEqual(9, item.SellBy);
        }
    }
}
