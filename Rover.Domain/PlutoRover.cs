using Rover.Domain.Directions;
using System.Collections.Generic;
using System.Linq;

namespace Rover.Domain
{
    public class PlutoRover
    {
        //public CardinalPoints _cadinalDirection;
        public IDirection _direction;
        private readonly IEnumerable<IRoverMovementBehaviour> _roverMovementHandler;

        public ICardinalPoints _cardinalPoints { get; }

        public PlutoRover(IEnumerable<IRoverMovementBehaviour> roverMovementHandler, ICardinalPoints cardinalPoints, IDirection direction)
        {
            _cardinalPoints = cardinalPoints;
            //_cadinalDirection = new CardinalPoints(0, 0, 100, 100);
            //_direction = new North(_cardinalPoints);
            _direction = direction;
            _roverMovementHandler = roverMovementHandler;
        }

        public void Move(string commands)
        {
            foreach (var command in commands)
            {
               _direction = _roverMovementHandler.FirstOrDefault(a => a.CanExecute(new Command(command.ToString()))).Execute(_direction);
            }
        }
    }
}
