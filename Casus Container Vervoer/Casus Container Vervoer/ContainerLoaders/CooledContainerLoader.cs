using System;
using System.Collections.Generic;
using System.Linq;
using Casus_Container_Vervoer.Interfaces;
using Casus_Container_Vervoer.Models;

namespace Casus_Container_Vervoer.ContainerLoaders
{
    public  class CooledContainerLoader :ICooledContainerLoader
    {
        public Position FindOptimalPosition(IEnumerable<Position> positions, Container container)
        {
            positions = positions.OrderBy(position => position.Weight);
            return positions.First(position => position.TryAddContainer(container));
        }


        public bool TryLoadContainer(Container container, IEnumerable<Position> positions)
        {
            return positions.Any(pos => pos.TryAddContainer(container));
        }
    }
}
