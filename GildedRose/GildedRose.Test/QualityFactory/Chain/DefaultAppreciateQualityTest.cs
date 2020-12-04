using GildedRose.QualityFactory.Chain;
using NUnit.Framework;

namespace GildedRose.Test.QualityFactory.Chain
{
    [TestFixture]
    public class DefaultAppreciateQualityTest
    {
        [Test]
        public void Quality()
        {
            Assert.AreEqual(6, new DefaultAppreciateQuality().Quality(5, 5));
            Assert.AreEqual(1, new DefaultAppreciateQuality().Quality(0, 5));
            Assert.AreEqual(50, new DefaultAppreciateQuality().Quality(50, 5));
        }

        [Test]
        public void CanHandle()
        {
            Assert.True(new DefaultAppreciateQuality().CanHandle(5, 5));
            Assert.True(new DefaultAppreciateQuality().CanHandle(0, 5));
            Assert.True(new DefaultAppreciateQuality().CanHandle(50, 5));
        }
    }
}