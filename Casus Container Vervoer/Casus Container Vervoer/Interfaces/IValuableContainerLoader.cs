﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casus_Container_Vervoer.Models;

namespace Casus_Container_Vervoer.Interfaces
{
    public  interface IValuableContainerLoader :IContainerLoader
    {
        bool TryLoadValuableContainer(IContainer container, IEnumerable<Position> positions);
    }
}
