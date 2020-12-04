using System;

namespace GildedRose.QualityFactory
{
    public class CompositeQualityFactory : IQualityFactory
    {
        private readonly IQualityFactory _one;
        private readonly IQualityFactory _two;

        public CompositeQualityFactory(IQualityFactory one, IQualityFactory two)
        {
            _one = one;
            _two = two;
        }

        public int Quality(int currentQuality, int currentSellin)
        {
            if (_one.CanHandle(currentQuality, currentSellin))
                return _one.Quality(currentQuality, currentSellin);
            if (_two.CanHandle(currentQuality, currentSellin))
                return _two.Quality(currentQuality, currentSellin);
            throw new InvalidOperationException();
        }

        public bool CanHandle(int currentQuality, int currentSellin) => _one.CanHandle(currentQuality, currentSellin) || _two.CanHandle(currentQuality, currentSellin);
    }
}