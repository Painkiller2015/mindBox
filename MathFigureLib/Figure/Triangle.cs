using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFigureLib.Figure
{
    public class Triangle : IFigure
    {
        public double Leg1 { get; init; }
        public double Leg2 { get; init; }
        public double Leg3 { get; init; }
        private double Area { get; set; }
        private double Perimeter { get; set; }


        public Triangle(double side1, double side2, double side3)
        {
            Leg1 = ErrorHandler.CheckValue(side1);
            Leg2 = ErrorHandler.CheckValue(side2);
            Leg3 = ErrorHandler.CheckValue(side3);
        }
        public double GetArea()
        {
            if (Area != default)
                return Area;
            
            double area;
            if (IsRight())
            {
                area = 0.5 * Leg1 * Leg2;
            }
            else
            {
                double p = GetPerimeter();
                area = Math.Sqrt(p * (p - Leg1) * (p - Leg2) * (p - Leg3));                 //Heron formula
            }
            Area = ErrorHandler.CheckValue(area);
            return Area;
        }
        public double GetPerimeter()
        {
            if (Perimeter != default)
                return Perimeter;

            return ErrorHandler.CheckValue(Leg1 + Leg2 + Leg3);
        }
        private bool IsRight()
        {
            double[] sideArr = { Leg1, Leg2, Leg3 };
            Array.Sort(sideArr);

            double a = sideArr[0];                  //leg
            double b = sideArr[1];                  //leg
            double c = sideArr[2];                  //Hypotenuse

            return Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2);                       //Pythagorean theorem
        }
    }
}
