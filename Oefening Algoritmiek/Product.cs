using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Algoritmiek
{
    class Product
    {
        private double price;
        private string naam;
        public Product(string name, double newPrice)
        {
            string naam = name;
            double price = newPrice;
        }

        public double ReturnPrice()
        {
            return price;
        }
    }
}
