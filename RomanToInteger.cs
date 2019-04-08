using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class RomanToInteger
    {

        public static void Main(string[] args)
        {
            RomanToInteger x = new RomanToInteger();
            string v = "III";

            x.RomanToInt(v);

        }
        readonly Dictionary<char, int> dicRomInt = new Dictionary<char, int>();

        public int RomanToInt(string s)
        {
            dicRomInt.Add('I', 1);
            dicRomInt.Add('V', 5);
            dicRomInt.Add('X', 10);
            dicRomInt.Add('L', 50);
            dicRomInt.Add('C', 100);
            dicRomInt.Add('D', 500);
            dicRomInt.Add('M', 1000);

            char[] tempArr = s.ToCharArray();
            int result = 0;

            for (int i = 0; i < tempArr.Length; i++)
            {

                if (dicRomInt.ContainsKey(tempArr[i]))
                {
                    if((i + 1) < tempArr.Length && dicRomInt[tempArr[i]] >= dicRomInt[tempArr[i + 1]])
                    {
                        result += dicRomInt[tempArr[i]];
                    }
                    else if((i + 1) < tempArr.Length && dicRomInt[tempArr[i + 1]] > dicRomInt[tempArr[i]])
                    {
                        int temp = dicRomInt[tempArr[i + 1]] - dicRomInt[tempArr[i]];
                        result += temp;
                        i++;
                    }
                    else
                    {
                        result += dicRomInt[tempArr[i]];
                    }
                }
            }

            return result;
        }
    }
}
