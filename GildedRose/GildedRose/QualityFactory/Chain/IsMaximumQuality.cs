namespace GildedRose.QualityFactory.Chain
{
    public class IsMaximumQuality : IQualityFactory
    {
        private const int MaximumQuality = 50;

        public int Quality(int currentQuality, int currentSellin) => currentQuality;

        public bool CanHandle(int currentQuality, int currentSellin) => currentQuality == MaximumQuality;
    }
}