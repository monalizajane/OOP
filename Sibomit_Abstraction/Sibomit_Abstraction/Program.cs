using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of the derived class
            Backpack myBackpack = new Backpack("Nike", "Black", 150.00, 5);
            Handbag myHandbag = new Handbag("Gucci", "Red", 250.00, "Leather");

            //Call the method to display details
            myBackpack.DisplayDetails();
            myHandbag.DisplayDetails();

            Console.ReadKey();
        }
    }
}
