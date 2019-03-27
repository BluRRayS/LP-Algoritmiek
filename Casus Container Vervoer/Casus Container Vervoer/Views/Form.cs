﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Casus_Container_Vervoer.Models;
using Casus_Container_Vervoer.Models.Helpers;
using Microsoft.Win32;

namespace Casus_Container_Vervoer
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Planner _planner;
        public Form()
        {
            InitializeComponent();
            ComboBoxFreightTypes.Items.AddRange(Enum.GetNames(typeof(Enums.FreightType)));
        }


        private void AddShipButton_Click(object sender, EventArgs e)
        {
            if (NUDWidth.Value>0 && NUDLenght.Value>0 && NUDMaxWeight.Value>0)
            {
                var ship = new Ship(Convert.ToInt32(NUDLenght.Value), Convert.ToInt32(NUDWidth.Value),
                    Convert.ToInt32(NUDMaxWeight.Value));
                _planner = new Planner(ship);
                AddShipBtn.Enabled = false;
            }
            else
            {
                MessageBox.Show("Values can't be 0 or lower");
            }
        }

        private void AddContainerBtn_Click(object sender, EventArgs e)
        {
            _planner.AddContainer(Convert.ToDouble(NUDContainerWeight.Value),ComboBoxFreightTypes.Text);
            RefreshContainerListBox();
        }

        private void SortContainersBtn_Click(object sender, EventArgs e)
        {
            _planner.Plan();
            var i = 0;
            var containersOnShip = _planner.GetShipContainers();
            foreach (var container in containersOnShip)
            {
                ListBoxShipContainers.Items.Add(containersOnShip[i].ToString());
                i++;
            }
           
        }

        private void RefreshContainerListBox()
        {
            listBoxContainers.Items.Clear();
            var containersToSort = _planner.GetContainersToSort();
            for (var i = 0; i > containersToSort.Count; i++)
            {
                ListBoxShipContainers.Items.Add(containersToSort[i].ToString());
            }
        }
    }
}
