using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Command.Actions
{
    /// <summary>
    /// Represents a command to move a car to the left.
    /// </summary>
    public class MoveLeft : ICommand
    {
        private readonly Car _car;

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveLeft"/> class.
        /// </summary>
        /// <param name="car">The car to be moved to the left.</param>
        public MoveLeft(Car car)
        {
            _car = car;
        }

        /// <summary>
        /// Executes the command to move the car to the left.
        /// </summary>
        public void Execute()
        {
            _car.MoveLeft();
        }
    }
}
