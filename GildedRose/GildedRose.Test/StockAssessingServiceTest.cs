using System.Collections.Generic;
using NUnit.Framework;

namespace GildedRose.Test
{
    [TestFixture]
    public class StockAssessingServiceTest
    {
        [Test]
        public void AssessStock()
        {
            var stockToUpdate = new List<Item>
            {
                Item.Legendary("Sulfurus"),
                Item.Standard("standard", 5, 5),
                Item.Standard("quality never negative", 5, 0),
                Item.BackstagePass("increase by 3 when 5 days or less", 5, 5),
                Item.BackstagePass("increase by 2 when 10 days or less", 10, 5),
                Item.BackstagePass("increase by 1 more than 10 days", 11, 5),
                Item.Standard("sell by date has passed", -1, 5),
                Item.BackstagePass("quality never more than 50", -1, 50),
                Item.Conjured("conjured", 5, 5),
                Item.Conjured("sell by date has passed", -1, 5)
            };

            var expectedStock = new List<Item>
            {
                Item.Legendary("Sulfurus"),
                Item.Standard("standard", 4, 4),
                Item.Standard("quality never negative", 4, 0),
                Item.BackstagePass("increase by 3 when 5 days or less", 4, 8),
                Item.BackstagePass("increase by 2 when 10 days or less", 9, 7),
                Item.BackstagePass("increase by 1 more than 10 days", 10, 6),
                Item.Standard("sell by date has passed", -2, 3),
                Item.BackstagePass("quality never more than 50", -2, 50),
                Item.Conjured("conjured", 4, 3),
                Item.Conjured("sell by date has passed", -2, 1)
            };

            CollectionAssert.AreEquivalent(expectedStock, new StockAssessingService().UpdateStock(stockToUpdate));
        }
    }
}