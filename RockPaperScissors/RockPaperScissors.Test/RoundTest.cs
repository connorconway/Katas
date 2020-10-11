using NUnit.Framework;

namespace RockPaperScissors.Test
{
    [TestFixture]
    public class RoundTest
    {
        [Test]
        public void Winner()
        {
            var paperPlayer = new Player("connor", Player.PaperStrategy);
            var scissorsPlayer = new Player("bob", Player.ScissorsStrategy);
            var rockPlayer = new Player("harry", Player.RockStrategy);

            var round = new Round(paperPlayer, scissorsPlayer);
            Assert.AreEqual(scissorsPlayer, round.Winner());

            round = new Round(paperPlayer, rockPlayer);
            Assert.AreEqual(paperPlayer, round.Winner());

            round = new Round(rockPlayer, scissorsPlayer);
            Assert.AreEqual(rockPlayer, round.Winner());
        }
    }
}