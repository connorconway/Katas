namespace GildedRose
{
    public class IsBackstagePass : IItemFactory
    {
        public IItem Degrade(IItem item)
        {
            return item.Assess(1, 1);
        }

        public bool CanHandle(IItem item) => item.GetType() == typeof(BackstagePass);
    }
}