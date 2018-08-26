using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public static class LongestPalindrome
    {
        // Return longest string itself
        public static string GetLongestPalindrome(string s)
        {

            //if (CheckStringPalindrome.CheckWhetherStringIsPalindrome(s, true))
            //{
            //    return s;
            //}

            if (string.IsNullOrEmpty(s)) return String.Empty;
            var res = string.Empty;
            var reslen = 0;
            var dp = new bool[s.Length+1, s.Length+1];


            for (int len = 1; len <= s.Length; len++)
            {
                for (int i = 0; i + len <= s.Length; i++)
                {
                    dp[i, len] = (len - 2 <= 0 || dp[i + 1, len - 2]) && s[i] == s[i + len - 1];
                    if (dp[i, len] && len > reslen)
                    {
                        res = s.Substring(i, len);
                    }
                }
            }

            return res;
        }

        // Returns longest Palindrome string method 2
        public static string GetLongestPalindromesSubString(string source)
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

            int indexMax = !subsets.Any() ? -1 : subsets
                                                .Select((value, index) => new { Value = value, Index = index })
                                                .Aggregate((a, b) => (a.Value.Length > b.Value.Length) ? a : b)
                                                .Index;



            return subsets[indexMax];
        }



        // return longest string length
        public static int GetLongestPalindromeLength(string source)
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
            return subsets.Max(t=>t.Length);
        }
    }
}
