using System.Collections.Generic;
using System.Linq;
using StringCalculator.NumberFilters;

namespace StringCalculator
{
    public class Calculator
    {
        public static int Add(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
                return 0;

            var numbers = Delimiters.SplitString(inputString)
                .Select(int.Parse)
                .ToList();

            var numberFilters = new List<INumberFilter>
            {
                new RemoveGreaterThan1000(),
                new RemoveNegative()
            };

            var sum = 0;
            numberFilters
                .Aggregate(numbers, (current, filter) => filter.Apply(current))
                .ForEach(n => sum += n);
            return sum;
        }
    }
}