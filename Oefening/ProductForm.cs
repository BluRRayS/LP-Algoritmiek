using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening
{
    public partial class ProductForm : Form
    {
        private Orders orders;
        private List<Product> minimumPriceProduct;
        private List<Product> SortedProducts;
        private string productNamePrice;
        private int i = 0;
        public ProductForm()
        {
            InitializeComponent();
            orders = new Orders();
            minimumPriceProduct = new List<Product>();
            SortedProducts = new List<Product>();
        }



        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                SortedProducts.Clear();
                ListBoxSortedProducts.Items.Clear();
                orders.AddProduct(TxtBoxName.Text, Convert.ToDouble(TxtBoxPrice.Text));
                SortedProducts.AddRange(orders.SortProductsByPrice());
                foreach (Product product in SortedProducts)
                {
                    productNamePrice = (product.ReturnName() +":€" + product.ReturnPrice());
                    ListBoxSortedProducts.Items.Add(productNamePrice);
                }
                i = 0;

            }
            catch { }
        }

        private void BtnMax_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(orders.GiveMaximumPrice()));
        }

        private void BtnAvg_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(orders.GiveAveragePrice()));
        }

        private void BtnMinimumPrice_Click(object sender, EventArgs e)
        {
            try
            {
                minimumPriceProduct.Clear();
                ListBoxMinimumPrice.Items.Clear();
                minimumPriceProduct.AddRange(orders.GetFilteredProductList(Convert.ToDouble(NUDMinimum.Value)));
                foreach (Product filtered in minimumPriceProduct)
                {
                    productNamePrice = (filtered.ReturnName() + ":€" + filtered.ReturnPrice());
                    ListBoxMinimumPrice.Items.Add(productNamePrice);
                }
            }
            catch { }
        }
    }
}
