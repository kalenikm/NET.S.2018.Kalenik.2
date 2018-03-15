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
        public static double FindNthRoot(int number, int pow, double accuracy)
        {
            double t;
            double root = (double)number / pow;
            do
            {
                t = root;
                root = (t + (number / t)) / pow;
            } while (System.Math.Abs(t - root) < accuracy);
            return root;
        }
    }
}