using Rover.Domain.Directions;

namespace Rover.Domain
{
    public interface IRoverMovementBehaviour
    {
        bool CanExecute(Command command);

        IDirection Execute(IDirection direction);
    }
}
