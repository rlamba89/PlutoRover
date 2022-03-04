namespace Rover.Domain.Directions
{
    public class East : IDirection
    {
        private ICardinalPoints _cardinalPoints { get; }

        public East(ICardinalPoints cardinalDirection)
        {
            _cardinalPoints = cardinalDirection;
        }

        public IDirection MoveBackward()
        {
            _cardinalPoints.MoveXCordinateBackward();
            return new East(_cardinalPoints);
        }

        public IDirection MoveForward()
        {
            _cardinalPoints.MoveXCordinateForward();
            return new East(_cardinalPoints);
        }

        public IDirection SpinLeft()
        {
            return new North(_cardinalPoints);
        }

        public IDirection SpinRight()
        {
            return new South(_cardinalPoints);
        }

        public override string ToString()
        {
            return "E";
        }
    }
}
