using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegralCalculator;


namespace IntegralCalculator
{
    internal class Calculator
    {
        public double CalculateIntegral(double xMin, double xMax, accuracy, Func<double, double> func)

        {

            
            var intervals = 2;
            var square = 0d;
            var intervalSquare = 0d;
            xMax = 10;
            xMin = -10;
            var range = xMax - xMin;

            do
            {
                square = intervalSquare;
                intervalSquare = 0d;


                for (int i = 1; i <= intervals; i++)
                {
                    var width = range / intervals;
                    var x = xMin + width * i;
                    var y = func(x);

                    intervalSquare += Math.Abs(width*y);
                }

                intervals *= 2;




            } while ((square==0)|| (intervalSquare-square)/square>accuracy);

            
            return square;

        }


    }
}
