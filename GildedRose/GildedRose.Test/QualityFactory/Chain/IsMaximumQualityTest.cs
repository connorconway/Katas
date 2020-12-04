using GildedRose.QualityFactory.Chain;
using NUnit.Framework;

namespace GildedRose.Test.QualityFactory.Chain
{
    [TestFixture]
    public class IsMaximumQualityTest
    {
        [Test]
        public void Quality()
        {
            Assert.AreEqual(50, new IsMaximumQuality().Quality(50, 5));
            Assert.AreEqual(44, new IsMaximumQuality().Quality(44, 5));
        }

        [Test]
        public void CanHandle()
        {
            Assert.True(new IsMaximumQuality().CanHandle(50, 5));
            Assert.False(new IsMaximumQuality().CanHandle(44, 5));
        }
    }
}