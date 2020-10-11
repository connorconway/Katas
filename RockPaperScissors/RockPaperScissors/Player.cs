using System;

namespace RockPaperScissors
{
    public class Player
    {
        private readonly Func<HandShape> _shapeStrategy;
        public static Func<HandShape> RockStrategy => HandShape.Rock;
        public static Func<HandShape> ScissorsStrategy => HandShape.Scissors;
        public static Func<HandShape> PaperStrategy => HandShape.Paper;

        public Player(Func<HandShape> shapeStrategy) => _shapeStrategy = shapeStrategy;

        public HandShape GenerateShape() => _shapeStrategy.Invoke();
    }
}