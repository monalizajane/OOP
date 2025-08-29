using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_MyClassAndObjects
{
    internal class MyDogs
    {
        //fields or attributes
        public string name, breed;
        public int age;

        //method to display
        public void DisplayInfo()
        {
            Console.WriteLine("-" + name + ", " + age + " months old, " + breed);
        }
    }
}
