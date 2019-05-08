using System.Collections.Generic;
using Casus_Container_Vervoer.Models;

namespace Casus_Container_Vervoer.Interfaces
{
    public  interface IContainerLoader
    {
        Position FindOptimalPosition(IEnumerable<Position> positions, Container container);
    }
}
