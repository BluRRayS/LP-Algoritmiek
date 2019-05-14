﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casus_Container_Vervoer.Interfaces;

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

        public IContainer IContainer
        {
            get => default(IContainer);
            set
            {
            }
        }

        public void AddContainer(IContainer container)
        {
            var containerToAdd = new Container(container.Weight,container.FreightType);
            _containers.Add(containerToAdd);
            Weight += container.Weight;
        }

        public IReadOnlyCollection<IContainer> GetContainers()
        {
            return _containers;
        }

        public double GetPositionWeight()
        {
            if (_containers.Count == 0) return 0;
            return (Weight -  _containers[0].Weight);
        }

        public bool TryAddContainer(IContainer container)
        {
            return ((container.Weight + GetPositionWeight())<= MaxWeight);
        }
    }
}
