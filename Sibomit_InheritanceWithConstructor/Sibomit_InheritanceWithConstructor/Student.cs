using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_InheritanceWithConstructor
{
    internal class Student  //base class
    {
        //declare the fields for student class
        public string name;
        public string program;

        //constructor
        public Student(string studentName, string studentProgram)
        {
            name = studentName;
            program = studentProgram;
        }

        //method to display studnet info
        public void BasicInfo()
        {
            Console.WriteLine($"Name: {name}\nProgram: {program}");
        }
    }

    class RegularStudent : Student  //derived class
    {
        //additional field
        public string section;

        //constructor
        public RegularStudent(string studentName, string studentProgram, string studentSection) : base(studentName, studentProgram)
        {
            section = studentSection;
        }

        //method to display regular student info
        public void SectionEnrolled()
        {
            BasicInfo();    //call base class method to display
            Console.WriteLine($"Section: {section}");
        }
    }

    class IrregularStudent : Student    //derived class
    {
        //additional field
        public int unitsEnrolled;

        //constructor
        public IrregularStudent(string studentName, string studentProgram, int studentUnits) : base(studentName, studentProgram)
        {
            unitsEnrolled = studentUnits;
        }

        //method to display irregular student info
        public void EnrolledSemUnits()
        {
            BasicInfo();   //call base class method to display
            Console.WriteLine($"Units Enrolled: {unitsEnrolled}");
        }
    }
}
