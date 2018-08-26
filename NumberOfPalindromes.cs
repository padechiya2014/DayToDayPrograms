using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public static class NumberOfPalindromes
    {
        public static void GetNoOfPalindromesInAWord(string input)
        {
            // Sample input
            // "This is civic honda takeb by malayalam beeeb"
            String[] arr = input.Split();
            int finalCount = 0;
            foreach (var item in arr)
            {
                if (CheckWhetherStringIsPalindrome(item))
                {
                    finalCount++;
                }
            }

            Console.WriteLine("No of Palindromes in a Phrase is " + finalCount);
            Console.ReadLine();

        }

        private static bool CheckWhetherStringIsPalindrome(string input)
        {
            int left = 0;
            int right = input.Length - 1;
            input = input.Replace("[^a-zA-Z]", "").ToLower();
            while (left < right)
            {
                if (input[left] == input[right])
                {
                    left++;
                    right--;
                    continue;
                }
                else
                {
                    return false;
                }

            }

            return true;
        }
    }
}
