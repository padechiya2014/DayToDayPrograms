using System;
using System.Collections.Generic;
using System.Linq;

namespace StringManipulation
{
    class LongestStringinDictionary
    {
        // Returns true if str1[] is a  
        // subsequence of str2[]. m is  
        // length of str1 and n is length of str2  
        static bool IsSubSequence(string str1, string str2)
        {
            int m = str1.Length, n = str2.Length;

            int j = 0; // For index of str1 (or subsequence)  

            // Traverse str2 and str1, and compare current  
            // character of str2 with first unmatched char  
            // of str1, if matched then move ahead in str1  
            for (int i = 0; i < n && j < m; i++)
            {
                if (str1.ElementAt(j) == str2.ElementAt(i))
                {
                    j++;
                }
            }

            // If all characters of str1  
            // were found in str2  
            return (j == m);
        }

        // Returns the longest String  
        // in dictionary which is a  
        // subsequence of str.  
        static string findLongestString(List<string> dict,
                                                string str)
        {
            string result = "";
            int length = 0;

            // Traverse through all words of dictionary  
            foreach (var word in dict)
            {
                // If current word is subsequence of str  
                // and is largest such word so far.  
                if (length <= word.Length &&
                    IsSubSequence(word, str))
                {
                    result = word;
                    length = word.Length;
                }
            }


            // Return longest String  
            return result;
        }

        // Driver code 
        public static void Main(string[] args)
        {
            string[] arr = { "ale", "apple", "monkey", "plea" };
            List<string> dict = arr.ToList();
            string str = "abpcplea";
            Console.WriteLine(findLongestString(dict, str));
            Console.ReadLine();
        }
    }

}
