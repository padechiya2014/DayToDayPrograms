using System;

namespace Arrays
{
    class MaxSumForNonAdjacentElements
    {
        static int MaxSum(int[] arr)
        {
            int excl = 0;
            int incl = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = incl;
                incl = Math.Max(excl + arr[i], incl);
                excl = temp;
            }
            return incl;
        }

        public static void Main(string[] args)
        {
            int[] arr = { 2, 10, 13, 4, 2, 15, 10 };
            Console.WriteLine(MaxSum(arr));
            Console.ReadLine();
        }
    }
}
