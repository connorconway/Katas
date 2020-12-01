using System;

namespace GildedRose.Items
{
    public class StandardItem : IItem, IEquatable<StandardItem>
    {
        private readonly string _name;
        private int _sellIn;
        private int _quality;

        public StandardItem(string name, int sellIn, int quality)
        {
            _name = name;
            _sellIn = sellIn;
            _quality = quality;
        }

        public bool IsSubStandard() => _quality == 0;
        
        public bool IsExpired() => _sellIn < 0;

        public IItem Assess(int sellInBy, int qualityBy)
        {
            if (IsSubStandard())
                return new StandardItem(_name, _sellIn -= sellInBy, _quality);

            if (IsExpired())
                return new StandardItem(_name, _sellIn -= sellInBy, (_quality -= qualityBy * 2) < 0 ? 0 : _quality);

            return new StandardItem(_name, _sellIn -= sellInBy, _quality -= qualityBy);
        }

        public bool Equals(StandardItem other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _name == other._name && _sellIn == other._sellIn && _quality == other._quality;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((StandardItem) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_name != null ? _name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ _sellIn;
                hashCode = (hashCode * 397) ^ _quality;
                return hashCode;
            }
        }

    }
}
