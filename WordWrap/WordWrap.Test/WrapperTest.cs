using System;
using NUnit.Framework;

namespace WordWrap.Test
{
    [TestFixture]
    public class WrapperTest
    {
        [Test]
        public void Wrap()
        {
            Assert.Throws<ArgumentException>(() => Wrapper.Wrap("something here", 0), "Must split on a valid column number");

            Assert.AreEqual("", Wrapper.Wrap("", 1));

            Assert.AreEqual("one", Wrapper.Wrap("one", 4));
            Assert.AreEqual("one", Wrapper.Wrap("one", 3));
            Assert.AreEqual($"on{Environment.NewLine}e{Environment.NewLine}", Wrapper.Wrap("one", 2));
            Assert.AreEqual($"o{Environment.NewLine}n{Environment.NewLine}e{Environment.NewLine}", Wrapper.Wrap("one", 1));

            Assert.AreEqual($"one{Environment.NewLine}two{Environment.NewLine}", Wrapper.Wrap("one two", 4));
            Assert.AreEqual($"one{Environment.NewLine}two{Environment.NewLine}", Wrapper.Wrap("one two", 3));
        }
    }
}
