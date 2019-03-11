using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casus_Container_Vervoer.Models.Helpers;

namespace Casus_Container_Vervoer.Models
{
    internal class Container
    {
        private static double _emptyWeight;
        private static double _maxWeight;

        public Container(double weight,Enums.FreightType type)
        {
            _emptyWeight = 0.4;
            _maxWeight = 120;
            this.Weight = weight;
            FreightType = type;
        }

        public Container(double containerWeight,double maxContainerWeight,double weight, Enums.FreightType type)
        {
            _emptyWeight = containerWeight;
            _maxWeight = maxContainerWeight;
            this.Weight = weight;
            FreightType = type;
        }

        public double Weight { get; private set; }
        public Enum FreightType { get; private set; }
    }
}
