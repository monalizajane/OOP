using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_InheritanceWithConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an instance of the regular class student
            RegularStudent regularStudent1 = new RegularStudent("Beatrice Joy Carvellida", "BSCPE", "CPE301");
            Console.WriteLine("\n***** REGULAR STUDENT *****\n");
            regularStudent1.SectionEnrolled();  //call method to display regular student info

            //create an instance of the irregular class student
            IrregularStudent irregularStudent1 = new IrregularStudent("Nicole Ann Ubod", "BSTM", 15);
            Console.WriteLine("\n***** IRREGULAR STUDENT *****\n");
            irregularStudent1.EnrolledSemUnits();   //call method to display irregular student info

            Console.ReadKey();
        }
    }
}
