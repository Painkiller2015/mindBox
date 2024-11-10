using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFigureLib.Figure
{
    public class Circle : IFigure
    {
        public double Radius {  get; init; }
        private double Area { get; init; }
        private double Perimeter { get; init; }

        public Circle(double rad)
        {            
            Radius = ErrorHandler.CheckValue(rad);
        }
        public double GetArea()
        {
            if (Area != default)
                return Area;
            
            double area = Math.PI * Math.Pow(Radius, 2);            
            return ErrorHandler.CheckValue(area);
        }
        
        public double GetPerimeter()
        {
            if (Perimeter != default)
                return Perimeter;

            double perimeter = 2 * Math.PI * Radius;
            return ErrorHandler.CheckValue(perimeter);
        }
    }
}
