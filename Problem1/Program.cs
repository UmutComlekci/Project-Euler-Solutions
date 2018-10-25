using System;

/*
 * Question: If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 * Find the sum of all the multiples of 3 or 5 below 1000.
 */

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(SumOfDivision());
        }

        static int SumOfDivision()
        {
            int result = 0;
            for (int i = 0; i < 1000; i++)
            {
                if ((i % 3) == 0 || (i % 5) == 0)
                {
                    result += i;
                }
            }
            return result;
        } 
    }
}
