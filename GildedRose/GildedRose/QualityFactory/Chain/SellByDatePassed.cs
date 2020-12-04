namespace GildedRose.QualityFactory.Chain
{
    public class SellByDatePassed : IQualityFactory
    {
        private readonly int _depreciatingQualityMultiplier;
        private const int MinimumQuality = 0;
        private const int SellByToday = 0;
        private const int BaseQualityDepreciation = 2;

        public SellByDatePassed(int depreciatingQualityMultiplier) => _depreciatingQualityMultiplier = depreciatingQualityMultiplier;

        public int Quality(int currentQuality, int currentSellin) => (currentQuality -= BaseQualityDepreciation * _depreciatingQualityMultiplier) < MinimumQuality ? MinimumQuality : currentQuality;

        public bool CanHandle(int currentQuality, int currentSellin) => currentSellin < SellByToday;
    }
}