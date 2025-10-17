using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_AbstractionActivity
{
    abstract class Bag
    {
        // Common Properties
        public string Brand { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        // Constructor
        public Bag(string brand, string color, double price)
        {
            Brand = brand;
            Color = color;
            Price = price;
        }

        // Abstract Methods
        public abstract void DisplayDetails();
        public abstract double CalculateDiscount(double percent);

        // Concrete Method
        public void Carry()
        {
            Console.WriteLine($"{Brand} bag can be carried anywhere.\n");
        }
    }

    // Derived Class 1: SchoolBag
    class SchoolBag : Bag
    {
        public int NumberOfCompartments { get; set; }

        public SchoolBag(string brand, string color, double price, int compartments)
            : base(brand, color, price)
        {
            NumberOfCompartments = compartments;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("===== SCHOOL BAG DETAILS =====");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Price: ₱{Price}");
            Console.WriteLine($"Number of Compartments: {NumberOfCompartments}");
        }

        public override double CalculateDiscount(double percent)
        {
            double discount = Price * (percent / 100);
            double discountedPrice = Price - discount;
            Console.Write($"Discounted Price: ₱{discountedPrice}\n");
            return discountedPrice;
        }
    }

    // Derived Class 2: TravelBag
    class TravelBag : Bag
    {
        public double Capacity { get; set; } // in liters

        public TravelBag(string brand, string color, double price, double capacity)
            : base(brand, color, price)
        {
            Capacity = capacity;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("===== TRAVEL BAG DETAILS =====");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Price: ₱{Price}");
            Console.WriteLine($"Capacity: {Capacity} liters");
        }

        public override double CalculateDiscount(double percent)
        {
            // Travel bags may have a smaller discount rate
            double discount = Price * (percent / 100);
            double discountedPrice = Price - discount;
            Console.Write($"Discounted Price: ₱{discountedPrice}\n");
            return discountedPrice;
        }
    }
}