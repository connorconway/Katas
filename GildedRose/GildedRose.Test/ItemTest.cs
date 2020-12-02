using NUnit.Framework;

namespace GildedRose.Test
{
    [TestFixture]
    public class ItemTest
    {
        [Test]
        public void Assess()
        {
            Assert.AreEqual(Item.Legendary("legendary"), Item.Legendary("legendary").Assess());

            Assert.AreEqual(Item.Standard("standard", 4, 4), Item.Standard("standard", 5, 5).Assess());
            Assert.AreEqual(Item.Standard("does not go below 0", 4, 0), Item.Standard("does not go below 0", 5, 0).Assess());
            Assert.AreEqual(Item.Standard("0 sellin still decreases my 1", -1, 4), Item.Standard("0 sellin still decreases my 1", 0, 5).Assess());
            Assert.AreEqual(Item.Standard("below 0 sellin decreases by 2", -2, 3), Item.Standard("below 0 sellin decreases by 2", -1, 5).Assess());

            Assert.AreEqual(Item.BackstagePass("increases by 1", 10, 6), Item.BackstagePass("increases by 1", 11, 5).Assess());
            Assert.AreEqual(Item.BackstagePass("increases by 2 when below 10 sellin", 8, 7), Item.BackstagePass("increases by 2 when below 10 sellin", 9, 5).Assess());
            Assert.AreEqual(Item.BackstagePass("increases by 3 when below 5 sellin", 3, 8), Item.BackstagePass("increases by 3 when below 5 sellin", 4, 5).Assess());
            Assert.AreEqual(Item.BackstagePass("does not go beyond 50", 3, 50), Item.BackstagePass("does not go beyond 50", 4, 48).Assess());
        }
    }
}