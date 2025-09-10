using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_InheritanceUserInput
{
    internal class Bag
    {
        //declare the fields
        public string brand;
        public double price;

        //constructor
        public Bag(string bagBrand, double bagPrice)
        {
            brand = bagBrand;
            price = bagPrice;
        }

        //method to display
        public void BagDetails()
        {
            Console.WriteLine($"Brand: {brand}\nPrice: ${price}");
        }
    }

    class Backpack : Bag
    {
        //additional fields
        public string color;
        public char laptopComp;

        //constructor
        public Backpack(string bagBrand, double bagPrice, string bagColor, char bagLaptopComp) : base(bagBrand, bagPrice)
        {
            color = bagColor;
            laptopComp = bagLaptopComp;
        }

        //method to display
        public void BackpackDetails()
        {
            Console.WriteLine($"Color: {color}\nHas a Laptop Compartment: {laptopComp}");
        }
    }

    class Handbag : Bag
    {
        //additional fields
        public string material;
        public char shoulderStrap;

        //constructor
        public Handbag(string bagBrand, double bagPrice, string bagMaterial, char bagShoulderStrap) : base(bagBrand, bagPrice)
        {
            material = bagMaterial;
            shoulderStrap = bagShoulderStrap;
        }

        //method to display
        public void HandbagDetails()
        {
            Console.WriteLine($"Material: {material}\nHas a Shoulder Strap: {shoulderStrap}");
        }
    }
}
