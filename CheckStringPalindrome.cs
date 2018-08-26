using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public static class CheckStringPalindrome
    {
        // Sample input
        // civic - yes
        // malayalam - yes
        // civil - no
        public static void CheckWhetherStringIsPalindrome(string input)
        {
            int left = 0;
            int right = input.Length - 1;

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
                    Console.WriteLine("Not a Palindrome");
                    Console.ReadLine();
                    return;
                }

            }

            Console.WriteLine("Given input" + "-" + input + " is a Palindrome");
            Console.ReadLine();
        }

        public static bool CheckWhetherStringIsPalindrome(string input,bool test = true)
        {
            int left = 0;
            int right = input.Length - 1;

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
