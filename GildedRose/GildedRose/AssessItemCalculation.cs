using System;

namespace GildedRose
{
    public class AssessItemCalculation
    {
        private const int MinimumQuality = 0;
        private const int MaximumQuality = 50;
        private const int DegradeByWhenPassedSellByDate = 2;
        private const int DaysLeftForTrippleQualityAppreciation = 5;
        private const int DaysLeftForDoubleQualityAppreciation = 10;

        public static readonly Func<int, int, int> DepreciatingQualityAssessment = (quality, sellIn) =>
        {
            if (quality == MinimumQuality)
                return quality;

            if (sellIn < 0)
                return (quality -= DegradeByWhenPassedSellByDate) < MinimumQuality ? MinimumQuality : quality;

            return --quality;
        };

        public static readonly Func<int, int, int> AppreciatingQualityAssessment = (quality, sellIn) =>
        {
            if (quality == MaximumQuality)
                return MaximumQuality;

            if (sellIn <= DaysLeftForTrippleQualityAppreciation)
                return (quality += 3) > MaximumQuality ? MaximumQuality : quality;

            if (sellIn <= DaysLeftForDoubleQualityAppreciation)
                return (quality += 2) > MaximumQuality ? MaximumQuality : quality;

            return ++quality;
        };

        public static readonly Func<int, int, int> UnchangedQualityAssessment = (quality, sellIn) => quality;

        public static readonly Func<int, int, int> ItemAgingAssessment = (quality, sellIn) => sellIn - 1;

        public static readonly Func<int, int, int> NoNeedToSellAssessment = (quality, sellIn) => sellIn;

        public int Quality(int quality, int sellIn, Func<int, int, int> itemAssessmentMethod) => itemAssessmentMethod(quality, sellIn);
    }
}   