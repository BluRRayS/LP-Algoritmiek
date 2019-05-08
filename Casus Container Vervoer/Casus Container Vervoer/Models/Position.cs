using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Container_Vervoer.Models
{
    public class Position
    {
        private const double MaxWeight = 120;
        private readonly List<Container> _containers;
        public Position(int xPos, int yPos)
        {
            XPos = xPos;
            YPos = yPos;
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

        public IReadOnlyCollection<Container> GetContainers()
        {
            return _containers;
        }

        public double GetPositionWeight()
        {
            return Weight - _containers.First().Weight;
        }

        public bool TryAddContainer(Container container)
        {
            return ((container.Weight + GetPositionWeight())<= MaxWeight);
        }
    }
}
