namespace GildedRose.QualityFactory.Chain
{
    public class DoubleAppreciateQuality : IQualityFactory
    {
        private const int DaysLeftForQualityAppreciation = 10;
        private const int MaximumQuality = 50;

        public int Quality(int currentQuality, int currentSellin) => (currentQuality += 2) > MaximumQuality ? MaximumQuality : currentQuality;

        public bool CanHandle(int currentQuality, int currentSellin) => currentSellin <= DaysLeftForQualityAppreciation;
    }
}