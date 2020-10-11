using System;
using NUnit.Framework;

namespace RockPaperScissors.Test
{
    [TestFixture]
    public class GameTest
    {
        private Player _scissorsPlayer;
        private Player _rockPlayer;

        [SetUp]
        public void SetUp()
        {
            _scissorsPlayer = new Player("bob", Player.ScissorsStrategy);
            _rockPlayer = new Player("harry", Player.RockStrategy);
        }

        [Test]
        public void PlayRound_returns_winner_of_round()
        {
            var game = new Game(_rockPlayer, _scissorsPlayer, 1);
            Assert.AreEqual(_rockPlayer,game.PlayRound());
        }

        [Test]
        public void PlayRound_throws_after_max_number_of_rounds()
        {
            var game = new Game(_rockPlayer, _scissorsPlayer, 1);
            game.PlayRound();
            Assert.Throws<ArgumentException>(() => game.PlayRound(),
                "Maximum number of rounds have been reached. Please start a new game.");
        }

        [Test]
        public void Winner_when_one_round()
        {
            var game = new Game(_rockPlayer, _scissorsPlayer, 1);
            game.PlayRound();
            Assert.AreEqual(_rockPlayer, game.Winner());
        }

        [Test]
        public void Winner_when_two_rounds()
        {
            var game = new Game(_rockPlayer, _scissorsPlayer, 2);
            game.PlayRound();
            game.PlayRound();
            Assert.AreEqual(_rockPlayer, game.Winner());
        }

        [Test]
        public void Winner_when_not_enough_rounds_are_played()
        {
            var game = new Game(_rockPlayer, _scissorsPlayer, 3);
            game.PlayRound();
            Assert.Throws<ArgumentException>(() => game.Winner(),
                "Unable to determine a winner. Please continue playing rounds.");

        }
    }
}