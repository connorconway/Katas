using System;

namespace GildedRose
{
    public class CompositeItemFactory : IItemFactory
    {
        private readonly IItemFactory _one;
        private readonly IItemFactory _two;

        public CompositeItemFactory(IItemFactory one, IItemFactory two)
        {
            _one = one;
            _two = two;
        }

        public IItem Degrade(IItem standardItem)
        {
            if (_one.CanHandle(standardItem))
                return _one.Degrade(standardItem);
            if (_two.CanHandle(standardItem))
                return _two.Degrade(standardItem);
            throw new InvalidOperationException();
        }

        public bool CanHandle(IItem standardItem) => _one.CanHandle(standardItem) || _two.CanHandle(standardItem);
    }
}