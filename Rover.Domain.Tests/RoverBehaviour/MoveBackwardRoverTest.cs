using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Rover.Domain.Directions;

namespace Rover.Domain.Tests.RoverBehaviour
{
    [TestClass]
    public class MoveBackwardRoverTest
    {
        private IRoverMovementBehaviour _roverMovementBehaviour;
        private Mock<IDirection> _direction;

        [TestInitialize]
        public void Initialize()
        {
            _roverMovementBehaviour = new MoveBackwardRover();
            _direction = new Mock<IDirection>();
        }

        [DataRow("l", false)]
        [DataRow("r", false)]
        [DataRow("f", false)]
        [DataRow("b", true)]
        [DataRow("B", true)]
        [DataTestMethod]
        public void CanExecute_ForLeftCommand_ShouldReturnTrue(string command, bool expectedResult)
        {
           Assert.AreEqual(expectedResult, _roverMovementBehaviour.CanExecute(new Command(command)));
        }

        [TestMethod]
        public void Execute__ShouldInvoke_MoveBackwardMethod()
        {
            _roverMovementBehaviour.Execute(_direction.Object);

            _direction.Verify(a => a.MoveBackward(), Times.Once);
        }
    }
}
