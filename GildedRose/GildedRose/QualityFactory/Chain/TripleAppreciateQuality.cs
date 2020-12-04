namespace GildedRose.QualityFactory.Chain
{
    public class TripleAppreciateQuality : IQualityFactory
    {
        private const int DaysLeftForQualityAppreciation = 5;
        private const int MaximumQuality = 50;

        public int Quality(int currentQuality, int currentSellin) => (currentQuality += 3) > MaximumQuality ? MaximumQuality : currentQuality;

        public bool CanHandle(int currentQuality, int currentSellin) => currentSellin <= DaysLeftForQualityAppreciation;
    }
}