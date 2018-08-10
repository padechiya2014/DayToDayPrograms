using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class RemoveDuplicateCharFromString
    {
        static void Main(string[] args)
        {
            //RemoveDuplicateCharFromString rt = new RemoveDuplicateCharFromString();
            //String str = GetStringWithoutDupliactes("mmiihirr");
            //String str = GetStringNonDuplicates("mmiihirr");
            //String str = RemoveDuplicates("mmiihirr");
            // string str = RemoveDup("mmiihirr");
            string str = RemoveDupHash("mmiihirr");
            Console.WriteLine(str);
            Console.ReadLine();
        }

        // Program 1
        public static string GetStringWithoutDupliactes(string input)
        {

            Dictionary<int, char> Dict = new Dictionary<int, char>();
            StringBuilder str = new StringBuilder();
            char[] inputArray = input.ToCharArray();
            int keyCounter = 0;

            foreach (char c in inputArray)
            {
                if (!Dict.ContainsValue(c))
                {
                    Dict.Add(keyCounter, c);
                    keyCounter++;
                }

            }

            foreach (KeyValuePair<int, char> c in Dict)
            {

                str.Append(c.Value);
            }

            return str.ToString();
        }

        // Program 2
        public static string GetStringNonDuplicates(string i)
        {

            bool[] arr = new bool[26];
            foreach (char c in i)
            {
                int value = GetCharNumber(c);

                arr[value] = true;

            }

            StringBuilder str = new StringBuilder();
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == true)
                {
                    str.Append(NumberToString(j));
                }
                
            }
            return str.ToString();

        }
        
        private static char NumberToString(int number)
        {
            Char c = (Char)((97) + number);
            return c;

        }

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

        // Program 3(LINQ)
        public static string RemoveDuplicates(string input)
        {
            return new string(input.ToCharArray().Distinct().ToArray());
        }

        // Program 4 (LIST)
        public static string RemoveDup(string input)
        {
            List<char> list = new List<char>();
            char[] cArr = input.ToCharArray();
            
            foreach(char c in cArr)
            {
                if (!list.Contains(c))
                {
                    list.Add(c);
                }
            }
            StringBuilder str = new StringBuilder();
            str.Append(list.ToArray());
            return str.ToString();
        }

        // Program 5 (HashSet)
        public static string RemoveDupHash(string input)
        {
            
            HashSet<char> set = new HashSet<char>(input);
            char[] result = new char[set.Count];
            set.CopyTo(result);
            StringBuilder sb = new StringBuilder();

            foreach (var item in result)
            {
                sb.Append(item);
            }
            return sb.ToString();
        }

        // program 6 (with sorted string, can compare current with previous)

    }
}

