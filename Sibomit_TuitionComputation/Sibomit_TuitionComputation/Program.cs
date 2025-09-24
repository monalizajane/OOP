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
                BaseTuition = 24000,
                Miscellaneous = 9000
            };

            //Call method to display
            Console.WriteLine("\n\t*****Regular Student*****\n");
            student1.TotalTuitionFee();

            //Instance of Irregular
            Irregular student2 = new Irregular
            {
                UnitsEnrolled = 15,
                RatePerUnit = 1500,
                Miscellaneous = 9000
            };

            //Call method to display
            Console.WriteLine("\n\n\t*****Irregular Student*****\n");
            student2.TotalTuitionFee();

            //Instance of Working
            Working student3 = new Working
            {
                BaseTuition = 24000,
                Miscellaneous = 9000,
                Discount = 50
            };

            //Call method to display
            Console.WriteLine("\n\n\t*****Working Student*****\n");
            student3.TotalTuitionFee();

            Console.ReadKey();
        }
    }
}
