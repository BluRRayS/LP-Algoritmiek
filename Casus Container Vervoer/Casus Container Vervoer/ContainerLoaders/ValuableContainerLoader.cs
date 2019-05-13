using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.VisualStyles;
using Casus_Container_Vervoer.Interfaces;
using Casus_Container_Vervoer.Models;

namespace Casus_Container_Vervoer.ContainerLoaders
{
    public  class ValuableContainerLoader : IValuableContainerLoader
    {
        public Position FindOptimalPosition(IEnumerable<Position> positions, IContainer container)
        {
            positions = positions.OrderBy(position => position.Weight);
            return positions.First(position => position.TryAddContainer(container));
        }


        public bool TryLoadValuableContainer(IContainer container, IEnumerable<Position> positions)
        {
            positions = positions.ToList();
            var maxYPos = positions.Max(posit => posit.YPos);

            //Check if its possible to add valuable container to the front or the back of the ship because these are always accessible.
            if (positions.Any(pos => pos.TryAddContainer(container) && pos.YPos == 0 || pos.YPos == maxYPos))
            {
                return true;
            }

            foreach (var position in positions.Where(pos => (pos.YPos> 0) && (pos.YPos < maxYPos)))
            {
                var posInFront = positions.FirstOrDefault(pos => pos.YPos == position.YPos + 1 && pos.XPos == position.XPos);
                var posBehind = positions.FirstOrDefault(pos => pos.YPos == position.YPos - 1 && pos.XPos == position.XPos);
                if (position.TryAddContainer(container) && posBehind.GetContainers().Count <= position.GetContainers().Count && posInFront.GetContainers().Count <= position.GetContainers().Count  )
                {
                    return true;
                }             
            }

            return false;
        }
    }
}
