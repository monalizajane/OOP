using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_TuitionUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Main:
            Console.Clear();

            //Ask user for student type
            Console.WriteLine("\tSelect Student Type:");
            Console.WriteLine("\nA. Regular Student");
            Console.WriteLine("B. Irregular Student");
            Console.WriteLine("C. Working Student");
            Console.Write("\n\tEnter choice (A - C): ");
            string choice = Console.ReadLine();

            if (choice == "A" || choice == "a")
            {
                Console.Clear();
                Console.WriteLine("Enter your information:\n");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Course: ");
                string course = Console.ReadLine();
                Console.Write("Tuition Fee: P24000");
                Console.Write("\nMiscellaneous Fees: P9000");

                Student student1 = new Student
                {
                    Name = name,
                    Course = course
                };
                Console.Clear();
                student1.DisplayInfo();
            }
            else if (choice == "B" || choice == "b")
            {
                Console.Clear();
                Console.WriteLine("Enter your information:\n");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Course: ");
                string course = Console.ReadLine();
                Console.Write("Miscellaneous Fees: P9000");
                Console.Write("\nUnits Enrolled: ");
                double unitsEnrolled = Convert.ToDouble(Console.ReadLine());
                Console.Write("Rate per Unit: ");
                double ratePerUnit = Convert.ToDouble(Console.ReadLine());

                Irregular student2 = new Irregular
                {
                    Name = name,
                    Course = course,
                    UnitsEnrolled = unitsEnrolled,
                    RatePerUnit = ratePerUnit
                };
                Console.Clear();
                student2.DisplayInfo();
            }
            else if (choice == "C" || choice == "c")
            {
                Console.Clear();
                Console.WriteLine("Enter your information:\n");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Course: ");
                string course = Console.ReadLine();
                Console.Write("Tuition Fee: P24000");
                Console.Write("\nMiscellaneous Fees: P9000");
                Console.Write("\nDiscount (in percentage): ");
                double discount = Convert.ToDouble(Console.ReadLine());

                Working student3 = new Working
                {
                    Name = name,
                    Course = course,
                    Discount = discount
                };
                Console.Clear();
                student3.DisplayInfo();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid choice.");
                Console.ReadLine();
                goto Main;
            }

            //Enter another information
            Console.Write("\nDo you want to enter another information? (Y/N): ");
            string again = Console.ReadLine();
            if (again == "Y" || again == "y")
            {
                goto Main;
            }
            else if (again == "N" || again == "n")
            {
                return;
            }

            Console.ReadKey();
        }
    }
}
