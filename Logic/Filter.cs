using System;

namespace Logic
{
    public class Filter
    {
        /// <summary>
        /// Returns array with numbers from array which have same digit.
        /// </summary>
        /// <param name="num">Digit as filter.</param>
        /// <param name="array">Array to filter.</param>
        /// <returns></returns>
        public static int[] FilterDigit(int num, params int[] array)
        {
            if(num/10 > 0)
                throw new ArgumentException($"{nameof(num)} has to be digit.");
            if(array == null || array.Length == 0)
                throw new ArgumentException($"Array {nameof(array)} is empty or null.");

            int[] result = new int[0];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].ToString().Contains(num.ToString()))
                {
                    var buff = result;
                    result = new int[++count];
                    buff.CopyTo(result, 0);
                    result[count - 1] = array[i];
                }
            }
            return result;
        }
    }
}