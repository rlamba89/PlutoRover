namespace Rover.Domain.Directions
{
    public class North : IDirection
    {
        private ICardinalPoints _cardinalDirection { get; }

        public North(ICardinalPoints cardinalDirection)
        {
            _cardinalDirection = cardinalDirection;
        }

        public IDirection MoveBackward()
        {
            _cardinalDirection.MoveYCordinateBackward();
            return new North(_cardinalDirection);
        }

        public IDirection MoveForward()
        {
            _cardinalDirection.MoveYCordinateForward();
            return new North(_cardinalDirection);
        }

        public IDirection SpinLeft()
        {
            return new West(_cardinalDirection);
        }

        public IDirection SpinRight()
        {
            return new East(_cardinalDirection);
        }

        public override string ToString()
        {
            return "N";
        }
    }
}
