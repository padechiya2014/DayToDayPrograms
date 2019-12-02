using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class TwoStringsArePermutationsOfEachOther
    {
        static bool arePermutation(String str1, String str2)
        {
            // Get lenghts of both strings  
            int n1 = str1.Length;
            int n2 = str2.Length;

            // If length of both strings is not same,  
            // then they cannot be Permutation  
            if (n1 != n2)
                return false;
            int str1TotalValue = 0;
            int str2TotalValue = 0;

            foreach (var item in str1.ToCharArray())
            {
                str1TotalValue += (int)item;
            }

            foreach (var item in str2.ToCharArray())
            {
                str2TotalValue += (int)item;
            }

            if (str1TotalValue == str2TotalValue)
            {
                return true;
            }
                
            else return false;
        }

        public static void Main(String[] args)
        {
            String str1 = "test";
            String str2 = "test";
            if (arePermutation(str1, str2))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
