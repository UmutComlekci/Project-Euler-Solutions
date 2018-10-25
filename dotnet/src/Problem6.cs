using System;

namespace ProjectEuler
{
    /*
     Question: The sum of the squares of the first ten natural numbers is, 385
      The square of the sum of the first ten natural numbers is, 3025
      Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
      Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.  
    */

    public static class Problem6
    {
        public static double SunSquareDifference()
        {
            double sum = 0;
            double sum2 = 0;
            for (int i = 0; i <= 100; i++)
            {
                sum += Math.Pow(i, 2);
                sum2 += i;
            }
            return (Math.Pow(sum2, 2) - sum);
        }
    }    
}