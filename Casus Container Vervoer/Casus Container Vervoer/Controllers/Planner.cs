using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Container_Vervoer.Models
{
    internal class Planner
    {
        public void AddShip(int length, int width, int weight)
        {
            var ship = new Ship(width,length,weight);
        }

        public void Plan()
        {

        }
    }
}
