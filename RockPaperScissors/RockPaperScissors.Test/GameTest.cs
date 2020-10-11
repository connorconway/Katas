using NUnit.Framework;

namespace RockPaperScissors.Test
{
    [TestFixture]
    public class GameTest
    {
        [Test]
        public void PlayRound()
        {
            var paperPlayer = new Player("connor", Player.PaperStrategy);
            var scissorsPlayer = new Player("bob", Player.ScissorsStrategy);
            var rockPlayer = new Player("harry", Player.RockStrategy);

            var game = new Game(rockPlayer, scissorsPlayer, 1);
            Assert.AreEqual(rockPlayer,game.PlayRound());
        }

        [Test]
        public void Winner_when_one_round()
        {
            var paperPlayer = new Player("connor", Player.PaperStrategy);
            var scissorsPlayer = new Player("bob", Player.ScissorsStrategy);
            var rockPlayer = new Player("harry", Player.RockStrategy);

            var game = new Game(rockPlayer, scissorsPlayer, 1);
            game.PlayRound();
            Assert.AreEqual(rockPlayer, game.Winner());
        }
    }
}