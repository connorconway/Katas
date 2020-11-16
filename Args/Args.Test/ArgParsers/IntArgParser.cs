using Args.ArgParsers;
using NUnit.Framework;

namespace Args.Test.ArgParsers
{
    [TestFixture]
    public class IntArgParserTest
    {
        [Test]
        public void CanParse()
        {
            Assert.True(new IntArgParser().CanParse("-i 32"));
            Assert.True(new IntArgParser().CanParse("-int 32"));
            Assert.True(new IntArgParser().CanParse($"-int {int.MaxValue}"));
            Assert.False(new IntArgParser().CanParse("-i NaN"));
            Assert.False(new IntArgParser().CanParse($"-i {long.MaxValue}"));
            Assert.False(new IntArgParser().CanParse("-b"));
        }

        [Test]
        public void Parse()
        {
            Assert.AreEqual(32, new IntArgParser().Parse("-i 32"));
            Assert.AreEqual(int.MaxValue, new IntArgParser().Parse($"-int {int.MaxValue}"));
        }
    }
}