using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Command.Actions
{
    /// <summary>
    /// Represents a command to move a car to the right.
    /// </summary>
    public class MoveRight : ICommand
    {
        private readonly Car _car;

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveRight"/> class.
        /// </summary>
        /// <param name="car">The car to be moved to the right.</param>
        public MoveRight(Car car)
        {
            _car = car;
        }

        /// <summary>
        /// Executes the command to move the car to the right.
        /// </summary>
        public void Execute()
        {
            _car.MoveRight();
        }
    }
}
