using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Part1_Prog
{
    class Ingredient
    {
        public double originalQuantity;

        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }

        public Ingredient(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }

        public void ScaleQuantity(double scaleFactor)
        {
            Quantity *= scaleFactor;
        }

        public void ResetQuantity(double v)
        {
            Quantity = originalQuantity;
        }

        public override string ToString()
        {
            return $"{Quantity} {Unit} of {Name}";
        }
    }
}