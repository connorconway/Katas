namespace GildedRose.Items
{
    public interface IItem
    {
        IItem Assess(int sellInBy, int qualityBy);
    }
}