using System.Collections.Generic;
using GildedRose.Items;

namespace GildedRose
{
    public class StockAssessingService
    {
        public IEnumerable<IItem> UpdateStock(IEnumerable<IItem> stock)
        {
            var assessedStock = new List<IItem>();
            foreach (var item in stock)
            {
                var assessedItem = new IsLegendary()
                    .Then(new IsBackstagePass())
                    .Then(new IsStandard())
                    .Degrade(item);
                assessedStock.Add(assessedItem);
            }

            return assessedStock;
        }
    }
}