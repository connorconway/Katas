using System.Collections.Generic;

namespace PrimeFactors
{
    public static class PrimeFactors
    {
        public static IEnumerable<int> Generate(int number)
        {
            for (var divisor = 2; number > 1; divisor++)
                for (; number % divisor == 0; number /= divisor)
                    yield return divisor;
        }
    }
}