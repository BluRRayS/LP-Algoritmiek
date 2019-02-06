using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening
{
    class Product
    {
        private double price;
        private string naam;
        public Product(string name, double newPrice)
        {
            naam = name;
            price = newPrice;
        }

        public double ReturnPrice()
        {
            return price;
        }

        public string ReturnName()
        {
            return naam;
        }

    }
}
