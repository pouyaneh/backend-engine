using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        // Field (Attibute)
        // Property

        private string name;
        private string family;
        private int age;
        private int mobile;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Family
        {
            get { return family; }
            set
            {
                family = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }
            }
        }

        public int Mobile
        {
            get
            {
                return mobile;
            }
            set
            {
                mobile = value;
            }
        }



        public void Speak()
        {
            Console.WriteLine($"I am {name} {family} and i am {age} years old");
        }
    }
}
