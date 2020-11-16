using Args.ArgParsers;
using NUnit.Framework;

namespace Args.Test.ArgParsers
{
    [TestFixture]
    public class StringArgParserTest
    {
        [Test]
        public void CanParse()
        {
            Assert.True(new StringArgParser().CanParse("-s string"));
            Assert.True(new StringArgParser().CanParse("-string string"));
            Assert.False(new StringArgParser().CanParse("-s invalid as it has spaces"));
            Assert.False(new StringArgParser().CanParse("-s "));
            Assert.False(new StringArgParser().CanParse("-b"));
        }

        [Test]
        public void Parse()
        {
            Assert.AreEqual("string", new StringArgParser().Parse("-s string"));
            Assert.AreEqual("string", new StringArgParser().Parse("-string string"));
        }
    }
}