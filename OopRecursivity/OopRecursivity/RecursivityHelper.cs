using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopRecursivity
{
    public class RecursivityHelper
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

        internal static int FibocallCount = 0;
        private static long[] FiboCache = new long[1000];

        public static long Fibonacci(int n)
        {

            if (n == 0 || n==1) return n;

            if (FiboCache[n] > 0)
            {
                return FiboCache[n];
            }

            FibocallCount++;

            long rezult = Fibonacci(n - 1) + Fibonacci(n - 2);
            FiboCache[n] = rezult;
            return rezult;
        }


        public static int IndexOfElement(int element, int[] array)
        {
            return IndexOfElement(element, array, 0, array.Length - 1);
        }

        private static int IndexOfElement(int element, int[] array, int indexStart, int indexEnd)
        {

            if (indexStart>= array.Length || indexEnd <0)
            {
                return -1;
            }


            int middleIndex = (indexStart + indexEnd ) / 2;

            if (element== array[middleIndex])
            {
                return middleIndex;
            }
            if(element< array[middleIndex])
            {
                //search left
                return IndexOfElement(element, array, indexStart, middleIndex-1);
            }
            else
            {
                //search right
                return IndexOfElement(element, array, middleIndex+1, indexEnd);
            }
        }
    }
}
