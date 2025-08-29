using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_CaO
{
    internal class Person
    {
        //class members
        public string name;
        public int age;
        public string gender;

        //method to display
        public void Greet()
        {
            Console.WriteLine("Hello everyone, my name is " + name + ", I'm " + age + " and I'm a " + gender + ".");
        }
    }
}
