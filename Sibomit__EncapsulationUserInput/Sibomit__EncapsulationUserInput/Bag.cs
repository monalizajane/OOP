using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit__EncapsulationUserInput
{
    internal class Bag
    {
        //Declare the properties of the Bag class
        public string Brand {  get; set; }
        public string Color { get; set; }

        //Method to display Bag information
        public void DisplayBagInfo()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Here are the bag details:\n");
            Console.WriteLine($"Brand: {Brand}\nColor: {Color}");
        }
    }
}
