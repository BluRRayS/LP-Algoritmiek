﻿using System;
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
        private readonly List<Animal> animals;
        private readonly List<Cart> carts;
        private readonly List<Animal> animalsInCart;
        private int i;
        private string animalName;

        public WagonLoader()
        {
            InitializeComponent();
            train = new Train();
            animals = new List<Animal>();
            carts = new List<Cart>();
            animalsInCart = new List<Animal>();
        }

        private void BtnAddAnimal_Click(object sender, EventArgs e)
        {
            var enums = new Enums();

            animals.Clear();
            ListBoxAnimals.Items.Clear();
            train.AddAnimal(TxtBoxName.Text,
                (Enums.Sizes) Enum.ToObject(typeof(Enums.Sizes), enums.GetSize(ComboBoxSize.SelectedIndex)),
                (Enums.Diets) Enum.ToObject(typeof(Enums.Diets), ComboBoxDiet.SelectedIndex));
            animals.AddRange(train.GetAnimals());
            foreach (var animal in animals)
            {
                animalName = animals.ElementAt(i).Name;
                ListBoxAnimals.Items.Add(animalName);
                i++;
            }
            i = 0;
        }

        private void BtnClearList_Click(object sender, EventArgs e)
        {
            animals.Clear();
            ListBoxAnimals.Items.Clear();
            train.ClearLists();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBoxAnimals.Items.Clear();
            MessageBox.Show("You will need: " + train.CalculateCartAmount() + " of wagons");
            carts.Clear();
            carts.AddRange(train.GetCarts());
            carts.ToList().ForEach(cart => CBWagons.Items.Add("Wagon:" + cart.GetCartNumber()));
        }

        private void CBWagons_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxWagons.Items.Clear();
            animalsInCart.Clear();
            animalsInCart.AddRange(carts[CBWagons.SelectedIndex].GetAnimals());
            foreach (var animal in animalsInCart) ListBoxWagons.Items.Add(animal.ToString());
        }
    }
}
