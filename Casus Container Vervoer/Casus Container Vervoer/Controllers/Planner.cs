using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Casus_Container_Vervoer.Models.Helpers;

namespace Casus_Container_Vervoer.Models
{
    internal class Planner
    {
        private List<Container> _containers;
        private List<Ship> _ships;

        public Planner()
        {
            _containers = new List<Container>();
            _ships = new List<Ship>();
        }

        public void AddShip(int length, int width, int weight)
        {
            _ships.Add(new Ship(width, length, weight));
        }

        public void AddContainer(double containerWeight, string type)
        {
            var freightType = (Enums.FreightType)Enum.Parse(typeof(Enums.FreightType), type, true);
            _containers.Add(new Container(containerWeight, freightType));
        }

        //Note: add containers to ship as well to measure max weight has been reached and to check which containers are gonna be loaded onto the ship.
        //Note: weight comparison working (no control ship weight) if first row limit has been reached cooled container is not added
        public void Plan()
        {
            var ship = _ships[0];
            //step 1 add all cooled containers to the front y=0
            var cooledContainers = _containers
                .Where(container => container.FreightType.Equals(Enums.FreightType.Cooled)).OrderBy(cooler => cooler.Weight).ToList();
            FillRow(cooledContainers, ship, 0);

            //Step 2 fill the middle part with containers valuables and cooled can't be placed here.
            var standardContainers = _containers
                .Where(container => container.FreightType.Equals(Enums.FreightType.Standard)).OrderBy(standard => standard.Weight).ToList();
            for (var index = 0; index < ship.Width; index++)
            {
                FillRow(standardContainers, ship, 1, ship.Width - 1);
            }
            //Step 3 fill front with resting normal containers and valuables and fill back.
        }

        public IReadOnlyList<Container> GetShipContainers()
        {
           return _ships[0].GetShipsContainers();
        }

        //Note: add range from min to max YPosition
        //Note: Need to add a check if adding a container is still possible.
        //Mass filling for the center Rows.
        public void FillRow(List<Container> containers, Ship ship, int min, int max)
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


        //Defined Row Front for cooled containers as example.
        //public void FillRow(List<Container> containers, Ship ship, int yPos)
        //{
        //    var xPos = 0;
        //    var sideSwitch = false;
        //    foreach (var container in containers)
        //    {
        //        if (xPos<ship.Width)
        //        {
        //            if (sideSwitch == false)
        //            {
        //                var shipSpot = ship.GetSpotForContainer(xPos, yPos, container);
        //                shipSpot.AddContainer(container);
        //                sideSwitch = true;
        //            }
        //            else
        //            {
        //                var shipSpot = ship.GetSpotForContainer(ship.Width - xPos, yPos, container);
        //                shipSpot.AddContainer(container);
        //                sideSwitch = false;
        //            }
        //            xPos++;
        //        }
        //        else xPos = 0;
        //    }
        //}

        public void FillRow(List<Container> containers, Ship ship, int rowNumber)
        {
            var xPos = 0;
            var sideSwitch = false;
            foreach (var container in containers)
            {
                foreach (var spot in ship.GetShipSpots(rowNumber))
                {
                    if (sideSwitch == false && container.Weight+spot.Weight<=120)
                    {
                        spot.AddContainer(container);
                        ship.AddContainerToShip(container);
                        sideSwitch = true;
                    }
                    else if(sideSwitch == true && container.Weight + spot.Weight <= 120)
                    {
                        spot.AddContainer(container);
                        ship.AddContainerToShip(container);
                        sideSwitch = false;
                    }

                    xPos++;
                    if (xPos >= ship.Width)
                    {
                        xPos = 0;
                    }
                }
            }
        }
    }
}



