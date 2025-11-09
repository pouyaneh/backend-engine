using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Define_Class
{
    internal class Person
    {
        public string name;
        public string family;
        public int age;
        public int mobile;

        public void Speak()
        {
            Console.WriteLine($"I am {name} {family} and i am {age} years old");
        }
    }
}
