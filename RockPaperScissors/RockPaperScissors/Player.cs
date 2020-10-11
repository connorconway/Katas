using System;

namespace RockPaperScissors
{
    public class Player
    {
        private readonly Func<HandShape> _shapeStrategy;

        public Player(Func<HandShape> shapeStrategy)
        {
            _shapeStrategy = shapeStrategy;
        }

        public HandShape GenerateShape() => _shapeStrategy.Invoke();
    }
}