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
        private Ship _ship;
        private int xPos;
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

        private List<Container> GetCooledContainers()
        {
            var cooledContainers = _containers.Where(container => container.FreightType.Equals(Enums.FreightType.Cooled)).OrderBy(cooler => cooler.Weight).ToList();
            return cooledContainers;
        }

        private List<Container> GetAllStandardContainers()
        {
            var standardContainers = _containers
                .Where(container => container.FreightType.Equals(Enums.FreightType.Standard)).OrderBy(standard => standard.Weight).ToList();
            return standardContainers;
        }

        //Note: add containers to ship as well to measure max weight has been reached and to check which containers are gonna be loaded onto the ship.
        //Note: weight comparison working (no control ship weight) if first row limit has been reached cooled container is not added
        public void Plan()
        {
            //step 1 add all cooled containers to the front y=0           
            FillRow(GetCooledContainers(), _ship.GetShipSpots(0));

            //Step 2 fill the middle part with containers valuables and cooled can't be placed here.        
            FillRange(GetAllStandardContainers(), _ship, 1, _ship.Width - 1);

            //Step 3 fill front with resting normal containers and valuables and fill back.
            AddValuableContainers();
        }

        public IReadOnlyList<Container> GetShipContainers()
        {
            return _ship.GetShipsContainers();
        }

        //Note: add range from min to max YPosition
        //Note: Need to add a check if adding a container is still possible.
        //Mass filling for the center Rows.
        public void FillRange(List<Container> containers, Ship ship, int min, int max)
        {
            var xPos = 0;
            var yPos = min;
            var sideSwitch = false;
            foreach (var container in containers)
            {
                if (xPos > ship.Width)
                {
                    if (sideSwitch == false)
                    {
                        var shipSpot = ship.GetSpotForContainer(xPos, yPos, container);
                        shipSpot.AddContainer(container);
                        sideSwitch = true;
                    }
                    else
                    {
                        var shipSpot = ship.GetSpotForContainer(ship.Width - xPos, yPos, container);
                        shipSpot.AddContainer(container);
                        sideSwitch = false;
                    }
                    xPos++;
                }
                else xPos = 0;
            }
        }


        public void FillRow(List<Container> containers, List<Position> spots)
        {
            //sorting List low high, low+index, High-index
            var index = 0;
            var spotsSorted = new List<Position>();
            while (spotsSorted.Count < spots.Count)
            {
                if (spotsSorted.Count == spots.Count) break;
                spotsSorted.Add(spots[0 + index]);

                if (spotsSorted.Count == spots.Count) break;
                spotsSorted.Add(spots.Where(spot => spot.XPos == _ship.Width - index).ToList().First());
                index++;
            }

            foreach (var container in containers)
            {
                for (var spotIndex = 0; spotIndex < spotsSorted.Count; spotIndex++)
                {
                    if (container.Weight + spot.Weight <= 120)
                    {
                        spot.AddContainer(container);
                        _ship.AddContainerToShip(container);
                        break;
                    }
                }
            }
        }

        public void AddValuableContainers()
        {

        }




    }
}



