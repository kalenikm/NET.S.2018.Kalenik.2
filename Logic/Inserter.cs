using System;

namespace Logic
{
    public class Inserter
    {
        /// <summary>
        /// Insert bits from second number in first number in some interval.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <param name="i">Start of interval.</param>
        /// <param name="j">End of interval.</param>
        public static int InsertNumber(int a, int b, int i, int j)
        {
            if (i > j)
                throw new ArgumentException("Wrong interval.");

            int mask = (1 << (j - i + 1)) - 1;
            int interval = b & mask;
            interval = interval << i;
            a = a & ~(mask << i);

            return a | interval;
        }
    }
}