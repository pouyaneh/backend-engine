using Classes;
using System;

namespace Field_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Person obj1 = new Person();
            obj1.Name = "Ali";
            obj1.Family = "Daei";
            obj1.Age = -45;


            Console.WriteLine($"Family is : {obj1.Family}");
            obj1.Speak();


        }
    }
}
