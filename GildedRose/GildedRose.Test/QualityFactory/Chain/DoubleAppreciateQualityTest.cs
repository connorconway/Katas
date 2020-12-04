using GildedRose.QualityFactory.Chain;
using NUnit.Framework;

namespace GildedRose.Test.QualityFactory.Chain
{
    [TestFixture]
    public class DoubleAppreciateQualityTest
    {
        [Test]
        public void Quality()
        {
            Assert.AreEqual(7, new DoubleAppreciateQuality().Quality(5, 11));
            Assert.AreEqual(7, new DoubleAppreciateQuality().Quality(5, 6));
            Assert.AreEqual(7, new DoubleAppreciateQuality().Quality(5, 4));
            Assert.AreEqual(50, new DoubleAppreciateQuality().Quality(50, 4));
        }

        [Test]
        public void CanHandle()
        {
            Assert.False(new DoubleAppreciateQuality().CanHandle(5, 11));
            Assert.True(new DoubleAppreciateQuality().CanHandle(0, 10));
            Assert.True(new DoubleAppreciateQuality().CanHandle(50, 9));
        }
    }
}