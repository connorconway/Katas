namespace GildedRose
{
    public interface IItemFactory
    {
        IItem Degrade(IItem item);
        bool CanHandle(IItem item);
    }
}