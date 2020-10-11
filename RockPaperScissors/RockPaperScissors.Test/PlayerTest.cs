using NUnit.Framework;

namespace RockPaperScissors.Test
{
    [TestFixture]
    public class PlayerTest
    {
        [Test]
        public void GenerateShape()
        {
            Assert.AreEqual(HandShape.Rock(), new Player().GenerateShape());
        }
    }
}
