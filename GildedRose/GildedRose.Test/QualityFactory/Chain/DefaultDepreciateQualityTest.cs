using GildedRose.QualityFactory.Chain;
using NUnit.Framework;

namespace GildedRose.Test.QualityFactory.Chain
{
    [TestFixture]
    public class DefaultDepreciateQualityTest
    {
        [Test]
        public void Quality()
        {
            Assert.AreEqual(4, new DefaultDepreciateQuality(1).Quality(5, 5));
            Assert.AreEqual(0, new DefaultDepreciateQuality(1).Quality(0, 5));
            Assert.AreEqual(49, new DefaultDepreciateQuality(1).Quality(50, 5));
            Assert.AreEqual(3, new DefaultDepreciateQuality(2).Quality(5, 5));
            Assert.AreEqual(0, new DefaultDepreciateQuality(2).Quality(0, 5));
            Assert.AreEqual(48, new DefaultDepreciateQuality(2).Quality(50, 5));
        }

        [Test]
        public void CanHandle()
        {
            Assert.True(new DefaultDepreciateQuality(1).CanHandle(5, 5));
            Assert.True(new DefaultDepreciateQuality(2).CanHandle(0, 5));
            Assert.True(new DefaultDepreciateQuality(3).CanHandle(50, 5));
        }
    }
}