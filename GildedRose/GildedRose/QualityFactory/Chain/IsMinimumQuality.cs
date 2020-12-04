namespace GildedRose.QualityFactory.Chain
{
    public class IsMinimumQuality : IQualityFactory
    {
        private const int MinimumQuality = 0;

        public int Quality(int currentQuality, int currentSellin) => currentQuality;

        public bool CanHandle(int currentQuality, int currentSellin) => currentQuality == MinimumQuality;
    }
}