using System;

namespace Logic
{
    public class Finder
    {
        /// <summary>
        /// Returns next bigger number consisting of digits from input number.
        /// </summary>
        /// <param name="number">Input number.</param>
        /// <param name="time">Returns time of finding number.</param>
        /// <returns></returns>
        public static int FindNextBiggerNumber(int number, out TimeSpan time)
        {
            if (number / 10 < 1)
                throw new ArgumentException($"Number {number} is too small.");

            time = new TimeSpan();
            var stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            var arrOfDigits = ToArray(number);
            for (int i = 0; i < arrOfDigits.Length - 1; i++)
            {
                if (arrOfDigits[i] > arrOfDigits[i + 1])
                {
                    int firstLower = arrOfDigits[i + 1];
                    int minInd = 0;
                    int maxInInterval = Int32.MaxValue;
                    for (int j = 0; j <= i; j++)
                    {
                        if (arrOfDigits[j] > firstLower && maxInInterval > arrOfDigits[j])
                        {
                            minInd = j;
                            maxInInterval = arrOfDigits[j];
                        }
                    }
                    Swap(ref arrOfDigits[minInd], ref arrOfDigits[i + 1]);
                    QuickSort(arrOfDigits, 0, i, false);

                    stopwatch.Stop();
                    time = stopwatch.Elapsed;
                    return ToInt(arrOfDigits);
                }
            }
            return -1;
        }


        private static int ToInt(int[] arr)
        {
            int res = arr[arr.Length - 1];
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                res *= 10;
                res += arr[i];
            }
            return res;
        }

        private static int[] ToArray(int num)
        {
            int[] arr = new int[num.ToString().Length];
            int index = 0;
            while (num / 10 != 0)
            {
                arr[index] = num % 10;
                num /= 10;
                index++;
            }
            arr[index] = num;
            return arr;
        }

        private static void QuickSort(int[] array, int left, int right, bool ascending = true)
        {
            int pivot = right;
            int wall = left;

            for (int i = left; i < pivot; i++)
            {
                if (array[pivot] < array[i] && ascending) // Descending.
                {
                    Swap(ref array[i], ref array[wall]);
                    wall++;
                }
            }
            Swap(ref array[pivot], ref array[wall]);

            if (wall + 1 < right)
                QuickSort(array, wall + 1, right);
            if (wall - 1 > left)
                QuickSort(array, left, wall - 1);
        }

        private static void Swap(ref int a, ref int b)
        {
            int buff = a;
            a = b;
            b = buff;
        }
    }
}