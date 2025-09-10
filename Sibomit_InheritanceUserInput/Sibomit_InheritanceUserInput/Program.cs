using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_InheritanceUserInput
{
    internal class Program
    {
        //Name: Monaliza Jane Sibomit
        //Section: IT306
        //Exercise: Inheritance with User Input
        static void Main(string[] args)
        {
        Main:
            //user will select which derived class to input
            Console.WriteLine("Choose which bag would you like to provide information for (A/B): ");
            Console.WriteLine("A. Backpack\nB.Handbag");
            char answer = char.Parse(Console.ReadLine());

            if (answer == 'A')
            {
                Console.Clear();

                //user will input backpack details
                Console.WriteLine("Enter the Backpack Details:");
                Console.Write("Brand: ");
                string brand = Console.ReadLine();
                Console.Write("Price: $");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.Write("Color: ");
                string color = Console.ReadLine();
                Console.Write("Has a Laptop Compartment (Y/N): ");
                char laptopComp = char.Parse(Console.ReadLine());

                //create an instance
                Backpack myBackpack = new Backpack(brand, price, color, laptopComp);

                //call the method to display
                Console.Clear();
                Console.WriteLine("***BACKPACK DETAILS***");
                myBackpack.BagDetails();
                myBackpack.BackpackDetails();
            }

            else if (answer == 'B')
            {
                Console.Clear();

                //user will input handbag details
                Console.WriteLine("Enter the Handbag Details:");
                Console.Write("Brand: ");
                string brand = Console.ReadLine();
                Console.Write("Price: $");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.Write("Color: ");
                string material = Console.ReadLine();
                Console.Write("Has a Shoulder Strap (Y/N): ");
                char shoulderStrap = char.Parse(Console.ReadLine());

                //create an instance
                Handbag myHandbag = new Handbag(brand, price, material, shoulderStrap);

                //call the method to display
                Console.Clear();
                Console.WriteLine("***HANDBAG DETAILS***");
                myHandbag.BagDetails();
                myHandbag.HandbagDetails();
            }

            else
            {
                Console.WriteLine("Invalid choice.");
            }

            Console.ReadKey();
        }
    }
}
