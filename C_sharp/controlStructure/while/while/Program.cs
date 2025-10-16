namespace _while;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        double result = 0;
        bool firstOperation = true;
        bool continueCalculating = true;

        Console.WriteLine("Advanced Calculator");
        Console.WriteLine("Available operations: +, -, *, /, %, clear, exit");

        while (continueCalculating)
        {
            try
            {
                if (firstOperation)
                {
                    Console.Write("Enter first number: ");
                    result = double.Parse(Console.ReadLine());
                    firstOperation = false;
                }

                Console.Write("Enter operation: ");
                string operation = Console.ReadLine().ToLower();

                if (operation == "exit")
                {
                    continueCalculating = false;
                    Console.WriteLine($"Final result: {result}");
                    break;
                }
                else if (operation == "clear")
                {
                    result = 0;
                    firstOperation = true;
                    Console.WriteLine("Calculator cleared. Starting fresh...");
                    continue;
                }

                Console.Write("Enter next number: ");
                double number = double.Parse(Console.ReadLine());
                double previousResult = result;

                switch (operation)
                {
                    case "+":
                        result += number;
                        break;
                    case "-":
                        result -= number;
                        break;
                    case "*":
                        result *= number;
                        break;
                    case "/":
                        if (number == 0)
                        {
                            Console.WriteLine("Error: Cannot divide by zero!");
                            continue;
                        }
                        result /= number;
                        break;
                    case "%":
                        if (number == 0)
                        {
                            Console.WriteLine("Error: Cannot calculate modulus by zero!");
                            continue;
                        }
                        result %= number;
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Please try again.");
                        continue;
                }

                Console.WriteLine($"{previousResult} {operation} {number} = {result}");
                Console.WriteLine($"Current result: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numbers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        Console.WriteLine("Thank you for using the calculator!");
    }
}
