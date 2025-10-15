using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_Polymorphism
{
    class Bag
    {
        public string Brand { get; set; }
        public double Price { get; set; }

        //Virtual method for the Bag class
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}\nPrice: ₱{Price}");
        }
    }

    //Derived class 1
    class Backpack : Bag
    {
        public string Color { get; set; }

        //Override method for the Backpack class
        public override void DisplayInfo()
        {
            Console.WriteLine("===== Backpack Information =====");
            Console.WriteLine($"Brand: {Brand}\nPrice: ₱{Price}\nColor: {Color}\n");
        }
    }

    //Derived class 2
    class Handbag : Bag
    {
        public string Material { get; set; }

        //Override method for the Handbag class
        public override void DisplayInfo()
        {
            Console.WriteLine("===== Handbag Information =====");
            Console.WriteLine($"Brand: {Brand}\nPrice: ₱{Price}\nMaterial: {Material}\n");
        }
    }
}
