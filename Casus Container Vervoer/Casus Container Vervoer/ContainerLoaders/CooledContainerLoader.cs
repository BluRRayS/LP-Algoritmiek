﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casus_Container_Vervoer.Models;

namespace Casus_Container_Vervoer
{
    internal class CooledContainerLoader :IContainerLoader
    {
        public Position FindOptimalPosition(IEnumerable<Position> positions, Container containers)
        {
            foreach (var position in positions)
            {
                ;
            }
        }
    }
}
