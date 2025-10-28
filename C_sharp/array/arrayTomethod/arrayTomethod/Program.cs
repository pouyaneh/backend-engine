namespace arrayTomethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

                int[] scores = { 10, 13, 16, 18, 20, 19 };
                int result = Sum(scores);
                int average = result / scores.Length;
                Console.Write($"average is : {average}");
            }

            static int Sum(int[] array)
            {
                int sum = 0;
                foreach (var item in array)
                {
                    sum += item;
                }
                return sum;
            }
        }
}
