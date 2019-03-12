using System;
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
        private Planner _planner = new Planner();
        public Form()
        {
            InitializeComponent();
            ComboBoxFreightTypes.Items.AddRange(Enum.GetNames(typeof(Enums.FreightType)));
        }


        private void AddShipButton_Click(object sender, EventArgs e)
        {
            if (NUDWidth.Value>0 && NUDLenght.Value>0 && NUDMaxWeight.Value>0)
            {
                _planner.AddShip(Convert.ToInt32(NUDLenght.Value),Convert.ToInt32(NUDWidth.Value),Convert.ToInt32(NUDMaxWeight.Value));
            }
            else
            {
                MessageBox.Show("Values can't be 0 or lower");
            }
        }

        private void AddContainerBtn_Click(object sender, EventArgs e)
        {
            _planner.AddContainer(Convert.ToDouble(NUDContainerWeight.Value),ComboBoxFreightTypes.Text);
        }

        private void SortContainersBtn_Click(object sender, EventArgs e)
        {
            _planner.Plan();
            int i = 0;
            var containersOnShip = _planner.GetShipContainers();
            foreach (var container in containersOnShip)
            {
                ListBoxShipContainers.Items.Add(containersOnShip[i].ToString());
                i++;
            }
           
        }
    }
}
