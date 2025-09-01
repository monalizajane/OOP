using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_SimpleInheritance
{
    internal class Student
    {
        //Properties fr the Student Class
        public string Name { get; set; }
        public string Program { get; set; }

        //Method to display student information
        public void BasicInfo()
        {
            Console.WriteLine($"Name: {Name}\nProgram: {Program}");
        }
    }

    class RegularStudent : Student
    {
        //Additional property for the Regular Student class
        public string Section { get; set; }

        //Method to display regular student information
        public void SectionEnrolled()
        {
            Console.WriteLine($"Section: {Section}");
        }
    }

    class IrregularStudent : Student
    {
        //Additinal property for the Irregular Student class
        public int UnitsEnrolled { get; set; }

        //Method to display irregular student information
        public void EnrolledSemUnits()
        {
            Console.WriteLine($"Units Enrolled: {UnitsEnrolled}");
        }
    }
}
