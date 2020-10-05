using System;

namespace IntergerSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine(3);
            Console.WriteLine("Halfway through......");
            int sum1 = 0, sum2 = 0;
            for (i = 1; i < 100; i++)
            {
                sum1 = sum1 + i;
            }
            Console.WriteLine(" after 100 numbers sum is {0}", sum1);
            for (j = 1; j <= 200; j++)
            {
                sum2 = sum2 + j;
            }
            Console.WriteLine("The sum of integers 1 through 200 is {0}", sum2);
        }
    }
}
