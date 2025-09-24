using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_TuitionComputation
{
    internal class Student
    {
        //Properties
        public double BaseTuition { get; set; }
        public double Miscellaneous { get; set; }

        //Compute Total Tuition
        public virtual double ComputeTuitionFee
        {
            get { return BaseTuition + Miscellaneous; }
        }

        //Method to display
        public virtual void TotalTuitionFee()
        {
            Console.WriteLine($"Tuition Fee: {BaseTuition}\nMiscellaneous Fee: {Miscellaneous}\n\nTotal Tuition Fee: {ComputeTuitionFee}" );
        }
    }

    class Irregular : Student
    {
        //Additional properties
        public double UnitsEnrolled { get; set; }
        public double RatePerUnit { get; set; }

        //Override ComputeTuitionFee
        public override double ComputeTuitionFee
        {
            get { return (UnitsEnrolled * RatePerUnit) + Miscellaneous; }
        }

        //Override method to display
        public override void TotalTuitionFee()
        {
            Console.WriteLine($"Units Enrolled: {UnitsEnrolled}\nRate per Unit: {RatePerUnit}\nMiscellaneous Fee: {Miscellaneous}\n\nTotal Tuition Fee: {ComputeTuitionFee}");
        }
    }

    class Working : Student
    {
        //Additional property
        public double Discount { get; set; }

        //Override ComputeTuitionFee
        public override double ComputeTuitionFee
        {
            get { return (BaseTuition + Miscellaneous) - (BaseTuition * (Discount / 100)); }
        }

        //Override method to display
        public override void TotalTuitionFee()
        {
            Console.WriteLine($"Tuition Fee: {BaseTuition}\nMiscellaneous Fee: {Miscellaneous}\nDiscount: {Discount}%\n\nTotal Tuition Fee: {ComputeTuitionFee}");
        }
    }
}
