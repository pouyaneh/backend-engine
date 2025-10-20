namespace breakContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Console.Write("Enter the upper limit to find prime numbers: ");
            int limit = int.Parse(Console.ReadLine());

            Console.WriteLine($"Prime numbers up to {limit}:");
            int primeCount = 0;

            for (int number = 2; number <= limit; number++)
            {
                if (number > 2 && number % 2 == 0)
                {
                    continue;
                }

                if (number > 3 && number % 3 == 0)
                {
                    continue;
                }

                bool isPrime = true;
                int divisorLimit = (int)Math.Sqrt(number);

                for (int divisor = 2; divisor <= divisorLimit; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(number + " ");
                    primeCount++;

                    if (primeCount % 10 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine($"\n\nTotal prime numbers found: {primeCount}");

            if (primeCount == 0)
            {
                Console.WriteLine("No prime numbers found in the given range.");
            }
        }
    }
}
