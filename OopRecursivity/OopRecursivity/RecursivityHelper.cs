using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopRecursivity
{
    public static class RecursivityHelper
    {
        public static int Factorial(int n)
        {
            if (n == 1 || n == 0) return 1;

            return n * Factorial(n - 1);
        }

        public static void PrintArray(int[] array)
        {
            if (array is null || array.Length == 0)
            {
                return;
            }
            PrintArray(array, 0);
        }


        private static void PrintArray(int[] array, int i)
        {
            Console.Write(array[i]);
            if (i < array.Length-1)
            {
                Console.Write(", ");
                PrintArray(array, i + 1);
            }
        }


    }
}
