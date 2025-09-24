using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_TuitionUserInput
{
    internal class Student
    {
        //Properties
        public string Name { get; set; }
        public string Course { get; set; }

        //Compute total tuition
        public virtual double ComputeTotalTuition
        {
            get { return 24000 + 9000; }
        }

        //Method to display student information
        public virtual void DisplayInfo()
        {
            Console.WriteLine("\n\tREGULAR STUDENT TOTAL TUITION FEE:\n");
            Console.WriteLine($"Name: {Name}\nCourse: {Course}\nTuition: 24000\nMiscellaneous Fees: 9000\n\nTotal Tuition Fee: {ComputeTotalTuition}");
        }
    }

    class Irregular : Student
    {
        //Additional property
        public double UnitsEnrolled { get; set; }
        public double RatePerUnit { get; set; }

        //Override ComputeTotalTuition
        public override double ComputeTotalTuition
        {
            get { return 9000 + (UnitsEnrolled * RatePerUnit); }
        }

        //Override method to display student information
        public override void DisplayInfo()
        {
            Console.WriteLine("\n\tIRREGULAR STUDENT TOTAL TUITION FEE:\n");
            Console.WriteLine($"Name: {Name}\nCourse: {Course}\nMiscellaneous Fees: 9000\nUnits Enrolled: {UnitsEnrolled}\nRate per Unit: {RatePerUnit}\n\nTotal Tuition Fee: {ComputeTotalTuition}");
        }
    }

    class Working : Student
    {
        //Additional property
        public double Discount { get; set; }

        //Override ComputeTotalTuition
        public override double ComputeTotalTuition
        {
            get { return (24000 + 9000) - (24000 * (Discount / 100)); }
        }

        //Override method to display student information
        public override void DisplayInfo()
        {
            Console.WriteLine("\n\tWORKING STUDENT TOTAL TUITION FEE:\n");
            Console.WriteLine($"Name: {Name}\nCourse: {Course}\nTuition: 24000\nMiscellaneous Fees: 9000\nDiscount: {Discount}%\n\nTotal Tuition Fee: {ComputeTotalTuition}");
        }
    }
}
