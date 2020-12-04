using System;

namespace GildedRose
{
    public class Item : IEquatable<Item>
    {
        private const int LegendaryItemQuality = 80;
        private readonly string _name;
        private int _sellIn;
        private int _quality;
        private readonly Func<int, int, int> _assessQualityMethod;
        private readonly Func<int, int, int> _assessSellInMethod;

        private Item(string name, int sellIn, int quality, Func<int, int, int> assessQualityMethod, Func<int, int, int> assessSellInMethod)
        {
            _name = name;
            _sellIn = sellIn;
            _quality = quality;
            _assessQualityMethod = assessQualityMethod;
            _assessSellInMethod = assessSellInMethod;
        }

        public static Item Legendary(string name) => new Item(name, int.MaxValue, LegendaryItemQuality, AssessItemCalculation.UnchangedQualityAssessment, AssessItemCalculation.NoNeedToSellAssessment);
        public static Item Standard(string name, int sellIn, int quality) => new Item(name, sellIn, quality, AssessItemCalculation.DepreciatingQualityAssessment, AssessItemCalculation.ItemAgingAssessment);
        public static Item BackstagePass(string name, int sellIn, int quality) => new Item(name, sellIn, quality, AssessItemCalculation.AppreciatingQualityAssessment, AssessItemCalculation.ItemAgingAssessment);
        public static Item Conjured(string name, int sellIn, int quality) => new Item(name, sellIn, quality, AssessItemCalculation.DoubleDepreciatingQualityAssessment, AssessItemCalculation.ItemAgingAssessment);

        public Item Assess()
        {
            _quality = _assessQualityMethod.Invoke(_quality, _sellIn);
            _sellIn = _assessSellInMethod.Invoke(_quality, _sellIn);
            return new Item(_name, _sellIn, _quality, _assessQualityMethod, _assessSellInMethod);
        }

        public bool Equals(Item other)
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
            return Equals((Item) obj);
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