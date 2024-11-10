using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFigureLib
{
    internal static class ErrorHandler
    {
        internal static double CheckValue(double value)
        {
            CheckDoubleOverflow(value);
            CheckDoubleBelowZero(value);
            return value;
        }
        private static void CheckDoubleOverflow(double value)
        {
            if (double.IsInfinity(value))
            {
                throw new OverflowException("double overflow exception");
            }            
        }
        private static void CheckDoubleBelowZero(double value)
        {
            if (value < 0)
            {
                throw new OverflowException("below zero value");
            }
        }
    }
}
