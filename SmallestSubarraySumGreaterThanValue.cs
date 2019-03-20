using System;

namespace Arrays
{
    class SmallestSubarraySumGreaterThanValue
    {

        static int SmallestSubWithSum(int[] arr,
                                  int n, int x)
        {
            int currSum = 0;
            int begin = 0;
            int end = 0;
            int minPossibleLength = n + 1;
            int target = x;

            currSum = arr[begin];

            if (currSum > target)
            {
                return 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (currSum <= target)
                {
                    end = end + 1;
                    currSum = end < n ? currSum + arr[end] : currSum;
                }
                else
                {
                    minPossibleLength = end - begin + 1;
                    currSum = currSum - arr[begin];
                    begin = begin + 1;

                }
            }
            return minPossibleLength;
        }
        // Driver Code 
        public static void Main()
        {
            int[] arr1 = { 1, 11, 100, 1, 0, 200, 3, 2, 1, 250 };
            int x = 280;
            int n1 = arr1.Length;
            int res1 = SmallestSubWithSum(arr1,
                                          n1, x);
            if (res1 == n1 + 1)
            {
                Console.WriteLine("Not Possible");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(res1);
                Console.ReadLine();
            }


            int[] arr2 = { 1, 10, 5, 2, 7 };
            int n2 = arr2.Length;
            x = 9;
            int res2 = SmallestSubWithSum(arr2,
                                          n2, x);
            if (res2 == n2 + 1)
            {
                Console.WriteLine("Not Possible");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(res2);
                Console.ReadLine();
            }


            int[] arr3 = { 1, 4, 45, 6, 0, 19 };
            int n3 = arr3.Length;
            x = 51;
            int res3 = SmallestSubWithSum(arr3,
                                          n3, x);
            if (res3 == n3 + 1)
            {
                Console.WriteLine("Not Possible");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine(res3);
                Console.ReadLine();
            }

        }
    }
}
