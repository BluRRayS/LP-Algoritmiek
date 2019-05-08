using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casus_Container_Vervoer.Interfaces;
using Casus_Container_Vervoer.Models;

namespace Casus_Container_Vervoer
{
    public  class ValuableContainerLoader : IValuableContainerLoader
    {
        public Position FindOptimalPosition(IEnumerable<Position> positions, Container containers)
        {
            throw new NotImplementedException();
        }

        public bool TryLoadValuableContainer(Container container, IEnumerable<Position> positions)
        {
            return positions.Any(pos => pos.TryAddContainer(container));
        }
    }
}
