using System;
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
            var schema = new ArgSchema()
                .Add<bool>('b')
                .Add<string>('s')
                .Add<int>('i');

            Assert.IsEmpty(new ArgParserFactory(schema).Parse(new string[0]));
            
            CollectionAssert.AreEqual(new List<object> {true}, new ArgParserFactory(schema).Parse(new[] {"-b"}));
            CollectionAssert.AreEqual(new List<object> {"hello"}, new ArgParserFactory(schema).Parse(new[] {"-s hello"}));
            CollectionAssert.AreEqual(new List<object> {32}, new ArgParserFactory(schema).Parse(new[] {"-i 32"}));
            CollectionAssert.AreEquivalent(new List<object> {true, "hello", 32}, new ArgParserFactory(schema).Parse(new[] {"-b", "-s hello", "-i 32"}));
            
            Assert.Throws<ArgumentException>(() => new ArgParserFactory(schema).Parse(new[] {"-b boolean_shouldnt_have_a_value"}));
            Assert.Throws<ArgumentException>(() => new ArgParserFactory(schema).Parse(new[] {"-g not_defined_in_schema"}));
        }
    }
}