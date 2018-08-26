using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public static class CountAllPalindromeSubString
    {
        private static bool IsPalindrome(string input)
        {
            return !input.Where((t, i) => t != input[input.Length - 1 - i]).Any();
        }


        public static List<string> GetPossiblePalindromes(string source)
        {
            List<string> subsets = new List<string>();
            for (int i = 0; i < source.Length - 1; i++)
            {
                for (int j = i + 1; j <= source.Length; j++)
                {
                    if (j - i > 1 && source[j - 1] == source[i])
                    {
                        string currentSubset = source.Substring(i, j - i);
                        if (IsPalindrome(currentSubset))
                        {
                            subsets.Add(currentSubset);
                        }
                    }
                }
            }
            return subsets;
        }
    }
}
