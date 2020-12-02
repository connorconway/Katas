using System.Collections.Generic;
using System.Linq;

namespace GildedRose
{
    public class StockAssessingService
    {
        public IEnumerable<Item> UpdateStock(IEnumerable<Item> stock) => stock.Select(item => item.Assess());
    }
}