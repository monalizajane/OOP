using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_EncapsulationUserInput
{
    internal class Program
    {
        //Name: Monaliza Jane Sibomit
        //Section: IT306
        //Exercise: Applying Encapsulation with User
        static void Main(string[] args)
        {
        Main:
            Console.Clear();

            //Ask the user to input the bag details
            Console.WriteLine("This program will let you enter your bag details:\n");

            Console.Write("Enter the brand of the bag: ");
            string aBrand = Console.ReadLine();

            Console.Write("Enter the color of the bag: ");
            string aColor = Console.ReadLine();

            //Instantiate the Bag class and initialize the properties using the user input variables
            Bag bag1 = new Bag()
            {
                Brand = aBrand,
                Color = aColor
            };

            //Display the Bag information
            bag1.DisplayBagInfo();

            //Input another bag details
            Console.Write("\nDo you want to enter the bag details again (y/n)? ");
            char answer = Convert.ToChar(Console.ReadLine());
            if (answer == 'y')
            {
                goto Main;
            }
            else if (answer == 'n')
            {
                return;
            }

            Console.ReadKey();
        }
    }
}
