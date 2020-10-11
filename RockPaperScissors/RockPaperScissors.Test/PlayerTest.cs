using NUnit.Framework;

namespace RockPaperScissors.Test
{
    [TestFixture]
    public class PlayerTest
    {
        [Test]
        public void GenerateShape()
        {
            Assert.AreEqual(HandShape.Rock(), new Player(Player.RockStrategy).GenerateShape());
            Assert.AreEqual(HandShape.Scissors(), new Player(Player.ScissorsStrategy).GenerateShape());
            Assert.AreEqual(HandShape.Paper(), new Player(Player.PaperStrategy).GenerateShape());
        }
    }
}
