
using System;

class Program
{
    static void Main()
    {
        bool continueCalculating = true;

        while (continueCalculating)
        {
            Console.Write("Enter first number: ");

            if (!double.TryParse(Console.ReadLine(), out double firstNumber))
            {
Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            Console.Write("Enter second number: ");

            if (!double.TryParse(Console.ReadLine(), out double secondNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            Console.Write("Enter operation (+, -, *, /): ");
            string operation = Console.ReadLine() ?? "";

            double result = 0;
            bool validOperation = true;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;

                case "-":
                    result = firstNumber - secondNumber;
                    break;

                case "*":
                    result = firstNumber * secondNumber;
                    break;

                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        validOperation = false;
                    }
                    else
                    {
                        result = firstNumber / secondNumber;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation.");
                    validOperation = false;
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine($"Result: {result}");
            }

            Console.Write("Do you want another calculation? (y/n): ");
            string answer = Console.ReadLine() ?? "";

            if (answer.ToLower() != "y")
            {
                continueCalculating = false;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Thank you for using the calculator!");
    }
}