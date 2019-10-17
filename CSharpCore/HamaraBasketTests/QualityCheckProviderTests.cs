using HamaraBasketQualityAssurance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HamaraBasketTests
{
    [TestClass]
    public class QualityCheckProviderTests
    {
        [TestMethod]
        public void ShouldGetTheGeneralQualityChecker()
        {
            var updater = QualityCheckProvider.GetChecker(ItemType.Expiring);
            Assert.IsInstanceOfType(updater,typeof(QualityChecker));
        }

        [TestMethod]
        public void ShouldGetTheLegendaryQualityChecker()
        {
            var updater = QualityCheckProvider.GetChecker(ItemType.Legendary);
            Assert.IsInstanceOfType(updater, typeof(LegengaryItemQualityChecker));
        }

        [TestMethod]
        public void ShouldGetTheNonExpiryQualityChecker()
        {
            var updater = QualityCheckProvider.GetChecker(ItemType.NonExpiry);
            Assert.IsInstanceOfType(updater, typeof(NonExpiryItemQualityChecker));
        }
    }
}
