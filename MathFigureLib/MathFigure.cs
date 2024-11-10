using MathFigureLib.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFigureLib
{
    public static class MathFigure
    {
        public static double GetArea(IFigure figure)
        {
            return figure.GetArea();
        }
        public static double GetPerimeter(IFigure figure)
        {
            return figure.GetPerimeter();
        }
    }
}
