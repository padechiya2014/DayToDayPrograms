using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{

    // Get distinct palindromes strings
    public static class CountAllDistinctPalindromefromString
    {
        // Function to find all unique palindromic substrings of given String
        public static List<string> GetDistinctPalindromes(string source)
        {

            List<string> subsets = new List<string>();

            for (int i = 0; i < source.Length - 1; i++)
            {
                for (int j = i + 1; j <= source.Length; j++)
                {
                    if (j - i > 1 && source[j - 1] == source[i])
                    //if (source[i] == source[j])
                    {
                        string currentSubset = source.Substring(i, j - i);
                        //string currentSubset = source.Substring(i,j-i);
                        if (CheckStringPalindrome.CheckWhetherStringIsPalindrome(currentSubset, true))
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
