using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalWithMenuDriven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result = 0;
            string operation;
            string userChoice;

            do
            {
                // Display menu
                Console.Clear();
                Console.WriteLine("Basic Calculator");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an operation (1-5): ");

                userChoice = Console.ReadLine();

                if (userChoice == "5")
                {
                    break; // Exit the loop
                }

                // Get the two numbers 
                Console.Write("Enter the first number: ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                num2 = int.Parse(Console.ReadLine());

                //oprtn based on user ch
                switch (userChoice)
                {
                    case "1":
                        operation = "+";
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;

                    case "2":
                        operation = "-";
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;

                    case "3":
                        operation = "*";
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;

                    case "4":
                        if (num2 != 0)
                        {
                            operation = "/";
                            result = num1 / num2;
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }


                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
            while (userChoice != "5");
        }
    }
}
