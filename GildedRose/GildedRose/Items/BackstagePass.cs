using System;

namespace GildedRose.Items
{
    public class BackstagePass : IItem, IEquatable<BackstagePass>
    {
        private readonly string _name;
        private int _sellIn;
        private int _quality;

        public BackstagePass(string name, int sellIn, int quality)
        {
            _name = name;
            _sellIn = sellIn;
            _quality = quality;
        }

        private bool IsMaxQuality() => _quality == 50;

        public IItem Assess(int sellInBy, int qualityBy)
        {
            if (IsMaxQuality())
                return new BackstagePass(_name, _sellIn -= sellInBy, _quality);

            if (_sellIn <= 5)
                return new BackstagePass(_name, _sellIn -= sellInBy, (_quality += qualityBy*3) > 50 ? 50 : _quality);

            if (_sellIn <= 10)
                return new BackstagePass(_name, _sellIn -= sellInBy, (_quality += qualityBy*2) > 50 ? 50 : _quality);

            return new BackstagePass(_name, _sellIn-=sellInBy, _quality += qualityBy);
        }

        public bool Equals(BackstagePass other)
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
            return Equals((BackstagePass) obj);
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