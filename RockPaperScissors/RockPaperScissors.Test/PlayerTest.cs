using NUnit.Framework;

namespace RockPaperScissors.Test
{
    [TestFixture]
    public class PlayerTest
    {
        [Test]
        public void GenerateShape()
        {
            Assert.AreEqual(HandShape.Rock(), new Player("connor", PlayerTestStrategies.Rock).GenerateShape());
            Assert.AreEqual(HandShape.Scissors(), new Player("bob", PlayerTestStrategies.Scissors).GenerateShape());
            Assert.AreEqual(HandShape.Paper(), new Player("harry", PlayerTestStrategies.Paper).GenerateShape());
        }
    }
}