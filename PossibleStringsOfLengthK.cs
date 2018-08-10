using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public static class PossibleStringsOfLengthK
    {
        // The method that prints all 
        // possible strings of length k.
        // It is mainly a wrapper over 
        // recursive function printAllKLengthRec()
         internal static void printAllKLength(char[] set, int k)
        {
            int n = set.Length;
            printAllKLengthRec(set, "", n, k);
        }

        // The main recursive method
        // to print all possible 
        // strings of length k
        static void printAllKLengthRec(char[] set,
                                       String prefix,
                                       int n, int k)
        {

            // Base case: k is 0,
            // print prefix
            if (k == 0)
            {
                Console.WriteLine(prefix);
                return;
            }

            // One by one add all characters 
            // from set and recursively 
            // call for k equals to k-1
            for (int i = 0; i < n; ++i)
            {

                // Next character of input added
                String newPrefix = prefix + set[i];

                // k is decreased, because 
                // we have added a new character
                printAllKLengthRec(set, newPrefix,
                                        n, k - 1);
            }
        }

    }
}
