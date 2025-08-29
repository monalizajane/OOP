using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_MyClassAndObjects
{
    internal class Program
    {
        //Name: Monaliza Jane Sibomit
        //Section: IT306

        //Exercise: My Class and Objects
        static void Main(string[] args)
        {
            //instantiation of an object
            MyDogs myDog1 = new MyDogs();
            MyDogs myDog2 = new MyDogs();

            //initialization of fields
            myDog1.name = "Yushi";
            myDog1.age = 4;
            myDog1.breed = "Spitz";

            myDog2.name = "Ryo";
            myDog2.age = 5;
            myDog2.breed = "Shih Tzu";

            //print the title once
            Console.WriteLine("Here are the list of my dogs:\n");

            //call the method
            myDog1.DisplayInfo();
            myDog2.DisplayInfo();

            Console.ReadKey();
        }
    }
}
