using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Given an array of n integers nums and a target, find the number of index triplets i, j, k with 0 <= i < j < k < n that satisfy the condition nums[i] + nums[j] + nums[k] < target.

// For example, given nums = [-2, 0, 1, 3], and target = 2.

// Return 2. Because there are two triplets which sums are less than 2:

// [-2, 0, 1]
// [-2, 0, 3]

// Follow up:
// Could you solve it in O(n2) runtime?

namespace Arrays
{
    public class _3Sum
    {
        public static void Main(string[] args)
        {
            _3Sum threesum = new _3Sum();
            int[] arr = { 1, 2, 3, 0, -2, 8, -3 };
            int target = 3;
            int result = threesum.ThreeSumSmaller(arr, target);
        }

        public int ThreeSumSmaller(int[] nums, int target)
        {
            //initialize total count to zero
            int count = 0;

            //sort the array
            Array.Sort(nums);

            //loop through entire array
            for (int i = 0; i < nums.Length - 2; i++)
            {
                //set left to i + 1
                int left = i + 1;
                //set right to end of array
                int right = nums.Length - 1;

                //while left index < right index
                while (left < right)
                {
                    //if the 3 indices add to less than the target increment count
                    if (nums[i] + nums[left] + nums[right] < target)
                    {
                        //increment the count by the distance between left and right because the array is sorted
                        count += right - left;

                        //increment left pointer
                        left++;
                    }
                    else
                    {
                        //if they sum to a value greater than target...
                        //decrement right pointer
                        right--;
                    }
                }
            }

            return count;
        }

    }
}
