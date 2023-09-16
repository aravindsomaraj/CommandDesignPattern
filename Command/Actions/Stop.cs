using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Command.Actions
{
    /// <summary>
    /// Represents a command to stop a car.
    /// </summary>
    public class Stop : ICommand
    {
        private readonly Car _car;

        /// <summary>
        /// Initializes a new instance of the <see cref="Stop"/> class.
        /// </summary>
        /// <param name="car">The car to be stopped.</param>
        public Stop(Car car)
        {
            _car = car;
        }

        /// <summary>
        /// Executes the command to stop the car.
        /// </summary>
        public void Execute()
        {
            _car.Stop();
        }
    }
}
