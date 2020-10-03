using System.Collections.Generic;
using System.Linq;

namespace StringCalculator.NumberFilters
{
    public class RemoveGreaterThan1000 : INumberFilter
    {
        public List<int> Apply(List<int> original) => original.Where(n => n < 1000).ToList();
    }
}