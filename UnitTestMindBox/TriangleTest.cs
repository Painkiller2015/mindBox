using MathFigureLib.Figure;

namespace UnitTestMindBox
{
    [TestClass]
    public sealed class TriangleTest
    {
        [TestMethod]
        public void GetArea()
        {
            double expected = 6;

            double side1 = 3;
            double side2 = 4;
            double side3 = 5;

            Triangle triangle = new(side1, side2, side3);

            Assert.AreEqual(expected, triangle.GetArea(), 0.00001);
        }
        [TestMethod]
        public void GetArea_Overflow()
        {
            Exception expected = new("overflow");
             
            double side1 = double.MaxValue;
            double side2 = double.MaxValue;
            double side3 = double.MaxValue;

            try
            {
                Triangle triangle = new(side1, side2, side3);
                triangle.GetArea();
            }
            catch (OverflowException e)
            {
                StringAssert.Contains(e.Message, expected.Message);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }
        [TestMethod]
        public void GetArea_BelowZero()
        {
            Exception expected = new("zero");
            double side1 = -123;
            double side2 = 0;
            double side3 = 123;

            try
            {
                Triangle triangle = new(side1, side2, side3);
                triangle.GetArea();
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, expected.Message);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }
    }
}
