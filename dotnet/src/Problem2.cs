using System;

namespace ProjectEuler
{
    //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
    public static class Problem2
    {
        public static int GetFibonacciEvenNumbersSum()
        {
            int first=1;
            int second =2;
            int sumOfEvenNumbs=0;

            do{
                if(second %2 == 0)
                {
                sumOfEvenNumbs+=second;
                }
                GetNextFibonacciNumbers(ref first,ref second);
            }while(second<4000000);
            return sumOfEvenNumbs;
        }
       private static void GetNextFibonacciNumbers(ref int first,ref int second)
        {
            int temp = first;
            first=second;
            second=temp+second;
        }
    }    
}