namespace NestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");


            Console.Write("Enter diamond half height: ");
            int height = int.Parse(Console.ReadLine());

            // Upper part of diamond
            for (int row = 1; row <= height; row++)
            {
                // Print leading spaces
                for (int space = 1; space <= height - row; space++)
                {
                    Console.Write("  ");
                }

                // Print increasing numbers
                for (int num = 1; num <= row; num++)
                {
                    Console.Write(num + " ");
                }

                // Print decreasing numbers
                for (int num = row - 1; num >= 1; num--)
                {
                    Console.Write(num + " ");
                }

                Console.WriteLine();
            }

            // Lower part of diamond
            for (int row = height - 1; row >= 1; row--)
            {
                // Print leading spaces
                for (int space = 1; space <= height - row; space++)
                {
                    Console.Write("  ");
                }

                // Print increasing numbers
                for (int num = 1; num <= row; num++)
                {
                    Console.Write(num + " ");
                }

                // Print decreasing numbers
                for (int num = row - 1; num >= 1; num--)
                {
                    Console.Write(num + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
