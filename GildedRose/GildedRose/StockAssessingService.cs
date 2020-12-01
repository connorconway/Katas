using System.Collections.Generic;
using System.Linq;
using GildedRose.Items;

namespace GildedRose
{
    public class StockAssessingService
    {
        public IEnumerable<Item> UpdateStock(IEnumerable<Item> stock)
        {
            return stock.Select(item => item.Assess()).ToList();
        }
    }
}