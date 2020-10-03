using System;
using System.Collections.Generic;
using Greeter.Test.Logger;
using Greeter.Test.Time;
using NUnit.Framework;

namespace Greeter.Test
{
    [TestFixture]
    public class GreeterTest
    {
        [Test]
        public void Greet()
        {
            Assert.AreEqual("Hello Cman", new Greeter(new TestTimeRetrievalService(new TimeSpan(13, 0, 0)), new TestLogger()).Greet(" cman "));

            Assert.AreEqual("Good morning Cman", new Greeter(new TestTimeRetrievalService(new TimeSpan(6, 0, 0)), new TestLogger()).Greet(" cman "));
            Assert.AreEqual("Good morning Cman", new Greeter(new TestTimeRetrievalService(new TimeSpan(12, 0, 0)), new TestLogger()).Greet(" cman "));

            Assert.AreEqual("Good evening Cman", new Greeter(new TestTimeRetrievalService(new TimeSpan(18, 0, 0)), new TestLogger()).Greet(" cman "));
            Assert.AreEqual("Good evening Cman", new Greeter(new TestTimeRetrievalService(new TimeSpan(22, 0, 0)), new TestLogger()).Greet(" cman "));

            Assert.AreEqual("Good night Cman", new Greeter(new TestTimeRetrievalService(new TimeSpan(22, 0, 1)), new TestLogger()).Greet(" cman "));
            Assert.AreEqual("Good night Cman", new Greeter(new TestTimeRetrievalService(new TimeSpan(05, 59, 59)), new TestLogger()).Greet(" cman "));
        }

        [Test]
        public void Greet_logs()
        {
            var testLogger = new TestLogger();
            var greeter = new Greeter(new TestTimeRetrievalService(new TimeSpan(13, 0, 0)), testLogger);
            greeter.Greet("cman");
            greeter.Greet("cman");
            CollectionAssert.AreEqual(new List<string> { "Greeting has been called", "Greeting has been called" }, testLogger.Messages);
        }
    }
}