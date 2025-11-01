namespace MultiDimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");


            int[,] array = {
                { 10, 11 },
                { 12, 100 },
                { 14, 15 }
            };

            //array[0, 0] = 10;
            //array[0, 1] = 11;
            //array[1, 0] = 12;
            //array[1, 1] = 13;
            //array[2, 0] = 14;
            //array[2, 1] = 15;

            Console.WriteLine(array[1, 1]);
        }
    }
}
