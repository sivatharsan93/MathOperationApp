using System;

namespace MathOperationApp
{
    // This class contains methods for performing various math operations
    public class MathOperations
    {
        // This method performs a multiplication operation on the first integer
        // and displays the result along with the second integer to the screen
        public void PerformOperation(int number1, int number2)
        {
            int result = number1 * 2; // Multiplying the first number by 2
            Console.WriteLine($"Result of operation: {result}");
            Console.WriteLine($"Second number: {number2}");
        }
    }
}
