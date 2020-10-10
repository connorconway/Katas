using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace PrimeFactors.Test
{
    [TestFixture]
    public class PrimeFactorsTest
    {
        [Test]
        public void Generate()
        {
            CollectionAssert.AreEqual(Enumerable.Empty<int>(), PrimeFactors.Generate(1));
            CollectionAssert.AreEqual(new List<int> { 2 }, PrimeFactors.Generate(2));
            CollectionAssert.AreEqual(new List<int> { 3 }, PrimeFactors.Generate(3));
            CollectionAssert.AreEqual(new List<int> { 2, 2 }, PrimeFactors.Generate(4));
            CollectionAssert.AreEqual(new List<int> { 5 }, PrimeFactors.Generate(5));
            CollectionAssert.AreEqual(new List<int> { 2, 3 }, PrimeFactors.Generate(6));
            CollectionAssert.AreEqual(new List<int> { 7 }, PrimeFactors.Generate(7));
            CollectionAssert.AreEqual(new List<int> { 2, 2, 2 }, PrimeFactors.Generate(8));
            CollectionAssert.AreEqual(new List<int> { 3, 3 }, PrimeFactors.Generate(9));
            CollectionAssert.AreEqual(new List<int> { 2, 2, 3, 5, 7, 11 }, PrimeFactors.Generate(4620));
        }
    }
}
