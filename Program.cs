using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    // Case 1  - Reverse a string using char array
        //    String inputCase1 = "GeeksforGeeks";

        //    // getBytes() method to convert string 
        //    // into bytes[].
        //    char[] strAsCharArray = inputCase1.ToCharArray();

        //    Array.Reverse(strAsCharArray);
        //    char[] result =
        //               new char[strAsCharArray.Length];

        //    // Store result in reverse order into the
        //    // result byte[]
        //    for (int i = 0; i < strAsCharArray.Length; i++)
        //        result[i] =
        //         strAsCharArray[strAsCharArray.Length - i - 1];

        //    Console.WriteLine(new String(result));
        //    Console.ReadLine();


        //    // Case 2 - Reverse a string using Byte Array
        //    String inputCase2 = "GeeksforGeeks";

        //    byte[] strAsByteArray = Encoding.ASCII.GetBytes(inputCase2);

        //    byte[] resultCase2 =
        //              new byte[strAsByteArray.Length];
        //    // Store result in reverse order into the
        //    // result byte[]
        //    for (int i = 0; i < strAsCharArray.Length; i++)
        //    {
        //        resultCase2[i] =
        //         strAsByteArray[strAsByteArray.Length - i - 1];
        //    }


        //    Console.WriteLine(Encoding.ASCII.GetString(resultCase2));
        //    Console.ReadLine();

        //    // Case 3 - Using built in reverse() method of the StringBuilder class
        //    Console.WriteLine("Enter the string to reverse :");
        //    string name = Console.ReadLine();

        //    StringBuilder builder = new StringBuilder();
        //    for (int i = name.Length - 1; i >= 0; i--)
        //    {
        //        builder.Append(name[i]);
        //    }
        //    string newName = builder.ToString();

        //    Console.WriteLine(newName);
        //    Console.ReadLine();

        //    // Case 4 - Using inbuild collections
        //    String input = "Geeks For Geeks";
        //    char[] hello = input.ToCharArray();
        //    List<char> trial1 = new List<char>();

        //    foreach (var item in hello)
        //    {
        //        trial1.Add(item);
        //    }


        //    trial1.Reverse();

        //    foreach (var item in trial1)
        //    {
        //        Console.WriteLine(item);
        //        Console.ReadLine();

        //    }

        //    // Distinct Permutations of a string
        //    String str = "fvvfhvgv";

        //    Console.Write(DistinctPermutationOfString.countDistinctPermutations(str));

        //    // Print all possible strings of length k that can be formed from a set of n characters
        //    Console.WriteLine("First Test");
        //    char[] set1 = { 'a', 'b' };
        //    int k = 3;
        //    PossibleStringsOfLengthK.printAllKLength(set1, k);

        //    Console.WriteLine("\nSecond Test");
        //    char[] set2 = { 'a', 'b', 'c', 'd' };
        //    k = 1;
        //    PossibleStringsOfLengthK.printAllKLength(set2, k);

        //}
    }
}
