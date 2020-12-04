using GildedRose.QualityFactory;
using NUnit.Framework;

namespace GildedRose.Test.QualityFactory
{
    [TestFixture]
    public class CompositeQualityFactoryTest
    {
        [Test]
        public void Quality()
        {
            Assert.AreEqual(1, new CompositeQualityFactory(new AbleToHandleFactory(), new UnableToHandleFactory()).Quality(5,5));
            Assert.AreEqual(1, new CompositeQualityFactory(new UnableToHandleFactory(), new AbleToHandleFactory()).Quality(5,5));
        }

        [Test]
        public void CanHandle()
        {
            Assert.True(new CompositeQualityFactory(new AbleToHandleFactory(), new AbleToHandleFactory()).CanHandle(5, 5));
            Assert.True(new CompositeQualityFactory(new AbleToHandleFactory(), new UnableToHandleFactory()).CanHandle(5, 5));
            Assert.True(new CompositeQualityFactory(new UnableToHandleFactory(), new AbleToHandleFactory()).CanHandle(5, 5));
            Assert.False(new CompositeQualityFactory(new UnableToHandleFactory(), new UnableToHandleFactory()).CanHandle(5, 5));
        }

        private class UnableToHandleFactory : IQualityFactory
        {
            public int Quality(int currentQuality, int currentSellin) => 0;

            public bool CanHandle(int currentQuality, int currentSellin) => false;
        }

        private class AbleToHandleFactory : IQualityFactory
        {
            public int Quality(int currentQuality, int currentSellin) => 1;

            public bool CanHandle(int currentQuality, int currentSellin) => true;
        }
    }
}