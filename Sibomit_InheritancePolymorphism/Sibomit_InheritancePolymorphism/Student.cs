using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_InheritancePolymorphism
{
    public class Student
    {
        public string Name { get; set; }
        public string Program { get; set; }
        public int UnitsEnrolled { get; set; }
        public double RatePerUnit { get; set; }

        public Student(string name, string program, int units, double rate)
        {
            Name = name;
            Program = program;
            UnitsEnrolled = units;
            RatePerUnit = rate;
        }

        public virtual double ComputeTuition()
        {
            return UnitsEnrolled * RatePerUnit;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Program: {Program}, Units: {UnitsEnrolled}");
        }
    }

    public class IrregularStudent : Student
    {
        public double MiscellaneousFee { get; set; }

        public IrregularStudent(string name, string program, int units, double rate, double misc) 
            : base(name, program, units, rate)
        {
            MiscellaneousFee = misc;
        }

        public override double ComputeTuition()
        {

            return base.ComputeTuition() + MiscellaneousFee;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Miscellaneous Fee: {MiscellaneousFee}");
        }
    }

    public class WorkingStudent : Student
    {
        public double DiscountRate { get; set; } //e.g. 0.1 for 10%

        public WorkingStudent(string name, string program, int units, double rate, double discount)
            : base(name, program, units, rate)
        {
            DiscountRate = discount;
        }

        public override double ComputeTuition()
        {
            double tuition = base.ComputeTuition();
            return tuition - (tuition * DiscountRate);
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Discount Rate: {DiscountRate}");
        }
    }
}
