using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public static class Problem7
    {
        public static int bulunan = 0, son = 10001;
        public static List<int> asalsayilar = new List<int>();

        public static void Problem7_Answer()
        {
            int n = 2, son_asal_sayi = 0;

            do
            {
                if (Asal_Mi(n))
                {
                    asalsayilar.Add(n);
                    son_asal_sayi = n;
                    bulunan++;
                }
                n++;

            } while (bulunan < son);

            Console.WriteLine("10001. Asal sayi: " + son_asal_sayi);
            Console.ReadKey();
        }

        public static bool Asal_Mi(int n)
        {

            //Console.WriteLine(n);

            foreach (int sayi in asalsayilar)
            {
                if (sayi * sayi > n)
                {
                    break;
                }
                else if (n % sayi == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
