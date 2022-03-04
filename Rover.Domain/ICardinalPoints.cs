namespace Rover.Domain
{
    public interface ICardinalPoints
    {
        int XCordinate { get; }

        int YCordinate { get; }

        int GridXCordinates { get;}

        int GridYCordinates { get;}

        void MoveXCordinateForward();

        void MoveXCordinateBackward();

        void MoveYCordinateForward();

        void MoveYCordinateBackward();
    }
}