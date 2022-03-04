namespace Rover.Domain.Directions
{
    public class South : IDirection
    {
        private ICardinalPoints _cardinalDirection { get; }

        public South(ICardinalPoints cardinalDirection)
        {
            _cardinalDirection = cardinalDirection;
        }

        public IDirection MoveBackward()
        {
            _cardinalDirection.MoveYCordinateForward();
            return new South(_cardinalDirection);
        }

        public IDirection MoveForward()
        {
            _cardinalDirection.MoveYCordinateBackward();
            return new South(_cardinalDirection);
        }

        public IDirection SpinLeft()
        {
            return new East(_cardinalDirection);
        }

        public IDirection SpinRight()
        {
            return new West(_cardinalDirection);
        }

        public override string ToString()
        {
            return "S";
        }
    }
}
