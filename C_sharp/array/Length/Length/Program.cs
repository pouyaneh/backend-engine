namespace Length
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            int[] scores = { 10, 12, 15, 18, 15, 20, 13 };

            for (int i = 1; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }
        }
    }
}
