using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object Initializer Syntax

            Person obj1 = new Person() { Name = "Karim", Age = 50, Family = "Bagheri" };

            Console.WriteLine($"Family is : {obj1.Family}");

            obj1.Speak();

        }
    }
}
