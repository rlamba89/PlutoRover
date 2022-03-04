using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Rover.Domain.Directions;

namespace Rover.Domain.Tests.RoverBehaviour
{
    [TestClass]
    public class rightSpinRoverTest
    {
        private IRoverMovementBehaviour _roverMovementBehaviour;
        private Mock<IDirection> _direction;

        [TestInitialize]
        public void Initialize()
        {
            _roverMovementBehaviour = new RightSpinRover();
            _direction = new Mock<IDirection>();
        }

        [DataRow("l", false)]
        [DataRow("r", true)]
        [DataRow("R", true)]
        [DataRow("f", false)]
        [DataRow("b", false)]
        [DataTestMethod]
        public void CanExecute_ForLeftCommand_ShouldReturnTrue(string command, bool expectedResult)
        {
           Assert.AreEqual(expectedResult, _roverMovementBehaviour.CanExecute(new Command(command)));
        }

        [TestMethod]
        public void Execute__ShouldInvoke_SpintRightMethod()
        {
            _roverMovementBehaviour.Execute(_direction.Object);

            _direction.Verify(a => a.SpinRight(), Times.Once);
        }
    }
}
