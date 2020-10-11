using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public class HandShape : IEquatable<HandShape>
    {
        private readonly string _value;
        private static readonly Dictionary<HandShape, HandShape> Rules = new Dictionary<HandShape, HandShape>
        {
            { Scissors(), Rock() },
            { Paper(), Scissors() },
            { Rock(), Paper() }
        };

        private HandShape(string value) => _value = value;

        public static HandShape Rock() => new HandShape("Rock");

        public static HandShape Scissors() => new HandShape("Scissors");

        public static HandShape Paper() => new HandShape("Paper");

        public bool Beats(HandShape other)
        {
            if (Equals(other))
                return false;
            Rules.TryGetValue(this, out var losesAgainstShape);
            return !losesAgainstShape.Equals(other);
        }

        public override string ToString() => _value;

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

        public override int GetHashCode() => (_value != null ? _value.GetHashCode() : 0);
    }
}
