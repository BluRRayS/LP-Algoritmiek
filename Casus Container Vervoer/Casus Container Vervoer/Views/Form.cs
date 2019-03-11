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

namespace Casus_Container_Vervoer
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Planner planner;
        public Form()
        {
            InitializeComponent();
            var planner = new Planner();
        }

        private void AddShipButton_Click(object sender, EventArgs e)
        {
            if (NUDWidth.Value>0 && NUDLenght.Value>0 && NUDMaxWeight.Value>0)
            {
                planner.AddShip(Convert.ToInt32(NUDLenght.Value),Convert.ToInt32(NUDWidth.Value),Convert.ToInt32(NUDMaxWeight.Value));
            }
            else
            {
                MessageBox.Show("Values can't be 0 or lower");
            }
        }

        private void AddContainerBtn_Click(object sender, EventArgs e)
        {
            if (AllowDrop)
            {
                
            }
            else
            {
                
            }
        }

        private void SortContainersBtn_Click(object sender, EventArgs e)
        {
            planner.Plan();
        }
    }
}
