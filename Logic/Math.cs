using System;

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
                throw new ArgumentException();

            if (number == 1)
                return 1;

            double t;
            double root = number / pow;
            do
            {
                t = root;
                root = (t + (number / t)) / pow;
            } while (System.Math.Abs(t - root) > accuracy || t - root != 0);
            return root;
        }
    }
}