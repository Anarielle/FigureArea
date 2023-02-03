using FigureArea;

namespace FigureAreaTests
{
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAreaTest()
        {            
            double expected = 6;
            double actual = new Triangle(3,4,5).CalcArea();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test] 
        public void ExistTest()
        {
            Assert.Catch<ArgumentOutOfRangeException>(() => new Triangle(3,5,8));
        }

        [Test]
        public void NegativeNumberTest()
        {
            Assert.Catch<ArgumentOutOfRangeException>(() => new Triangle(1,2, -3));
        }

        [Test]
        public void ZeroTest()
        {
            Assert.Catch<ArgumentOutOfRangeException>(() => new Triangle(0, 1, 2));
        }

        [Test]
        public void MaxDoubleTest()
        {
            Assert.Catch<OverflowException>(() => new Triangle(1, double.MaxValue, 2).CalcArea());
        }

        [Test]
        public void IsRightTest()
        {
            bool actual = new Triangle(3,4,5).IsRightAngled();
            bool expected = true;
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
