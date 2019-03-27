using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Container_Vervoer.Models
{
    internal class Ship
    {
        private List<ShipSpot> _spots;
        private List<Container> _containers;

        public Ship(int width, int length, double maxCargoWeight)
        {
            this.Width = width;
            this.Length = length;
            this.MaxWeight = maxCargoWeight;
            _spots = new List<ShipSpot>();
            _containers = new List<Container>();
            AddAllShipSpots();
        }

        private void AddAllShipSpots()
        {
            for (var y = 0; y < Length; y++)
            {
                for (var x = 0; x < Width; x++)
                {
                    _spots.Add(new ShipSpot(x, y));
                }
            }
        }

        //Add data protection later
        public List<ShipSpot> GetSpots()
        {
            return _spots;
        }

        //
        public ShipSpot GetSpotForContainer(int xPos,int yPos,Container container)
        {
            try
            {
                return _spots
                    .Where(spot => spot.XPos == xPos && spot.YPos == yPos)
                    .ToList().First();
            }
            catch
            {
                return _spots
                    .Where(spot => spot.YPos == yPos)
                    .ToList().First();
            }
        }
        //
        public ShipSpot GetSpot(int xPos, int yPos)
        {
            return _spots.First(spot => spot.XPos == xPos && spot.YPos == yPos);
        }


        public List<ShipSpot> GetShipSpots(int yPos)
        {
            return _spots.Where(spot => spot.YPos == yPos).OrderBy(spot=>spot.YPos).ToList();
        }

        public int Width { get; private set; }
        public int Length { get; private set; }
        public double MaxWeight { get; private set; }

        public IReadOnlyList<Container> GetShipsContainers()
        {
            _containers = new List<Container>();
            foreach (var spot in _spots)
            {
                _containers.AddRange(spot.GetContainers());
            }
            return _containers;
        }

        public void AddContainerToShip(Container container)
        {
            _containers.Add(container);
        }
    }
}
