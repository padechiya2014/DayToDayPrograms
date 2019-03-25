using System;

namespace Arrays
{
    class MedianOfSortedArraySameSize
    {
        public static int getMedian(int[] arr1, int[] arr2, int length)
        {
            int size = length;
            int median1 = -1;
            int median2 = -1;
            int i = 0;
            int j = 0;


            for (int count = 0; count <= size; count++)
            {
                // Edge case 1
                if (i == size)
                {
                    median1 = median2;
                    median2 = arr2[0];
                    break;
                }

                // Edge case 2
                else if (j == size)
                {
                    median1 = median2;
                    median2 = arr1[0];
                    break;
                }

                if (arr1[i] < arr2[j])
                {
                    median1 = median2;
                    median2 = arr1[i];
                    i++;
                }
                else
                {
                    median1 = median2;
                    median2 = arr2[j];
                    j++;
                }

            }

            return (median1 + median2) / 2;

        }

        public static void Main()
        {
            int[] ar1 = { 1, 12, 15, 26, 38 };
            int[] ar2 = { 2, 13, 17, 30, 45 };

            int n1 = ar1.Length;
            int n2 = ar2.Length;
            if (n1 == n2)
            {
                Console.WriteLine("Median is " + getMedian(ar1, ar2, n1));
            }

            else
            {
                Console.WriteLine("arrays are of unequal size");
            }

        }
    }
}
