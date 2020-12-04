using GildedRose.QualityFactory.Chain;
using NUnit.Framework;

namespace GildedRose.Test.QualityFactory.Chain
{
    [TestFixture]
    public class TripleAppreciateQualityTest
    {
        [Test]
        public void Quality()
        {
            Assert.AreEqual(8, new TripleAppreciateQuality().Quality(5, 11));
            Assert.AreEqual(8, new TripleAppreciateQuality().Quality(5, 6));
            Assert.AreEqual(8, new TripleAppreciateQuality().Quality(5, 4));
            Assert.AreEqual(50, new TripleAppreciateQuality().Quality(50, 4));
        }

        [Test]
        public void CanHandle()
        {
            Assert.False(new TripleAppreciateQuality().CanHandle(5, 6));
            Assert.True(new TripleAppreciateQuality().CanHandle(0, 5));
            Assert.True(new TripleAppreciateQuality().CanHandle(50, 4));
        }
    }
}