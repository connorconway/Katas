using System;

namespace RockPaperScissors.Test
{
    public static class PlayerTestStrategies
    {
        public static Func<HandShape> Rock => HandShape.Rock;
        public static Func<HandShape> Scissors => HandShape.Scissors;
        public static Func<HandShape> Paper => HandShape.Paper;
    }
}