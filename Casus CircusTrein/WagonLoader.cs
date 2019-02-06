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
        private Loader loader;
        private List<Animal> animals;
        private int i = 0;
        private string animalName;
        public WagonLoader()
        {
            InitializeComponent();
            loader = new Loader();
            animals = new List<Animal>();
        }

        private void BtnAddAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                animals.Clear();
                ListBoxAnimals.Items.Clear();
                loader.AddAnimal(TxtBoxName.Text, ComboBoxSize.SelectedIndex+1, Convert.ToBoolean(ComboBoxDiet.SelectedIndex));
                animals.AddRange(loader.GetAnimals());
                foreach (Animal animal in animals)
                {
                    animalName = animals.ElementAt(i).Name();
                    ListBoxAnimals.Items.Add(animalName);
                    i++;
                }
                i = 0;
            }
            catch { }
        }

        private void BtnClearList_Click(object sender, EventArgs e)
        {
            animals.Clear();
            ListBoxAnimals.Items.Clear();
            loader.ClearList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBoxAnimals.Items.Clear();
            MessageBox.Show("You will need: " + loader.CalculateCartAmount() + " of wagons");
        }
    }
}
