using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_PropertiesAndEncapsulation
{
    internal class Program
    {
        //Name: Monaliza Jane Sibomit
        //Section: IT306
        //Exercise: Basics on Encapsulation

        static void Main(string[] args)
        {
            //Instantiate the Bag class
            Bag bag1 = new Bag();

            //Set the properties for the Bag class fields
            bag1.Brand = "Prada";
            bag1.Color = "Black";

            //Display the Bag information
            bag1.DisplayBagInfo();

            Console.ReadKey();
        }
    }
}
