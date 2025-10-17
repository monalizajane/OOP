using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_AbstractionActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of SchoolBag and TravelBag
            SchoolBag mySchoolBag = new SchoolBag("Adidas", "Blue", 1600, 5);
            TravelBag myTravelBag = new TravelBag("Maia", "Black", 9900, 40);

            // Display details
            mySchoolBag.DisplayDetails();
            mySchoolBag.CalculateDiscount(10);
            mySchoolBag.Carry();

            myTravelBag.DisplayDetails();
            myTravelBag.CalculateDiscount(5);
            myTravelBag.Carry();

            Console.ReadKey();
        }
    }
}
