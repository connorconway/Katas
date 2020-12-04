namespace GildedRose.QualityFactory
{
    public static class QualityFactoryChaining
    {
        public static IQualityFactory Then(this IQualityFactory first, IQualityFactory second) => new CompositeQualityFactory(first, second);
    }
}