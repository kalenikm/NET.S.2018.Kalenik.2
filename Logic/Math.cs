using System;
using System.Globalization;

namespace Logic
{
    public class Math
    {
        /// <summary>
        /// Returns root of the input number. 
        /// </summary>
        /// <param name="number">Input number.</param>
        /// <param name="pow">Power of root.</param>
        /// <param name="accuracy">Accuracy.</param>
        /// <returns></returns>
        public static double FindNthRoot(double number, int pow, double accuracy)
        {
            if(pow <= 0)
                throw new ArgumentException("Power is less than 1.");

            var x0 = number / pow;
            var x1 = (1 / (double)pow) * ((pow - 1) * x0 + number / System.Math.Pow(x0, pow - 1));

            while (System.Math.Abs(x1 - x0) > accuracy || System.Math.Abs(x1 - x0) != 0)
            {
                x0 = x1;
                x1 = (1 / (double)pow) * ((pow - 1) * x0 + number / System.Math.Pow(x0, pow - 1));
            }
            return System.Math.Round(x1, accuracy.ToString().Length - 2);
        }
    }
}