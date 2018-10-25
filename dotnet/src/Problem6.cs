using System;

namespace ProjectEuler
{
    /*
    * Question: The sum of the squares of the first ten natural numbers is, 385
      The square of the sum of the first ten natural numbers is, 3025
      Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
      Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.  
    */

    public static class Problem6
    {
        public static double SumSquareDifference()
        {
            double sumOfSquare = 0;
            double squareOfSum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sumOfSquare += Math.Pow(i, 2);
                squareOfSum += i;
            }
            return (Math.Pow(squareOfSum, 2) - sumOfSquare);
        }
    }    
}