using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rover.Domain.Exception;

namespace Rover.Domain.Tests
{
    [TestClass]
    public class CardinalPointsTest
    {
        private ICardinalPoints _cardinalPoints;
        private int actualXCordinate, actualYCordinate;

        [TestInitialize]
        public void Initialize()
        {
            actualXCordinate = 0;
            actualYCordinate = 0;
        }

        [TestMethod]
        public void Constructor_ShouldSetCordinatesCorrectly()
        {
            _cardinalPoints = new CardinalPoints(0,0, 100, 200);

            Assert.AreEqual(0, _cardinalPoints.XCordinate);
            Assert.AreEqual(0, _cardinalPoints.YCordinate);
            Assert.AreEqual(100, _cardinalPoints.GridXCordinates);
            Assert.AreEqual(200, _cardinalPoints.GridYCordinates);
        }

        [TestMethod]
        public void GivenCardinalPoints_MoveYCordinateForward_ShouldIncrementYCordinate()
        {
            _cardinalPoints = new CardinalPoints(actualXCordinate, actualYCordinate, 100, 100);
            _cardinalPoints.MoveYCordinateForward();

            Assert.AreEqual(actualXCordinate, _cardinalPoints.XCordinate);
            Assert.AreEqual(actualYCordinate + 1, _cardinalPoints.YCordinate);
        }

        [TestMethod]
        public void GivenCardinalPoints_MoveYCordinateForward_OutsideGridCardinalPoints_ShouldThrowCantMoveRoverException()
        {
            actualYCordinate = 100;

            _cardinalPoints = new CardinalPoints(actualXCordinate, actualYCordinate, 100, 100);
            
            Assert.ThrowsException<CardinalPointsOutOfRangeException>(() => _cardinalPoints.MoveYCordinateForward());
        }

        [TestMethod]
        public void GivenCardinalPoints_MoveYCordinatBackward_ShouldDecrementYCordinate()
        {
            actualYCordinate = 2;
            _cardinalPoints = new CardinalPoints(actualXCordinate, actualYCordinate, 100, 100);

            _cardinalPoints.MoveYCordinateBackward();

            Assert.AreEqual(actualXCordinate, _cardinalPoints.XCordinate);
            Assert.AreEqual(actualYCordinate - 1, _cardinalPoints.YCordinate);
        }

        [TestMethod]
        public void GivenCardinalPoints_MoveYCordinateBackward_OutsideGridCardinalPoints_ShouldThrowCantMoveRoverException()
        {
            _cardinalPoints = new CardinalPoints(actualXCordinate, actualYCordinate, 100, 100);

            Assert.ThrowsException<CardinalPointsOutOfRangeException>(() => _cardinalPoints.MoveYCordinateBackward());
        }

        [TestMethod]
        public void GivenCardinalPoints_MoveXCordinatForward_ShouldIncrementXCordinate()
        {
            _cardinalPoints = new CardinalPoints(actualXCordinate, actualYCordinate, 100, 100);

            _cardinalPoints.MoveXCordinateForward();

            Assert.AreEqual(actualXCordinate + 1, _cardinalPoints.XCordinate);
            Assert.AreEqual(actualYCordinate, _cardinalPoints.YCordinate);
        }

        [TestMethod]
        public void GivenCardinalPoints_MoveXCordinateForward_OutsideGridCardinalPoints_ShouldThrowCantMoveRoverException()
        {
            actualXCordinate = 100;

            _cardinalPoints = new CardinalPoints(actualXCordinate, actualYCordinate, 100, 100);

            Assert.ThrowsException<CardinalPointsOutOfRangeException>(() => _cardinalPoints.MoveXCordinateForward());
        }

        [TestMethod]
        public void GivenCardinalPoints_MoveXCordinatBackward_ShouldDecrementXCordinate()
        {
            actualXCordinate = 2;
            _cardinalPoints = new CardinalPoints(actualXCordinate, actualYCordinate, 100, 100);

            _cardinalPoints.MoveXCordinateBackward();

            Assert.AreEqual(actualXCordinate - 1, _cardinalPoints.XCordinate);
            Assert.AreEqual(actualYCordinate, _cardinalPoints.YCordinate);
        }

        [TestMethod]
        public void GivenCardinalPoints_MoveXCordinateBackward_OutsideGridCardinalPoints_ShouldThrowCantMoveRoverException()
        {
            _cardinalPoints = new CardinalPoints(actualXCordinate, actualYCordinate, 100, 100);

            Assert.ThrowsException<CardinalPointsOutOfRangeException>(() => _cardinalPoints.MoveXCordinateBackward());
        }
    }
}
