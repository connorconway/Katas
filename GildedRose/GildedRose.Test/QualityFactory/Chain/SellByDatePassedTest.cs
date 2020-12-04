using GildedRose.QualityFactory.Chain;
using NUnit.Framework;

namespace GildedRose.Test.QualityFactory.Chain
{
    [TestFixture]
    public class SellByDatePassedTest
    {
        [Test]
        public void Quality()
        {
            Assert.AreEqual(3, new SellByDatePassed(1).Quality(5, 11));
            Assert.AreEqual(3, new SellByDatePassed(1).Quality(5, 6));
            Assert.AreEqual(1, new SellByDatePassed(2).Quality(5, 4));
            Assert.AreEqual(46, new SellByDatePassed(2).Quality(50, 4));
        }

        [Test]
        public void CanHandle()
        {
            Assert.False(new SellByDatePassed(1).CanHandle(5, 1));
            Assert.False(new SellByDatePassed(2).CanHandle(0, 0));
            Assert.True(new SellByDatePassed(3).CanHandle(50, -1));
        }
    }
}