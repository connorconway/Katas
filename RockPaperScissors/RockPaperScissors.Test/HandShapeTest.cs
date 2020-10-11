using NUnit.Framework;

namespace RockPaperScissors.Test
{
    [TestFixture]
    public class HandShapeTest
    {
        [Test]
        public void Beats()
        {
            Assert.True(HandShape.Rock().Beats(HandShape.Scissors()));
        }
    }
}