using NUnit.Framework;

namespace GildedRose.Test
{
    [TestFixture]
    public class AssessItemCalculationTest
    {
        [Test]
        public void DepreciatingQualityAssessment()
        {
            Assert.AreEqual(4, AssessItemCalculation.DepreciatingQualityAssessment(5, 5));
            Assert.AreEqual(4, AssessItemCalculation.DepreciatingQualityAssessment(5, 0));
            Assert.AreEqual(3, AssessItemCalculation.DepreciatingQualityAssessment(5, -1));
            Assert.AreEqual(0, AssessItemCalculation.DepreciatingQualityAssessment(0, 5));
        }

        [Test]
        public void DoubleDepreciatingQualityAssessment()
        {
            Assert.AreEqual(3, AssessItemCalculation.DoubleDepreciatingQualityAssessment(5, 5));
            Assert.AreEqual(3, AssessItemCalculation.DoubleDepreciatingQualityAssessment(5, 0));
            Assert.AreEqual(1, AssessItemCalculation.DoubleDepreciatingQualityAssessment(5, -1));
            Assert.AreEqual(0, AssessItemCalculation.DoubleDepreciatingQualityAssessment(0, 5));
            Assert.AreEqual(0, AssessItemCalculation.DoubleDepreciatingQualityAssessment(1, -1));
        }

        [Test]
        public void AppreciatingQualityAssessment()
        {
            Assert.AreEqual(50, AssessItemCalculation.AppreciatingQualityAssessment(50, 5));
            Assert.AreEqual(6, AssessItemCalculation.AppreciatingQualityAssessment(5, 11));
            Assert.AreEqual(7, AssessItemCalculation.AppreciatingQualityAssessment(5, 6));
            Assert.AreEqual(8, AssessItemCalculation.AppreciatingQualityAssessment(5, 4));
        }

        [Test]
        public void UnchangedQualityAssessment()
        {
            Assert.AreEqual(5, AssessItemCalculation.UnchangedQualityAssessment(5, 6));
            Assert.AreEqual(50, AssessItemCalculation.UnchangedQualityAssessment(50, -1));
            Assert.AreEqual(0, AssessItemCalculation.UnchangedQualityAssessment(0, -1));
        }

        [Test]
        public void ItemAgingAssessment()
        {
            Assert.AreEqual(4, AssessItemCalculation.ItemAgingAssessment(5, 5));
            Assert.AreEqual(4, AssessItemCalculation.ItemAgingAssessment(50, 5));
            Assert.AreEqual(4, AssessItemCalculation.ItemAgingAssessment(0, 5));
            Assert.AreEqual(-1, AssessItemCalculation.ItemAgingAssessment(5, 0));
            Assert.AreEqual(-2, AssessItemCalculation.ItemAgingAssessment(5, -1));
        }

        [Test]
        public void NoNeedToSellAssessment()
        {
            Assert.AreEqual(6, AssessItemCalculation.NoNeedToSellAssessment(5, 6));
            Assert.AreEqual(-1, AssessItemCalculation.NoNeedToSellAssessment(50, -1));
        }
    }
}