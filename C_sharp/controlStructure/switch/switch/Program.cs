using System;

namespace SwitchExamples;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //dayNumber();
        //calculator();
    }

    static void dayNumber()
    {
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        string dayName;

        switch (dayNumber)
        {
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;
            case 6:
                dayName = "Saturday";
                break;
            case 7:
                dayName = "Sunday";
                break;
            default:
                dayName = "Invalid day";
                break;
        }

        Console.WriteLine($"Day {dayNumber} is {dayName}");
    }
    static void calculator()
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Enter operation (+, -, *, /): ");
        char operation = char.Parse(Console.ReadLine());

        double result = 0;
        bool isValid = true;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero!");
                    isValid = false;
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operation!");
                isValid = false;
                break;
        }

        if (isValid)
        {
            Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
        }
    }
}
