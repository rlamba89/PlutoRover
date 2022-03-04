using Rover.Domain.Directions;

namespace Rover.Domain
{
    public class LeftSpinRover : IRoverMovementBehaviour
    {
        private const string Left = "L";

        public bool CanExecute(Command command)
        {
            return (command.ToString() == Left);
        }

        public IDirection Execute(IDirection direction)
        {
            return direction.SpinLeft();
        }
    }
}

