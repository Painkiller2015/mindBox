using MathFigureLib.Figure;

namespace TestMindbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Circle circle = new(double.MaxValue);

            //Console.WriteLine(MathFigureLib.MathFigure.GetArea(circle)); 


            double side1 = 1;
            double side2 = 123;
            double side3 = 99;

        
                Triangle triangle = new(side1, side2, side3);
                triangle.GetArea();
       

        }
    }
}
