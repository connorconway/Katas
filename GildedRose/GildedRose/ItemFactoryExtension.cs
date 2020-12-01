namespace GildedRose
{
    public static class ItemFactoryExtension
    {
        public static IItemFactory Then(this IItemFactory first, IItemFactory second) => new CompositeItemFactory(first, second);
    }
}