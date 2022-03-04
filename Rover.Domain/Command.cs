using System;

namespace Rover.Domain
{
    public class Command
    {
        public Command(string command)
        {
            if (string.IsNullOrWhiteSpace(command) || string.IsNullOrEmpty(command))
            {
                throw new ArgumentException("command can not be null or empty", nameof(command));
            }
            _command = command.ToUpper();
        }

        private string _command;

        public override string ToString()
        {
            return _command.ToUpper();
        }
    }

}
