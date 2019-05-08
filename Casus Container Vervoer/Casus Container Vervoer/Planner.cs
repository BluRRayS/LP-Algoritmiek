using System;
using System.Collections.Generic;
using System.Linq;
using Casus_Container_Vervoer.ContainerLoaders;
using Casus_Container_Vervoer.Interfaces;
using Casus_Container_Vervoer.Models;
using Casus_Container_Vervoer.Models.Helpers;

namespace Casus_Container_Vervoer
{
    internal class Planner
    {
        private List<Container> _containers;
        private readonly Ship _ship;
        private readonly ICooledContainerLoader _cooledContainerLoader;
        private readonly IStandardContainerLoader _standardContainerLoader;
        private readonly IValuableContainerLoader _valuableContainerLoader;

        public Planner(Ship ship)
        {
            _ship = ship;
            _containers = new List<Container>();
            _cooledContainerLoader = new CooledContainerLoader();
            _standardContainerLoader = new StandardContainerLoader();
            _valuableContainerLoader = new ValuableContainerLoader();
        }

        public void AddContainer(double containerWeight, string type)
        {
            var freightType = (Enums.FreightType)Enum.Parse(typeof(Enums.FreightType), type, true);
            _containers.Add(new Container(containerWeight, freightType));
        }

        public IReadOnlyList<Container> GetContainersToSort()
        {
            return _containers;
        }

        public IReadOnlyList<Container> GetShipContainers()
        {
            return _ship.GetShipsContainers();
        }

        public IReadOnlyList<Position> GetShipComposition()
        {
            return _ship.GetAllPositions().ToList();
        }

        private bool IsSumContainersHeavyEnoughForShip()
        {
            return _containers.Sum(container => container.Weight) > _ship.MaxWeight / 2;
        }

        private bool IsAmountOfValuableContainersTooMuch()
        {
            return _containers.Count(container => container.FreightType == Enums.FreightType.Valuable) >
                   _ship.GetAllPositions().Count();
        }

        public void Plan()
        {
            //If too many valuable containers are about to be loaded
            if (IsAmountOfValuableContainersTooMuch()) throw new Exception("Too many Valuable containers for ship");

            //If ship weight isn't filled for 50%
            if(!IsSumContainersHeavyEnoughForShip()) throw  new Exception("Minimum ship weight hasn't been reached");

            //Sort
           _containers = _containers.OrderBy(container => container.FreightType).ThenBy(container => container.Weight).ToList();

           LoadCooledContainers(_containers.Where(container => container.FreightType == Enums.FreightType.Cooled));
           LoadNormalContainers(_containers.Where(container => container.FreightType == Enums.FreightType.Standard));
           LoadValuableContainers(_containers.Where(container => container.FreightType == Enums.FreightType.Valuable));
        }            

        private void LoadCooledContainers(IEnumerable<Container> containers)
        {
            foreach (var container in containers)
            {
               var positions = _ship.GetShipPositionsFromLightestSide().Where(pos => pos.YPos == 0).ToList();
               if(!_cooledContainerLoader.TryLoadContainer(container,positions)) throw new Exception("Couldn't load cooled containers");
               var optimalPosition = _cooledContainerLoader.FindOptimalPosition(positions, container);
               _ship.AddContainerToShipPosition(container,optimalPosition.XPos,optimalPosition.YPos);
            }
        }

        private void LoadNormalContainers(IEnumerable<Container> containers)
        {
            foreach (var container in containers)
            {
                var positions = _ship.GetShipPositionsFromLightestSide().ToList();
                if(!_standardContainerLoader.TryLoadContainer(container,positions)) throw new Exception("Standard Containers won't fit");
                var optimalPosition = _cooledContainerLoader.FindOptimalPosition(positions, container);
                _ship.AddContainerToShipPosition(container, optimalPosition.XPos, optimalPosition.YPos);
            }
        }

        private void LoadValuableContainers(IEnumerable<Container> containers)
        {
            containers = containers.Where(container => container.FreightType == Enums.FreightType.Valuable);
            foreach (var container in containers)
            {
                var positions = _ship.GetShipPositionsFromLightestSide().ToList();
                if (!_valuableContainerLoader.TryLoadValuableContainer(container, positions)) throw new Exception("Couldn't load valuable containers");
                var optimalPosition = _cooledContainerLoader.FindOptimalPosition(positions, container);
                _ship.AddContainerToShipPosition(container, optimalPosition.XPos, optimalPosition.YPos);
            }

        }



    }
}



