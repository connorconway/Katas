namespace GildedRose.QualityFactory
{
    public interface IQualityFactory
    {
        int Quality(int currentQuality, int currentSellin);
        bool CanHandle(int currentQuality, int currentSellin);
    }
}