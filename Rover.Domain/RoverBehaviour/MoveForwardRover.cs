using Rover.Domain.Directions;

namespace Rover.Domain
{
    public class MoveForwardRover : IRoverMovementBehaviour
    {
        private const string Forward = "F";

        public bool CanExecute(Command command)
        {
            return (command.ToString() == Forward);
        }

        public IDirection Execute(IDirection direction)
        {
            return direction.MoveForward();
        }
    }
}
