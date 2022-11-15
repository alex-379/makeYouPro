using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNumbers
{
    public static class OperationsWithNumbers
    {

        public static double ValueOfLinearEqution(double a, double b, double c)
        {
            double x = (c - b) / a;
            return (x);
        }

        public static double SumIfAMoreMultiplyIfEqualDifferenceIfBMore(double a, double b)
        {
            double result = 0;
            if (a > b) result = a + b;
            if (a == b) result = a * b;
            if (a < b) result = a - b;
            return (result);
        }
       /* public static int NumberToString(int a)
        {

            return ();
        }*/
    }
}
