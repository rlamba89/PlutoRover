using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Rover.Domain.Directions;

namespace Rover.Domain.Tests.Directions
{
    [TestClass]
    public class WestTest
    {
        private Mock<ICardinalPoints> _cardinalPoints;
        private IDirection _direction;

        [TestInitialize]
        public void Initialize()
        {
            _cardinalPoints = new Mock<ICardinalPoints>();

            _direction = new West(_cardinalPoints.Object);
        }

        [TestMethod]
        public void MoveBackward_ShouldInvoke_MoveXCordinateForward()
        {
            var actualDirection = _direction.MoveBackward();

            _cardinalPoints.Verify(a => a.MoveXCordinateForward(), Times.Once);

            Assert.AreEqual(typeof(West), actualDirection.GetType());
        }

        [TestMethod]
        public void MoveForward_ShouldInvoke_MoveXCordinateBackward()
        {
            var actualDirection = _direction.MoveForward();

            _cardinalPoints.Verify(a => a.MoveXCordinateBackward(), Times.Once);

            Assert.AreEqual(typeof(West), actualDirection.GetType());
        }

        [TestMethod]
        public void SpinLeft_ShouldMoveRoverToNorth()
        {
            var actualDirection = _direction.SpinLeft();

            Assert.AreEqual(typeof(South), actualDirection.GetType());
        }

        [TestMethod]
        public void SpinRight_ShouldMoveRoverToSouth()
        {
            var actualDirection = _direction.SpinRight();

            Assert.AreEqual(typeof(North), actualDirection.GetType());
        }
    }
}
