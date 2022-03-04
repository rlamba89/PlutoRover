using Rover.Domain.Directions;

namespace Rover.Domain
{
    public class RightSpinRover : IRoverMovementBehaviour
    {
        private const string Right = "R";

        public bool CanExecute(Command command)
        {
            return (command.ToString() == Right);
        }

        public IDirection Execute(IDirection direction)
        {
            return direction.SpinRight();
        }
    }
}
