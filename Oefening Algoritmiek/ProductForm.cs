using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening_Algoritmiek
{
    public partial class ProductForm : Form
    {
        Orders orders;
        public ProductForm()
        {           
            InitializeComponent();
            orders = new Orders();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                orders.AddProduct(TxtBoxName.Text, Convert.ToDouble(TxtBoxPrice.Text));
            }
            catch { }
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(orders.GiveMaximumPrice()));
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
