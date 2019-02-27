using System;

namespace Arrays
{
    class Program
    {
        static void minimumBribes(int[] q)
        {
            // Loop to check whether chaotic, if yes, than print and break out
            for (int i = 0; i < q.Length; i++)
            {
                if ((q[i] - (i + 1)) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
            }

            int result = 0;
            int[] initialArray = new int[q.Length];
            for (int x = 0; x < initialArray.Length; x++)
            {
                initialArray[x] = x + 1;
            }
            // If not chaotic, than check the number of bribes(swaps) by bringing the position of the queue to its original position
            // for eg: 1 2 3 4 5 6 7 8....etc
            for (int i = 0; i < q.Length; i++)
            {
                if (q[i] == initialArray[i])
                {
                    continue;
                }
                for (int j = i + 1; j < q.Length; j++)
                {

                    if (q[i] > q[j])
                    {
                        int tmp = q[j];
                        q[j] = q[i];
                        q[i] = tmp;
                        result++;
                    }
                }
            }
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
                ;
                minimumBribes(q);
            }
        }
    }
}
