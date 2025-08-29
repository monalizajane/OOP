using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_COConstructorUserInput
{
    internal class Dog
    {
        //fields or attributes
        public string name;
        public int age;
        public string breed;

        public Dog(string dName, int dAge, string dBreed) //parameterized constructor
        {
            name = dName;
            age = dAge;
            breed = dBreed;
        }

        //method to display dog details
        public void DisplayDogDetails()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("HERE ARE THE DOG DETAILS:\n");
            Console.WriteLine("Dog Name: \t" + name);
            Console.WriteLine("Age: \t\t" + age);
            Console.WriteLine("Breed: \t\t" + breed);
        }
    }
}
