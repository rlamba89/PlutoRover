namespace Rover.Domain.Exception
{
    public class CardinalPointsOutOfRangeException : System.Exception
    {
        public CardinalPointsOutOfRangeException()
        {

        }

        public CardinalPointsOutOfRangeException(string message)
        : base(message)
        {
        }

        public CardinalPointsOutOfRangeException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
