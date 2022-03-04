using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rover.Domain.Directions;
using System.Collections.Generic;

namespace Rover.Domain.Tests
{
    [TestClass]
    public class PlutoRoverTest
    {
        private PlutoRover _plutoRover;

        [TestInitialize]
        public void Initialize()
        {
            var cardinalPoints = new CardinalPoints(0, 0, 100, 100);

            _plutoRover = new PlutoRover(new List<IRoverMovementBehaviour>
            {
                new LeftSpinRover(),
                new RightSpinRover(),
                new MoveForwardRover(),
                new MoveBackwardRover()
            }, cardinalPoints, new North(cardinalPoints));
        }

        [TestMethod]
        public void Rover_DefaultPosition_ShouldBeSet()
        {
            Assert.AreEqual(_plutoRover._cardinalPoints.XCordinate, 0);
            Assert.AreEqual(_plutoRover._cardinalPoints.YCordinate, 0);
            Assert.AreEqual("N", _plutoRover._direction.ToString());
        }

        [DataRow("F", 0, 1, "N")]
        [DataRow("FF", 0, 2, "N")]
        [DataRow("FFR", 0, 2, "E")]
        [DataRow("FFRFF", 2, 2, "E")]
        [DataRow("FFRFFR", 2, 2, "S")]
        [DataRow("FFRFFRF", 2, 1, "S")]
        [DataRow("FFRFFRFR", 2, 1, "W")]
        [DataRow("FFRFFRFRF", 1, 1, "W")]
        [DataRow("FFRFFRFRFL", 1, 1, "S")]
        [DataRow("FFRFFRFRFLB", 1, 2, "S")]
        [DataRow("FFRFFRFRFLBL", 1, 2, "E")]
        [DataRow("FFRFFRFRFLBLB", 0, 2, "E")]
        [DataRow("FFRFFRFRFLBLBL", 0, 2, "N")]
        [DataRow("FFRFFRFRFLBLBLB", 0, 1, "N")]
        [DataRow("FFRFFRFRFLBLBLBL", 0, 1, "W")]
        [DataRow("FFRFFRFRFLBLBLBLB", 1, 1, "W")]
        [DataTestMethod]
        public void GivenACommand_Rover_ShoudMoveTo_ExpectedPosition(string command, int expectedXCordinates, int expectedYCordinates, string expectedDirection)
        {
            _plutoRover.Move(command);

            Assert.AreEqual(expectedXCordinates, _plutoRover._cardinalPoints.XCordinate);
            Assert.AreEqual(expectedYCordinates, _plutoRover._cardinalPoints.YCordinate);
            Assert.AreEqual(expectedDirection, _plutoRover._direction.ToString());
        }
    }
}
