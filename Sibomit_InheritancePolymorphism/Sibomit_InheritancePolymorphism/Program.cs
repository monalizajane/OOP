using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_InheritancePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instance of IrregularStudent
            IrregularStudent irregular = new IrregularStudent("Beatrice", "BSIT", 18, 1200, 3000);
            irregular.DisplayInfo();
            Console.WriteLine($"Total Tuition: {irregular.ComputeTuition()}\n");

            //Instance of WorkingStudent
            WorkingStudent working = new WorkingStudent("Nicole", "BSCS", 21, 1200, 0.15);
            working.DisplayInfo();
            Console.WriteLine($"Total Tuition: {working.ComputeTuition()}\n");

            Console.WriteLine("Program finished.");
        }
    }
}
