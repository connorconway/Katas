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
            var service = new StockAssessingService();
            var stockToUpdate = new List<IItem>
            {
                new LegendaryItem("Sulfurus"),
                new StandardItem("standard", 5, 5),
                new StandardItem("quality never negative", 5, 0),
                new BackstagePass("increase by 3 when 5 days or less", 5, 5),
                new BackstagePass("increase by 2 when 10 days or less", 10, 5),
                new BackstagePass("increase by 1 more than 10 days", 11, 5),
                new StandardItem("sell by date has passed", -1, 5),
                new BackstagePass("quality never more than 50", -1, 50),
            };

            var expectedStock = new List<IItem>
            {
                new LegendaryItem("Sulfurus"),
                new StandardItem("standard", 4, 4),
                new StandardItem("quality never negative", 4, 0),
                new BackstagePass("increase by 3 when 5 days or less", 4, 8),
                new BackstagePass("increase by 2 when 10 days or less", 9, 7),
                new BackstagePass("increase by 1 more than 10 days", 10, 6),
                new StandardItem("sell by date has passed", -2, 3),
                new BackstagePass("quality never more than 50", -2, 50),
            };

            var updatedStock = service.UpdateStock(stockToUpdate);

            Assert.AreEqual(expectedStock, updatedStock);
        }
    }
}