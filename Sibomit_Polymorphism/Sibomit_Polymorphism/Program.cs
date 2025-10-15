using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating instances of derived classes
            Bag myBackpack = new Backpack
            {
                Brand = "Nike",
                Price = 2500,
                Color = "Black"
            };
            Bag myHandbag = new Handbag
            {
                Brand = "Gucci",
                Price = 15000,
                Material = "Leather"
            };

            //Calling the overridden methods
            myBackpack.DisplayInfo();
            myHandbag.DisplayInfo();

            Console.ReadKey();
        }
    }
}
