namespace Define_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Person obj1 = new Person();
            obj1.name = "Ali";
            obj1.family = "Daei";
            obj1.age = 45;

            obj1.Speak();
        }
    }
}
