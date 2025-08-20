using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_PropertiesAndEncapsulation
{
    internal class Bag
    {
        //Declare the properties of the Bag class
        private string brand;
        private string color;

        //Set the properties for the Bag class fields
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        //Method to display Bag information
        public void DisplayBagInfo()
        {
            Console.WriteLine($"Brand: {brand}\nColor: {color}");
        }
    }
}
