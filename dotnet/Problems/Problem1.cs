using System;

namespace ProjectEuler
{
    public static class Problem1
    {
        public static int SumOfDivision()
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