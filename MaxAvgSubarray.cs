using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class MaxAvgSubarray
    {
        // Sliding Window Algorithm
        private static int GetMaxAvgSubarrayStartIndex(int[] input, int k)
        {
            int n = input.Length;
            //int start = 0;
            int end = k;
            if (end > n)
                Console.WriteLine("Please enter valid input");

            if (end == n)
            {
                return 0;
            }


            // Take first set of size k and calculate sum
            int sum = input[0];
            for (int i = 1; i < end; i++)
                sum += input[i];


            // Output variables
            int maxSum = sum;
            int maxSumIndex = 0;

            
            // Using sliding window, compare the first set with the next one to find max Avg sub Array
            for (int start = end; start < n; start++)
            {
                sum = sum - input[start - end] + input[start];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxSumIndex = start - end + 1;
                }
            }


            return maxSumIndex;
        }

        public static void PrintMaxAvgSubarray(int[] input, int k)
        {
            Console.WriteLine("Maximum average subarray of length " + k + " is:  ");
            int index = GetMaxAvgSubarrayStartIndex(input, k);
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(input[index++] + " ");
            }
        }

        public static void Main(string[] args)
        {
            int[] input = { 11, -8, 16, -7, 24, -2, 3 };
            int k = 3;
            PrintMaxAvgSubarray(input, k);
        }
    }
}
