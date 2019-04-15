using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Container_Vervoer.Models
{
    internal class Ship
    {
        private List<Position> _positions;
        private List<Container> _containers;

        public Ship(int width, int length, double maxCargoWeight)
        {
            this.Width = width;
            this.Length = length;
            this.MaxWeight = maxCargoWeight;
            _positions = new List<Position>();
            _containers = new List<Container>();
            AddGridToShip();
        }

        public int Width { get; private set; }
        public int Length { get; private set; }
        public double MaxWeight { get; private set; }

        private void AddGridToShip()
        {
            for (var y = 0; y < Length; y++)
            {
                for (var x = 0; x < Width; x++)
                {
                    _positions.Add(new Position(x, y));
                }
            }
        }

        public IReadOnlyList<Container> GetShipsContainers()
        {
            _containers = new List<Container>();
            foreach (var position in _positions)
            {
                _containers.AddRange(position.GetContainers());
            }
            return _containers;
        }

        public IEnumerable<Position> GetShipPositionsFromLightestSide()
        {
            var leftPositions = _positions.Where(pos => pos.XPos <= (Math.Round(Width / 2.0))).ToList();
            var rightPositions = _positions.Where(pos => pos.XPos > (Math.Round(Width / 2.0))).ToList();
            return(GetTotalPositionsWeight(leftPositions) < GetTotalPositionsWeight(rightPositions)) ? leftPositions:rightPositions;
        }

        private static double GetTotalPositionsWeight(IEnumerable<Position> positions)
        {
           return positions.Sum(position => position.Weight);
        }


        public IEnumerable<Position> GetAllPositions()
        {
            return _positions;
        }

    }
}
