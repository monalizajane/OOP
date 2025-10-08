using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_Abstraction
{
    abstract class Bag
    {
        //Declare properties for the Bag class
        public string Brand { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        //Constructor for the Bag class
        public Bag(string brand, string color, double price)
        {
            Brand = brand;
            Color = color;
            Price = price;
        }

        //Abstract method that must be implemented by derived classes
        public abstract void DisplayDetails();

        //Concrete method that can be used by derived classes
        public void DiscountedPrice(double percent)
        {
            double discount = Price * (percent / 100);
            Price -= discount;     //Price = Price - discount

            Console.WriteLine($"Discount: {percent}%");
            Console.WriteLine($"Updated Price: {Price:F2}");     //F2 formats the price to 2 decimal places")
        }
    }

    class Backpack : Bag
    {
        //Additional property for the Backpack class
        public int Pockets { get; set; }

        //Constructor for the Backpack class
        public Backpack(string brand, string color, double price, int pockets)
            : base(brand, color, price)
        {
            Pockets = pockets;
        }

        //Implementation of the abstract method
        public override void DisplayDetails()
        {
            Console.WriteLine("========BACKPACK DETAILS========\n");
            Console.WriteLine($"Brand: {Brand}\nColor: {Color}\nPrice: P {Price:F2}\nPockets: {Pockets}");
            DiscountedPrice(10); //Apply a 10% discount
        }
    }

    class Handbag : Bag
    {
        //Additional property for the Handbag class
        public string Material { get; set; }

        //Constructor for the Handbag class
        public Handbag(string brand, string color, double price, string material)
            : base(brand, color, price)
        {
            Material = material;
        }

        //Implementation of the abstract method
        public override void DisplayDetails()
        {
            Console.WriteLine("\n\n========HANDBAG DETAILS========\n");
            Console.WriteLine($"Brand: {Brand}\nColor: {Color}\nPrice: P {Price:F2}\nMaterial: {Material}");
            DiscountedPrice(15); //Apply a 15% discount
        }
    }
}
