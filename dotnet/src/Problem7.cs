using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public static class Problem7
    {
        public static int CatchPrimeNumber = 0, LastPrimeNumber = 10001;
        public static List<int> PrimeNumbers = new List<int>();

        public static void Problem7Answer()
        {
            int n = 2, CaptureLastPrimeNumber = 0;

            do
            {
                if (IsItPrime(n))
                {
                    PrimeNumbers.Add(n);
                    CaptureLastPrimeNumber = n;
                    CatchPrimeNumber++;
                }
                n++;

            } while (CatchPrimeNumber < LastPrimeNumber);

            Console.WriteLine("10001. Prime Number: " + CaptureLastPrimeNumber);
            Console.ReadKey();
        }

        public static bool IsItPrime(int n)
        {
            for(int i=2;i<=n;i++)
            {
                if(i==n)
                {
                    break;
                }

                if(n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
