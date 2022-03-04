using Rover.Domain.Exception;

namespace Rover.Domain
{
    public class CardinalPoints : ICardinalPoints
    {
        public CardinalPoints(int xCordinate, int yCordinate, int gridXCordinates, int gridYCordinates)
        {
            XCordinate = xCordinate;
            YCordinate = yCordinate;
            GridXCordinates = gridXCordinates;
            GridYCordinates = gridYCordinates;
        }
        
        public int XCordinate { get; private set; }

        public int YCordinate { get; private set; }

        public int GridXCordinates { get; private set; }
        
        public int GridYCordinates { get; private set; }

        public void MoveYCordinateForward()
        {
            if (YCordinate + 1 > GridYCordinates) throw new CardinalPointsOutOfRangeException();
            
            YCordinate += 1;
        }

        public void MoveXCordinateForward()
        {
            if (XCordinate + 1 > GridXCordinates) throw new CardinalPointsOutOfRangeException();

            XCordinate += 1;
        }

        public void MoveYCordinateBackward()
        {
            if (YCordinate - 1 < 0) throw new CardinalPointsOutOfRangeException();

            YCordinate -= 1;
        }

        public void MoveXCordinateBackward()
        {
            if (XCordinate - 1 < 0) throw new CardinalPointsOutOfRangeException();

            XCordinate -= 1;
        }
    }
}
