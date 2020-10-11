namespace RockPaperScissors
{
    public class Round
    {
        private readonly Player _playerOne;
        private readonly Player _playerTwo;

        public Round(Player playerOne, Player playerTwo)
        {
            _playerOne = playerOne;
            _playerTwo = playerTwo;
        }

        public Player Winner() => _playerOne.GenerateShape().Beats(_playerTwo.GenerateShape()) ? _playerOne : _playerTwo;
    }
}