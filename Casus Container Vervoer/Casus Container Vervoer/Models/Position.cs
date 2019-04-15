using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Container_Vervoer.Models
{
    internal class Position
    {
        private readonly List<Container> _containers;
        public Position(int xPos, int yPos)
        {
            this.XPos = xPos;
            this.YPos = yPos;
            _containers = new List<Container>();
        }

        public double Weight { get; private set; }
        public int XPos { get; private set; }
        public int YPos { get; private set; }
        public int ZPos { get; private set; }

        public void AddContainer(Container container)
        {
            _containers.Add(container);
            Weight += container.Weight;
        }

        public IReadOnlyCollection<Container> GetContainers()
        {
            return _containers;
        }

        private double GetPositionWeight()
        {
            return Weight - _containers.First().Weight;
        }

        public bool TryAddContainer(Container container)
        {
            return Weight + container.Weight <= GetPositionWeight();
        }
    }
}
