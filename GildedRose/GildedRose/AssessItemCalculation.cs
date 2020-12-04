using System;
using GildedRose.QualityFactory;
using GildedRose.QualityFactory.Chain;

namespace GildedRose
{
    public class AssessItemCalculation
    {
        public static readonly Func<int, int, int> DepreciatingQualityAssessment = (quality, sellIn) => 
            new IsMinimumQuality()
                .Then(new SellByDatePassed(1)
                .Then(new DefaultDepreciateQuality(1)))
                .Quality(quality, sellIn);

        public static readonly Func<int, int, int> DoubleDepreciatingQualityAssessment = (quality, sellIn) =>
            new IsMinimumQuality()
                .Then(new SellByDatePassed(2)
                .Then(new DefaultDepreciateQuality(2)))
                .Quality(quality, sellIn);

        public static readonly Func<int, int, int> AppreciatingQualityAssessment = (quality, sellIn) => 
            new IsMaximumQuality()
                .Then(new TripleAppreciateQuality()
                .Then(new DoubleAppreciateQuality()
                .Then(new DefaultAppreciateQuality())))
                .Quality(quality, sellIn);

        public static readonly Func<int, int, int> UnchangedQualityAssessment = (quality, sellIn) => quality;

        public static readonly Func<int, int, int> ItemAgingAssessment = (quality, sellIn) => --sellIn;

        public static readonly Func<int, int, int> NoNeedToSellAssessment = (quality, sellIn) => sellIn;
    }
}   