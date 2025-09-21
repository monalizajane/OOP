using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_InheritanceComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instance of the backpack class
            Backpack myBackpack = new Backpack
            {
                Brand = "Adidas",
                Color = "Black",
                Price = 599,
                Discount = 0.10
            };

            //call the method to display bag details and discounted price
            Console.WriteLine("*****BACKPACK*****\n");
            Console.WriteLine(myBackpack.BagDetails());
            Console.WriteLine($"Original Price: P{myBackpack.Price}\nDiscounted Price: P{myBackpack.DiscountedPrice}");

            //instance of the handbag class
            Handbag myHandbag = new Handbag
            {
                Brand = "Gucci",
                Material = "Leather",
                Price = 1299,
                Discount = 0.20
            };

            //call the method to display bag details and discounted price
            Console.WriteLine("\n*****HANDBAG*****\n");
            Console.WriteLine(myHandbag.BagDetails());
            Console.Write($"Original Price: P{myHandbag.Price}\nDiscounted Price: P{myHandbag.DiscountedPrice}");

            Console.ReadKey();
        }
    }
}
