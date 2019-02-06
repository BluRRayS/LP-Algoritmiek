using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Algoritmiek
{
    class Orders
    {
        private List<Product> products;
        private double productPrice;
        private double maxProductPrice;
        private int i = 0;

        public Orders()
        {
            products = new List<Product>();
        }

        public void AddProduct(string name, double price)
        {
            products.Add(new Product(name, price));
        }

        public double GiveMaximumPrice()
        {
            foreach (Product product in products)
            {
                productPrice = product.ReturnPrice();
                i++;
                if (productPrice > maxProductPrice)
                { maxProductPrice = productPrice; }
            }
            i = 0;
            return maxProductPrice;
        }

        public double GiveAveragePrice()
        {
            foreach (Product product in products)
            {
                productPrice += product.ReturnPrice();
                i++;
            }
            productPrice = (productPrice / i);
            i = 0;
            return productPrice;          
        }
    }
}

