using System;

namespace Palindrome
{
    public static class ConvertASCIIToAlphabetInteger
    {
        /* Map each character to a number. a -> 0, b -> 1, c -> 2, etc.
      * This is case insensitive. Non-letter characters map to -1. */
        public static int GetCharNumber(char c)
        {
            int a = Convert.ToInt32('a');
            int z = Convert.ToInt32('z');
            int val = Convert.ToInt32(c);
            if (a <= val && val <= z)
            {
                return val - a;
            }
            return -1;
        }
    }
}
