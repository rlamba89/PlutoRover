namespace Rover.Domain.Directions
{
    public interface IDirection
    {
        IDirection MoveBackward();
        IDirection MoveForward();
        IDirection SpinLeft();
        IDirection SpinRight();
    }
}