using NUnit.Framework;

namespace RockPaperScissors.Test
{
    [TestFixture]
    public class PlayerTest
    {
        [Test]
        public void GenerateShape()
        {
            Assert.AreEqual(HandShape.Rock(), new Player("connor", Player.RockStrategy).GenerateShape());
            Assert.AreEqual(HandShape.Scissors(), new Player("bob", Player.ScissorsStrategy).GenerateShape());
            Assert.AreEqual(HandShape.Paper(), new Player("harry", Player.PaperStrategy).GenerateShape());
        }
    }
}
