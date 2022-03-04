using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Rover.Domain.Directions;

namespace Rover.Domain.Tests.RoverBehaviour
{
    [TestClass]
    public class MoveForwardRoverTest
    {
        private IRoverMovementBehaviour _roverMovementBehaviour;
        private Mock<IDirection> _direction;

        [TestInitialize]
        public void Initialize()
        {
            _roverMovementBehaviour = new MoveForwardRover();
            _direction = new Mock<IDirection>();
        }

        [DataRow("l", false)]
        [DataRow("r", false)]
        [DataRow("f", true)]
        [DataRow("F", true)]
        [DataRow("b", false)]
        [DataTestMethod]
        public void CanExecute_ForLeftCommand_ShouldReturnTrue(string command, bool expectedResult)
        {
           Assert.AreEqual(expectedResult, _roverMovementBehaviour.CanExecute(new Command(command)));
        }

        [TestMethod]
        public void Execute__ShouldInvoke_MoveForwardMethod()
        {
            _roverMovementBehaviour.Execute(_direction.Object);

            _direction.Verify(a => a.MoveForward(), Times.Once);
        }
    }
}
