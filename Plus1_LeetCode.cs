using System;
using System.Numerics;

namespace Arrays
{
    class Plus1_LeetCode
    {

        public static int[] PlusOne(int[] digits)
        {
            string temp = string.Empty;
            for (int i = 0; i < digits.Length; i++)
            {
                temp += Convert.ToString(digits[i]);
            }

           
            BigInteger resultNum = new BigInteger();
            resultNum = BigInteger.Parse(temp);
            //ulong resultNum = ulong.Parse(temp);
            resultNum = resultNum + 1;
            int numLength = resultNum.ToString().Length;


            int[] ResultArr = new int[numLength];

            for (int i = ResultArr.Length - 1; i >= 0; i--)
            {
                BigInteger current = resultNum % 10;
                ResultArr[i] = (int)current;
                resultNum = resultNum / 10;

            }

            return ResultArr;
        }

        public static int[] PlusOneSol2(int[] digits)
        {
            if (digits == null || digits.Length == 0)
                return new int[0];

            int carry = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int sum = digits[i] + carry;
                if (sum >= 10)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
                digits[i] = sum % 10;
            }

            if (carry == 1)
            {
                int[] result = new int[digits.Length + 1];
                Array.Copy(digits, 0, result, 1, digits.Length);
                result[0] = 1;
                return result;
            }
            else
            {
                //int[] result = new int[digits.length];
                return digits;
            }
        }

        public static void Main(string[] args)
        {
            int[] digits = {1,9,9};
            int[] ResultArray = PlusOneSol2(digits);
            foreach (var item in ResultArray)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}

