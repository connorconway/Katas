namespace GildedRose.QualityFactory.Chain
{
    public class DefaultAppreciateQuality : IQualityFactory
    {
        private const int MaximumQuality = 50;

        public int Quality(int currentQuality, int currentSellin) => ++currentQuality > MaximumQuality ? MaximumQuality : currentQuality;

        public bool CanHandle(int currentQuality, int currentSellin) => true;
    }
}