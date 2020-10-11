using System;

namespace RockPaperScissors
{
    public class HandShape : IEquatable<HandShape>
    {
        private readonly string _value;

        private HandShape(string value)
        {
            _value = value;
        }

        public static HandShape Rock()
        {
            return new HandShape("Rock");
        }

        public bool Equals(HandShape other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _value == other._value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((HandShape) obj);
        }

        public override int GetHashCode()
        {
            return (_value != null ? _value.GetHashCode() : 0);
        }
    }
}
