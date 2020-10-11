using System;

namespace RockPaperScissors
{
    public class Player : IEquatable<Player>
    {
        private readonly string _name;
        private readonly Func<HandShape> _shapeStrategy;
        public static Func<HandShape> RockStrategy => HandShape.Rock;
        public static Func<HandShape> ScissorsStrategy => HandShape.Scissors;
        public static Func<HandShape> PaperStrategy => HandShape.Paper;

        public Player(string name, Func<HandShape> shapeStrategy)
        {
            _name = name;
            _shapeStrategy = shapeStrategy;
        }

        public HandShape GenerateShape() => _shapeStrategy.Invoke();

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

        public override int GetHashCode()
        {
            return (_name != null ? _name.GetHashCode() : 0);
        }
    }
}