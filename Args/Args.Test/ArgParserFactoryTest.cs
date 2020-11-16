using System.Collections.Generic;
using NUnit.Framework;

namespace Args.Test
{
    [TestFixture]
    public class ArgParserFactoryTest
    {
        [Test]
        public void Parse()
        {
            Assert.IsEmpty(new ArgParserFactory().Parse(new string[0]));
            Assert.IsEmpty(new ArgParserFactory().Parse(new []{""}));
            CollectionAssert.AreEqual(new List<object> {true}, new ArgParserFactory().Parse(new[] {"-b"}));
            CollectionAssert.AreEqual(new List<object> {"hello"}, new ArgParserFactory().Parse(new[] {"-s hello"}));
            CollectionAssert.AreEqual(new List<object> {32}, new ArgParserFactory().Parse(new[] {"-i 32"}));

            CollectionAssert.AreEquivalent(new List<object> {true, "hello", 32}, new ArgParserFactory().Parse(new[] {"-b", "-s hello", "-i 32"}));
        }
    }
}