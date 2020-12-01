using System;

namespace GildedRose.Items
{
    public class LegendaryItem : IItem, IEquatable<LegendaryItem>
    {
        private readonly int _quality;
        private readonly string _name;

        public LegendaryItem(string name)
        {
            _name = name;
            _quality = 80;
        }

        public IItem Assess(int sellInBy, int qualityBy) => this;

        public bool Equals(LegendaryItem other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _quality == other._quality && _name == other._name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((LegendaryItem) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (_quality * 397) ^ (_name != null ? _name.GetHashCode() : 0);
            }
        }
    }
}