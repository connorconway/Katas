namespace GildedRose.QualityFactory.Chain
{
    public class DefaultDepreciateQuality : IQualityFactory
    {
        private readonly int _depreciatingQualityMultiplier;
        private const int BaseQualityDepreciation = 1;
        private const int MinimumQuality = 0;

        public DefaultDepreciateQuality(int depreciatingQualityMultiplier) => _depreciatingQualityMultiplier = depreciatingQualityMultiplier;

        public int Quality(int currentQuality, int currentSellin) => (currentQuality -= BaseQualityDepreciation * _depreciatingQualityMultiplier) < MinimumQuality ? MinimumQuality : currentQuality;

        public bool CanHandle(int currentQuality, int currentSellin) => true;
    }
}