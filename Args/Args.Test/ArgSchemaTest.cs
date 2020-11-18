using Args.ArgParsers;
using NUnit.Framework;

namespace Args.Test
{
    [TestFixture]
    public class ArgSchemaTest
    {
        [Test]
        public void HasBoolArg()
        {
            var argSchema = new ArgSchema();
            argSchema.Add<bool>('b');
            Assert.True(argSchema.HasBoolArg('b'));
            Assert.False(argSchema.HasBoolArg('g'));
        }

        [Test]
        public void HasStringArg()
        {
            var argSchema = new ArgSchema();
            argSchema.Add<string>('b');
            Assert.True(argSchema.HasStringArg('b'));
            Assert.False(argSchema.HasStringArg('g'));
        }

        [Test]
        public void HasIntArg()
        {
            var argSchema = new ArgSchema();
            argSchema.Add<int>('b');
            Assert.True(argSchema.HasIntArg('b'));
            Assert.False(argSchema.HasIntArg('g'));
        }

        [Test]
        public void BoolArgParser()
        {
            var argSchema = new ArgSchema();
            argSchema.Add<bool>('b');
            Assert.AreEqual(typeof(BoolArgParser), argSchema.BoolArgParser('b').GetType());
        }

        [Test]
        public void StringArgParser()
        {
            var argSchema = new ArgSchema();
            argSchema.Add<string>('b');
            Assert.AreEqual(typeof(StringArgParser), argSchema.StringArgParser('b').GetType());
        }

        [Test]
        public void IntArgParser()
        {
            var argSchema = new ArgSchema();
            argSchema.Add<int>('b');
            Assert.AreEqual(typeof(IntArgParser), argSchema.IntArgParser('b').GetType());
        }
    }
}