using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Actions
{

    /// <summary>
    /// Represents a command to move a car forward.
    /// </summary>
    public class MoveForward : ICommand
    {
        private readonly Car _car;


        /// <summary>
        /// Initializes a new instance of the <see cref="MoveForward"/> class.
        /// </summary>
        /// <param name="car">The car to be moved forward.</param>
        public MoveForward(Car car)
        {
            _car = car;
        }

        /// <summary>
        /// Executes the command to move the car forward.
        /// </summary>
        public void Execute()
        {
            _car.MoveForward();
        }
    }
}
