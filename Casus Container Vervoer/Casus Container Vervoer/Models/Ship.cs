using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Casus_Container_Vervoer.Models
{
    public class Ship
    {
        private readonly List<Position> _positions;
        private List<Container> _containers;
        private const double MaxBalanceDifference = 20;

        public Ship(int width, int length, double minCargoWeight)
        {
            this.Width = width;
            this.Length = length;
            this.MinWeight = minCargoWeight;
            _positions = new List<Position>();
            _containers = new List<Container>();
            AddGridToShip();
        }

        public int Width { get; private set; }
        public int Length { get; private set; }
        public double MinWeight { get; private set; }

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
                _containers.AddRange(position.GetContainers().Select(positionContainer => new Container(positionContainer.Weight, positionContainer.FreightType)));              
            }
            return _containers;
        }

        public IEnumerable<Position> GetShipPositionsFromLightestSide()
        {
            List<Position> leftPositions;
            List<Position> rightPositions;
            if (Width % 2 == 0)
            {
                leftPositions = _positions.Where(pos => pos.XPos < (Width/2)).ToList();
                rightPositions = _positions.Where(pos => pos.XPos >= (Width/2)) .ToList();
            }
            else
            {
                leftPositions = _positions.Where(pos => pos.XPos < (Math.Round(Width / 2.0))).ToList();
                rightPositions = _positions.Where(pos => pos.XPos >= (Math.Round(Width / 2.0))).ToList();
            }

           
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

        public void AddContainerToShipPosition(Container container, int xPos, int yPos)
        {
            var position = _positions.First(pos => pos.XPos == xPos && pos.YPos == yPos);
            position.AddContainer(container);
        }

        public bool BalanceIsOk()
        {
            double leftPositions;
            double rightPositions;
            if (Width % 2 == 0)
            {
                leftPositions = _positions.Where(pos => pos.XPos < (Width / 2)).ToList().Sum(pos => pos.Weight);
                rightPositions = _positions.Where(pos => pos.XPos >= (Width / 2)).ToList().Sum(pos => pos.Weight);
            }
            else
            {
                leftPositions = _positions.Where(pos => pos.XPos < (Math.Round(Width / 2.0))).ToList().Sum(pos => pos.Weight);
                rightPositions = _positions.Where(pos => pos.XPos >= (Math.Round(Width / 2.0))).ToList().Sum(pos => pos.Weight);
            }
            var difference = ((leftPositions - rightPositions) / ((leftPositions + rightPositions) / 2)) * 100;
            return difference <= MaxBalanceDifference && difference>= (-MaxBalanceDifference);
        }

    }
}
