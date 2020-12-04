using GildedRose.QualityFactory.Chain;
using NUnit.Framework;

namespace GildedRose.Test.QualityFactory.Chain
{
    [TestFixture]
    public class IsMinimumQualityTest
    {
        [Test]
        public void Quality()
        {
            Assert.AreEqual(0, new IsMinimumQuality().Quality(0, 5));
            Assert.AreEqual(44, new IsMinimumQuality().Quality(44, 5));
        }

        [Test]
        public void CanHandle()
        {
            Assert.True(new IsMinimumQuality().CanHandle(0, 5));
            Assert.False(new IsMinimumQuality().CanHandle(1, 5));
        }
    }
}