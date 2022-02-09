using System;

namespace OopRecursivity
{
    class Program
    {
        static void Main(string[] args)
        {
            RecursivityHelper.PrintArray(new[] {1,2,3,4,5,6});

            /*
            int n = 5;
            int rezult = RecursivityHelper.Factorial(n);

            Console.WriteLine($"Fact de {n} is {rezult}");
            */
        }
    }
}
