using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casus_Container_Vervoer.Models.Helpers;

namespace Casus_Container_Vervoer.Interfaces
{
    public interface IContainer
    {     
        string ToString();
        double Weight { get;set; }
        Enums.FreightType FreightType { get; set; }
    }
}
