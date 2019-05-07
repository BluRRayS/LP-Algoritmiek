using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Casus_Container_Vervoer.Models.Helpers;

namespace Casus_Container_Vervoer.Models
{
    internal class Planner
    {
        private List<Container> _containers;
        private readonly Ship _ship;

        public Planner(Ship ship)
        {
            _ship = ship;
            _containers = new List<Container>();
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

        public void Plan()
        {
            //If too many valuable containers are about to be loaded
            if (_containers.Count(container => container.FreightType == Enums.FreightType.Valuable) >
                _ship.GetAllPositions().Count()) throw new Exception("Too many Valuable containers for ship");

            //If ship weight isn't filled for 50%
            if(_containers.Sum(container => container.Weight) < _ship.MaxWeight/2) throw  new Exception("Minimum ship weight hasn't been reached");


            //Sort
           _containers = _containers.OrderBy(container => container.FreightType).ThenBy(container => container.Weight).ToList();

           //Add Cooled Containers
           LoadCooledContainers(_containers);
           LoadNormalContainers(_containers);
           LoadValuableContainers(_containers);

        }            

        private void LoadCooledContainers(IEnumerable<Container> containers)
        {
            containers = containers.Where(container => container.FreightType == Enums.FreightType.Cooled);
            foreach (var container in containers)
            {
               var positions = _ship.GetShipPositionsFromLightestSide().Where(pos => pos.YPos == 0);
               if(!TryLoadContainer(container, positions)) throw new Exception("Couldn't load cooled containers");
            }
        }

        private void LoadNormalContainers(IEnumerable<Container> containers)
        {
            containers = containers.Where(container => container.FreightType == Enums.FreightType.Standard);
            foreach (var container in containers)
            {
                var positions = _ship.GetShipPositionsFromLightestSide();
                if(!TryLoadContainer(container,positions)) throw new Exception("Containers won't fit");
            }
            throw new NotImplementedException();
        }

        private void LoadValuableContainers(IEnumerable<Container> containers)
        {
            containers = containers.Where(container => container.FreightType == Enums.FreightType.Valuable);
            foreach (var container in containers)
            {
                var positions = _ship.GetShipPositionsFromLightestSide();

            }
            throw new NotImplementedException();
        }



        private bool TryLoadContainer(Container container, IEnumerable<Position> positions)
        {
            return positions.Any(pos => pos.TryAddContainer(container));
        }

    }
}



