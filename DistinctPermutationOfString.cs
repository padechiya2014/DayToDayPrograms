using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public static class DistinctPermutationOfString
    {
        static int MAX_CHAR = 26;

        // Utility function to find factorial of n.
        static int factorial(int n)
        {
            int fact = 1;
            for (int i = 2; i <= n; i++)
                fact = fact * i;

            return fact;
        }

        // Returns count of distinct permutations
        // of str.
        public static int countDistinctPermutations(String str)
        {
            int length = str.Length;

            int[] freq = new int[MAX_CHAR];

            // finding frequency of all the lower case
            // alphabet and storing them in array of
            // integer
            for (int i = 0; i < length; i++)
                if (str[i] >= 'a')
                    freq[str[i] - 'a']++;

            // finding factorial of number of appearances
            // and multiplying them since they are
            // repeating alphabets
            int fact = 1;
            for (int i = 0; i < MAX_CHAR; i++)
                fact = fact * factorial(freq[i]);

            // finding factorial of size of string and
            // dividing it by factorial found after
            // multiplying
            return factorial(length) / fact;
        }
    }
}
