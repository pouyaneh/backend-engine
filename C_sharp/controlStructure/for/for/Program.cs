namespace _for;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //pyramid();
        //Finder();
        //Table_Generator();
        //Pattern();
    }
    static void pyramid()
    {
        Console.Write("Enter pyramid height: ");
        int height = int.Parse(Console.ReadLine());

        for (int i = 1; i <= height; i++)
        {
            // Print spaces
            for (int j = 1; j <= height - i; j++)
            {
                Console.Write("  ");
            }

            // Print increasing numbers
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }

            // Print decreasing numbers
            for (int j = i - 1; j >= 1; j--)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }
    }
    static void Finder()
    {
        Console.Write("Enter the limit: ");
        int limit = int.Parse(Console.ReadLine());

        Console.WriteLine("Prime numbers up to " + limit + ":");

        for (int number = 2; number <= limit; number++)
        {
            bool isPrime = true;

            for (int divisor = 2; divisor <= number / 2; divisor++)
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
            }
        }
        Console.WriteLine();
    }
    static void Table_Generator()
    {
        Console.Write("Enter the table size: ");
        int size = int.Parse(Console.ReadLine());

        Console.Write("   ");
        for (int i = 1; i <= size; i++)
        {
            Console.Write($"{i,4}");
        }
        Console.WriteLine();

        Console.Write("   ");
        for (int i = 1; i <= size; i++)
        {
            Console.Write("----");
        }
        Console.WriteLine();

        for (int i = 1; i <= size; i++)
        {
            Console.Write($"{i,2}|");

            for (int j = 1; j <= size; j++)
            {
                Console.Write($"{i * j,4}");
            }
            Console.WriteLine();
        }
    }
    static void Pattern()
    {
        Console.Write("Enter pattern size: ");
        int size = int.Parse(Console.ReadLine());

        for (int row = 1; row <= size; row++)
        {
            for (int col = 1; col <= size; col++)
            {
                if (row == 1 || row == size || col == 1 || col == size)
                {
                    Console.Write("* ");
                }
                else if (row == col || row + col == size + 1)
                {
                    Console.Write("# ");
                }
                else if (row > col && row + col > size + 1)
                {
                    Console.Write("1 ");
                }
                else if (row < col && row + col < size + 1)
                {
                    Console.Write("2 ");
                }
                else if (row > col && row + col < size + 1)
                {
                    Console.Write("3 ");
                }
                else
                {
                    Console.Write("4 ");
                }
            }
            Console.WriteLine();
        }
    }
}
