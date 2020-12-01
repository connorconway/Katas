namespace GildedRose
{
    public class IsLegendary : IItemFactory
    {
        public IItem Degrade(IItem item) => item;

        public bool CanHandle(IItem item) => item.GetType() == typeof(LegendaryItem);
    }
}