namespace _foreach;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        // var
        int a = 10;
        var b = "ali";
        var c = 12.5f;

        // const
        const float p = 3.14f;

        //foreach
        int[] numbers = { 10, 13, 17, 19, 20, 40 };
        int sum = 0;
        foreach (var item in numbers)
        {
            sum += item;
        }
        Console.WriteLine($"sum is : {sum}");

    }
}
