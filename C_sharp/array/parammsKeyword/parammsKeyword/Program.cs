namespace parammsKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");




            int[] numbers = { 1, 2, 3, 5 };
            int result1 = Sum(10, numbers);
            int result2 = Sum(20, 13, 15, 17, 19);
            Console.WriteLine($"result1 is : {result1}");
            Console.WriteLine($"result2 is : {result2}");
        }

        static int Sum(int num1, params int[] array)
        {
            int total = 0;
            foreach (var item in array)
            {
                total += item;
            }
            return total;
        }
    }
}
