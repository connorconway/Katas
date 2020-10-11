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
            Assert.False(HandShape.Rock().Beats(HandShape.Paper()));
            Assert.False(HandShape.Rock().Beats(HandShape.Rock()));
            Assert.True(HandShape.Scissors().Beats(HandShape.Paper()));
            Assert.False(HandShape.Scissors().Beats(HandShape.Rock()));
            Assert.False(HandShape.Scissors().Beats(HandShape.Scissors()));
            Assert.True(HandShape.Paper().Beats(HandShape.Rock()));
            Assert.False(HandShape.Paper().Beats(HandShape.Scissors()));
            Assert.False(HandShape.Paper().Beats(HandShape.Paper()));
        }
    }
}