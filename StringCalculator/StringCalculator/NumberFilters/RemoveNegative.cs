using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator.NumberFilters
{
    public class RemoveNegative : INumberFilter
    {
        public List<int> Apply(List<int> original)
        {
            var negatives = original.Where(n => n < 0).ToList();
            if (negatives.Any())
                throw new ArgumentException($"negatives not allowed: {string.Join(", ", negatives)}");
            return original;
        }
    }
}