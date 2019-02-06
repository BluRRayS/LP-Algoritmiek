using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening
{
    class Orders
    {
        private List<Product> products;
        private List<Product> filteredProducts;
        private double productPrice;
        private double maxProductPrice;
        private int i = 0;
        private Product temp;
        private double first;
        private double second;
        private bool sorted = false;
        private int sortTimes;

        public Orders()
        {
            products = new List<Product>();
            filteredProducts = new List<Product>();
        }

        public void AddProduct(string name, double price)
        {
            products.Add(new Product(name, price));
        }

        public double GiveMaximumPrice()
        {
            productPrice = 0;
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
            productPrice = 0;
            foreach (Product product in products)
            {
                productPrice += product.ReturnPrice();
                i++;
            }
            productPrice = (productPrice / i);
            i = 0;
            return productPrice;
        }

        public List<Product> GetFilteredProductList(double minimumPrice)
        {
            filteredProducts.Clear();
            foreach (Product product in products)
            {
                if ((productPrice = product.ReturnPrice()) >= minimumPrice)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }

        public List<Product> SortProductsByPrice()
        {
            while (sorted == false)
            {
                sortTimes = 0;
                for (int i = 0; i < products.Count; i++)
                {
                    for (int j = i + 1; j < products.Count; j++)
                    {
                        if ((first = (products.ElementAt(i).ReturnPrice())) > (second = (products.ElementAt(j).ReturnPrice())))
                        {
                            sortTimes++;
                            temp = products.ElementAt(i);
                            first = products.IndexOf(products.ElementAt(i));
                            second = products.IndexOf(products.ElementAt(j));
                            products.RemoveAt(Convert.ToInt32(first));
                            products.Insert(Convert.ToInt32(second), temp);
                        }
                    }
                }
                if (sortTimes == 0)
                {
                    sorted = true;
                }
            }
            sorted = false;
            return products;
        }
    }
}
