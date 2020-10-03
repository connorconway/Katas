using System.Collections.Generic;

namespace StringCalculator.NumberFilters
{
    public interface INumberFilter
    {
        List<int> Apply(List<int> original);
    }
}