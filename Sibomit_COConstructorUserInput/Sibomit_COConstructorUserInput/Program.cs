using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_COConstructorUserInput
{
    internal class Program
    {
        //Name: Monaliza Jane Sibomi
        //Section: IT306

        //User Input with Constructor
        static void Main(string[] args)
        {
        Main:
            Console.Clear();

            //Ask the user to input the details
            Console.WriteLine("This program will ask about your dog's information\n");

            Console.Write("Enter the name of your dog: \t\t");
            string dName = Console.ReadLine();

            Console.Write("Enter the age of your dog (months): \t");
            int dAge = int.Parse(Console.ReadLine());

            Console.Write("Enter the breed of your dog: \t\t");
            string dBreed = Console.ReadLine();

            //instantiation of an object
            Dog dog1 = new Dog(dName, dAge, dBreed);

            //call the method to display
            dog1.DisplayDogDetails();

            //input another dog details
            Console.Write("\nDo you want to enter the dog's information again (y/n)? ");
            char answer = Convert.ToChar(Console.ReadLine());

            if (answer == 'y')
            {
                goto Main;
            }
            else if (answer == 'n')
            {
                return;
            }
        }
    }
}
