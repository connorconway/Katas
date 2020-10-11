using System;
using NUnit.Framework;

namespace RockPaperScissors.Test
{
    [TestFixture]
    public class PlayerTest
    {
        private static Func<HandShape> RockStrategy => HandShape.Rock;
        private static Func<HandShape> ScissorsStrategy => HandShape.Scissors;
        private static Func<HandShape> PaperStrategy => HandShape.Paper;

        [Test]
        public void GenerateShape()
        {
            Assert.AreEqual(HandShape.Rock(), new Player(RockStrategy).GenerateShape());
            Assert.AreEqual(HandShape.Scissors(), new Player(ScissorsStrategy).GenerateShape());
            Assert.AreEqual(HandShape.Paper(), new Player(PaperStrategy).GenerateShape());
        }
    }
}
