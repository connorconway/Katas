using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public class Game
    {
        private readonly Player _playerOne;
        private readonly Player _playerTwo;
        private readonly int _maxNumberOfRounds;
        private readonly Dictionary<Player, int> _scores = new Dictionary<Player, int>();
        private int _roundsPlayed;

        public Game(Player playerOne, Player playerTwo, int numberOfRounds)
        {
            _playerOne = playerOne;
            _playerTwo = playerTwo;
            _scores.Add(_playerOne, 0);
            _scores.Add(_playerTwo, 0);
            _maxNumberOfRounds = numberOfRounds;
        }

        public Player PlayRound()
        {
            if (_roundsPlayed == _maxNumberOfRounds)
                throw new ArgumentException("Maximum number of rounds have been reached. Please start a new game.");

            var roundWinner = new Round(_playerOne, _playerTwo).Winner();
            if (roundWinner.Equals(_playerOne)) 
                _scores[_playerOne]++;
            else
                _scores[_playerTwo]++;
            _roundsPlayed++;
            return roundWinner;
        }

        public Player Winner()
        {
            if (_roundsPlayed < _maxNumberOfRounds)
                throw new ArgumentException("Unable to determine a winner. Please continue playing rounds.");
            var player1Score = _scores[_playerOne];
            var player2Score = _scores[_playerTwo];

            return player1Score > player2Score ? _playerOne : _playerTwo;
        }
    }
}