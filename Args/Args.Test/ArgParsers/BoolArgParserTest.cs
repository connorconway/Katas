using Args.ArgParsers;
using NUnit.Framework;

namespace Args.Test.ArgParsers
{
    [TestFixture]
    public class BoolArgParserTest
    {
        [Test]
        public void CanParse()
        {
            Assert.True(new BoolArgParser().CanParse("-b"));
            Assert.True(new BoolArgParser().CanParse("-true"));
            Assert.False(new BoolArgParser().CanParse("-notboolean value"));
            Assert.False(new BoolArgParser().CanParse("what?!"));
            Assert.False(new BoolArgParser().CanParse(""));
        }

        [Test]
        public void Parse()
        {
            Assert.True(new BoolArgParser().Parse("-b"));
            Assert.True(new BoolArgParser().Parse("-true"));
        }
    }
}