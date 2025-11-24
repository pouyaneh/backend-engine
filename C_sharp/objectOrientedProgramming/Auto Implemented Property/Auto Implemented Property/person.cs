using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Implemented_Property
{
    public class Person
    {
        // Auto Implemented Property

        private int age;
        public string Name { get; set; }
        public string Family { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                age = value > 0 ? value : 0;
            }
        }

        public int Mobile { get; set; }

        public void Speak()
        {
            Console.WriteLine($"I am {Name} {Family} and i am {Age} years old");
        }
    }
}
