namespace GildedRose
{
    public class IsStandard : IItemFactory
    {
        public IItem Degrade(IItem item) => item.Assess(1, 1);

        public bool CanHandle(IItem item) => true;
    }
}