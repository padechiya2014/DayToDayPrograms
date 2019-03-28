using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class CountFreqOfANumber
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 2, 3, 3, 4, 5, 8, 9, 9, 9, 9, 10 };

            Dictionary<int, int> FreqDict = new Dictionary<int, int>();

            for(int i = 0; i < arr.Length; i++)
            {
                int counter = 0;
                if (FreqDict.ContainsKey(arr[i]))
                {
                    FreqDict[arr[i]] = ++FreqDict[arr[i]];
                }
                else
                {
                    FreqDict.Add(arr[i], ++counter);
                }
               
            }

            foreach (KeyValuePair<int,int> item in FreqDict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
