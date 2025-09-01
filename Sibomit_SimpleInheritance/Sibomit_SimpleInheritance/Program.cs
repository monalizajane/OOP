using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_SimpleInheritance
{
    internal class Program
    {
        //Name: Monaliza Jane Sibomit
        //Section: IT306
        //Exercise: Simple Inheritance
        static void Main(string[] args)
        {
            //Create an instance of the Regular Student class
            RegularStudent regularStudent1 = new RegularStudent
            {
                Name = "Beatrice Joy Carvellida",
                Program = "BSCPE",
                Section = "CPE301"
            };
            Console.WriteLine("\n***** REGULAR STUDENT *****\n");
            regularStudent1.BasicInfo();    //Call inherited method to display student information
            regularStudent1.SectionEnrolled();  //Call method to display regular student information

            //Create an instance of the Irregular Student class
            IrregularStudent irregularStudent1 = new IrregularStudent
            {
                Name = "Nicole Ann Ubod",
                Program = "BSTM",
                UnitsEnrolled = 15
            };
            Console.WriteLine("\n***** IRREGULAR STUDENT *****\n");
            irregularStudent1.BasicInfo();  //Call inherited method to display student information
            irregularStudent1.EnrolledSemUnits();   //Call method to display irregular student information

            Console.ReadKey();
        }
    }
}
