using System;

class Calculator
{
    // Method to perform addition
    public static double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    // Method to perform subtraction
    public static double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    // Method to perform multiplication
    public static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    // Method to perform division with zero check
    public static string Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            return "Error: Division by zero is not allowed!";
        }
        else
        {
            return (num1 / num2).ToString();
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
                break;  // Exit the program
            }

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            string result = "";

            switch (choice)
            {
                case "1":
                    result = Add(num1, num2).ToString();
                    break;
                case "2":
                    result = Subtract(num1, num2).ToString();
                    break;
                case "3":
                    result = Multiply(num1, num2).ToString();
                    break;
                case "4":
                    result = Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid selection, please try again.");
                    continue;
            }

            Console.WriteLine("The result is: " + result);
            Console.WriteLine();
        }
    }
}