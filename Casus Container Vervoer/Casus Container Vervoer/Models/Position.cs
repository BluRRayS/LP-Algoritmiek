using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Container_Vervoer.Models
{
    internal class ShipSpot
    {
        private readonly List<Container> _containers;
        public ShipSpot(int xPos, int yPos)
        {
            this.XPos = xPos;
            this.YPos = yPos;
            _containers = new List<Container>();
        }

        public double Weight { get; private set; }
        public int XPos { get; private set; }
        public int YPos { get; private set; }

        public void AddContainer(Container container)
        {
            _containers.Add(container);
            Weight += container.Weight;
        }

        public IReadOnlyList<Container> GetContainers()
        {
            return _containers;
        }
    }
}
