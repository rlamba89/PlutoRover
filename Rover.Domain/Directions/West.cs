namespace Rover.Domain.Directions
{
    public class West : IDirection
    {
        private ICardinalPoints _cardinalDirection { get; }

        public West(ICardinalPoints cardinalDirection)
        {
            _cardinalDirection = cardinalDirection;
        }

        public IDirection MoveBackward()
        {
            _cardinalDirection.MoveXCordinateForward();
            return new West(_cardinalDirection);
        }

        public IDirection MoveForward()
        {
            _cardinalDirection.MoveXCordinateBackward();
            return new West(_cardinalDirection);
        }

        public IDirection SpinLeft()
        {
            return new South(_cardinalDirection);
        }

        public IDirection SpinRight()
        {
            return new North(_cardinalDirection);
        }

        public override string ToString()
        {
            return "W";
        }
    }
}
