using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class LargestSumContigousArray
    {

        static int MaxSubArraySum(int[] a)
        {
            int size = a.Length;
            int max_so_far = int.MinValue;
            int max_current = 0;
            
            for(int i = 0; i < size; i++)
            {
                max_current = max_current + a[i];

                if(max_current > max_so_far)
                {
                    max_so_far = max_current;
                }

                if(max_current < 0)
                {
                    max_current = 0;
                }
            }

            return max_so_far;
        }

        static int[] MaxSubArraySumRange(int[] a)
        {
            int size = a.Length;
            int max_so_far = int.MinValue;
            int max_current = 0;
            int startIndex = 0;
            int currentIndex = 0;
            int endIndex = 0;
            int[] resultOfIndexes = new int[2];

            for (int i = 0; i < size; i++)
            {
                max_current = max_current + a[i];

                if (max_current < 0)
                {
                    max_current = 0;
                    startIndex = i + 1;
                }

                if (max_current > max_so_far)
                {
                    max_so_far = max_current;
                    endIndex = i;
                    currentIndex = startIndex;
                }

                
            }
            resultOfIndexes[0] = currentIndex;
            resultOfIndexes[1] = endIndex;
            return resultOfIndexes;
        }
        static void Main(string[] args)
        {
            int[] a = { -2, -3, 4, -1, -2, 1, 5, -3 };
            Console.WriteLine("Maximum contiguous sum is " +
                                    MaxSubArraySum(a));
            Console.ReadLine();

            int[] tempArr = MaxSubArraySumRange(a);
            Console.WriteLine("Start and endindex of max contigous array is" + " " + "{0} and {1}", tempArr[0] , tempArr[1]);
            Console.ReadLine();

        }
    }
}
