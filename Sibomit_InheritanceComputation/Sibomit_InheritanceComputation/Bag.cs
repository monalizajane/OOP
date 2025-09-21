using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibomit_InheritanceComputation
{
    internal class Bag
    {
        //declaration of properties
        public string Brand { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }

        //method to calculate discounted price
        public virtual double DiscountedPrice
        {
            get { return Price - (Price * Discount); }
        }

        //method to display bag details
        public virtual string BagDetails()
        {
            return $"Brand: {Brand}";
        }
    }

    class Backpack : Bag
    {
        //additional property for backpack
        public string Color { get; set; }

        //override method to calculate discounted price
        public override double DiscountedPrice
        {
            get { return Price - (Price * Discount); }
        }

        //override method to display bag details
        public override string BagDetails()
        {
            return $"Brand: {Brand}\nColor: {Color}";
        }
    }

    class Handbag : Bag
    {
        //additional property for handbag
        public string Material { get; set; }

        //override method to calculate discounted price
        public override double DiscountedPrice
        {
            get { return Price - (Price * Discount); }
        }

        //override method to display bag details
        public override string BagDetails()
        {
            return $"Brand: {Brand}\nMaterial: {Material}";
        }
    }
}
