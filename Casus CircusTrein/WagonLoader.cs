using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casus_CircusTrein
{
    public partial class WagonLoader : Form
    {
        private readonly Train train;
        private readonly List<Animal> animalsInCart;


        public WagonLoader()
        {
            InitializeComponent();
            train = new Train();
            animalsInCart = new List<Animal>();
        }

        private void BtnAddAnimal_Click(object sender, EventArgs e)
        {
            train.AddAnimal(TxtBoxName.Text,(Enums.Sizes) ComboBoxSize.SelectedIndex,(Enums.Diets) ComboBoxDiet.SelectedIndex);
            ListBoxAnimals.Items.Add(TxtBoxName.Text+"-"+ComboBoxSize.SelectedItem.ToString()+"-"+ComboBoxDiet.SelectedItem.ToString());
        }

        private void BtnClearList_Click(object sender, EventArgs e)
        {
            ListBoxAnimals.Items.Clear();
            ListBoxWagons.Items.Clear();
            CBWagons.Items.Clear();
            train.ClearLists();
            BtnAddAnimal.Enabled = true;
        }

        private void CBWagons_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxWagons.Items.Clear();
            animalsInCart.Clear();
            animalsInCart.AddRange(train.GetTrainCarts().ToList()[CBWagons.SelectedIndex].GetAnimals());
            foreach (var animal in animalsInCart) ListBoxWagons.Items.Add(animal.ToString());
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            BtnAddAnimal.Enabled = false;
            ListBoxAnimals.Items.Clear();
            MessageBox.Show("You will need:"+train.CalculateCartAmount()+" train carts");
            var counter = 1;
            foreach (var cart in train.GetTrainCarts())
            {
                CBWagons.Items.Add("Wagon:"+counter);
                counter++;
            }
        }
    }
}
