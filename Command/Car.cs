using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// Represents a car that can be controlled through commands.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Gets/sets the current position of the car.
        /// </summary>
        public Point Position { get; set; } = new Point(0, 0);

        /// <summary>
        /// Variable to store the state of motion of the car.
        /// </summary>
        public bool _isMoving = false;

        /// <summary>
        /// Moves the car forward.
        /// </summary>
        public void MoveForward()
        {
            _isMoving = true;
            Position.Y++;
            /**
            Console.WriteLine("The car moves forward.");
            Console.WriteLine(Position);
            **/
        }

        /// <summary>
        /// Moves the car to the left.
        /// </summary>
        public void MoveLeft()
        {
            _isMoving = true;
            Position.X--;
            /**
            Console.WriteLine("The car moves left.");
            Console.WriteLine(Position);
            **/
        }

        /// <summary>
        /// Moves the car to the right.
        /// </summary>
        public void MoveRight()
        {
            _isMoving = true;
            Position.X++;
            /**
            Console.WriteLine("The car moves right.");
            Console.WriteLine(Position);
            **/
        }

        /// <summary>
        /// Stops the car (if moving), else moves backwards.
        /// </summary>
        public void Stop()
        {
            if (_isMoving)
            {
                // Console.WriteLine("The car stops.");
                _isMoving = false;
            }
            else
            {
                Position.Y--;
                // Console.WriteLine("The car moves backward.");
            }
            // Console.WriteLine(Position);
        }
    }
}
