using System;
using System.Linq;

namespace ProjectEuler
{
    /*
    * Question: A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99. 
    * Find the largest palindrome made from the product of two 3-digit numbers.
    */
    public static class Problem4
    {
        public static int LargestThreeDigitPalindrome()
        {
            int largestNumber = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int number = i * j;
                    if (IsPalindromicNumber(number.ToString()) && number > largestNumber)
                    {
                        largestNumber = number;
                    }
                }
            }
            return largestNumber;
        }

        static bool IsPalindromicNumber(string number)
        {
            return string.Equals(number, new String(number.Reverse().ToArray()));
        }
    }
}