using System;

namespace OopRecursivity
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 1, 2, 3, 4, 5, 6 };
            int element = 3;
            int index = RecursivityHelper.IndexOfElement(element, array);

            Console.WriteLine($"{element} is at index {index}");
        }

        private static void Example_facorial_recursive()
        {
            int n = 7;
            long rezult = RecursivityHelper.Fibonacci(n);
            Console.WriteLine($"Fib of {n} is {rezult}");
            Console.WriteLine($"Fib of {n} was calculated in {RecursivityHelper.FibocallCount} steps");
            RecursivityHelper.PrintArray(new[] { 1, 2, 3, 4, 5, 6 });


            //int n = 5;
            //int rezult = RecursivityHelper.Factorial(n);

            Console.WriteLine($"Fact de {n} is {rezult}");
        }
    }
}
