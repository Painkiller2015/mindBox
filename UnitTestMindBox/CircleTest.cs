using MathFigureLib;
using MathFigureLib.Figure;
using System.Security.Principal;

namespace UnitTestMindBox
{
    [TestClass]
    public sealed class CircleTest
    {
        [TestMethod]
        public void GetArea()
        {
            double expected = 84.94866;
            
            double radius = 5.2;
            Circle circle = new(radius);

            Assert.AreEqual(expected, circle.GetArea(), 0.00001);
        }
        [TestMethod]
        public void GetArea_Overflow()
        {
            Exception expected = new ("overflow");
            double radius = double.MaxValue;

            try
            {
                Circle circle = new(radius);
                circle.GetArea();
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
            Exception expected = new ("zero");
            double radius = -100;

            try
            {
                Circle circle = new(radius);
                circle.GetArea();                
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
