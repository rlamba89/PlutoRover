using Rover.Domain.Directions;

namespace Rover.Domain
{
    public class MoveBackwardRover : IRoverMovementBehaviour
    {
        private const string Backward = "B";

        public bool CanExecute(Command command)
        {
            return (command.ToString() == Backward);
        }

        public IDirection Execute(IDirection direction)
        {
            return direction.MoveBackward();
        }
    }
}
