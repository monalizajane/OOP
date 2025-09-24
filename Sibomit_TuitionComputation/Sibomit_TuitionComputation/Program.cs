using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_TuitionComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instance of Student
            Student student1 = new Student
            {
                BaseTuition = 18000,
                Miscellaneous = 9000
            };

            //Call method to display
            Console.WriteLine("Regular Student");
            student1.TotalTuitionFee();

            //Instance of Irregular
            Irregular student2 = new Irregular
            {
                BaseTuition = 18000,
                UnitsEnrolled = 15,
                RatePerUnit = 2000,
                Miscellaneous = 9000
            };

            //Call method to display
            Console.WriteLine("\nIrregular Student");
            student2.TotalTuitionFee();

            //Instance of Working
            Working student3 = new Working
            {
                BaseTuition = 18000,
                Miscellaneous = 9000,
                Discount = 50
            };

            //Call method to display
            Console.WriteLine("\nWorking Student");
            student3.TotalTuitionFee();

            Console.ReadKey();
        }
    }
}
