using System;

namespace RockPaperScissors
{
    public class Player : IEquatable<Player>
    {
        private readonly string _name;
        private readonly Func<HandShape> _shapeStrategy;

        public Player(string name, Func<HandShape> shapeStrategy)
        {
            _name = name;
            _shapeStrategy = shapeStrategy;
        }

        public static Player Computer(ILogger logger) => new Player("AI", RandomMoveStrategy(logger));

        public static Player Human(string name, Func<HandShape> shapeStrategy) => new Player(name, shapeStrategy);

        public HandShape GenerateShape() => _shapeStrategy();

        private static Func<HandShape> RandomMoveStrategy(ILogger logger)
        {
            var random = new Random();
            var number = random.Next(0, 3);
            switch (number)
            {
                case 0:
                    logger.Log("Computer chooses Rock");
                    return HandShape.Rock;
                case 1:
                    logger.Log("Computer chooses Scissors");
                    return HandShape.Scissors;
                case 2:
                    logger.Log("Computer chooses Paper");
                    return HandShape.Paper;
                default:
                    throw new ArgumentException("Unable to determine a hand shape");
            }
        }

        public override string ToString() => _name;

        public bool Equals(Player other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _name == other._name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Player) obj);
        }

        public override int GetHashCode() => (_name != null ? _name.GetHashCode() : 0);
    }
}