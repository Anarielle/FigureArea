using FigureArea;

namespace FigureAreaTests
{
    public class CircleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAreaTest()
        {
            Circle circle = new Circle(3);
            double expected = Math.Pow(circle.Radius, 2) * Math.PI;
            double actual = circle.CalcArea();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void NegativeNumberTest()
        {
            Assert.Catch<ArgumentOutOfRangeException>(() => new Circle(-4));
        }

        [Test]
        public void ZeroTest()
        {
            Assert.Catch<ArgumentOutOfRangeException>(() => new Circle(0));
        }

        [Test]
        public void MaxDoubleTest()
        {
            Assert.Catch<OverflowException>(() => new Circle(double.MaxValue).CalcArea());
        }
    }
}