using System;

namespace MathOperationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the PerformOperation method with regular parameters
            mathOps.PerformOperation(5, 10);

            // Call the PerformOperation method with named parameters
            mathOps.PerformOperation(number1: 7, number2: 14);

            // Prevent the console from closing immediately
            Console.ReadLine();
        }
    }
}
