
using Command;
using Command.Actions;
using System.ComponentModel.DataAnnotations;

namespace CommandUnitTest
{
    /// <summary>
    /// Represents a unit test class for testing the behavior of the Car and Command classes.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Tests the behavior of moving the car forward using the MoveForward command.
        /// </summary>
        [TestMethod]
        public void MovingForwardTest()
        {
            Car car = new();

            int initialY = car.Position.Y;

            ICommand moveForwardCommand = new MoveForward(car);

            moveForwardCommand.Execute();

            Assert.AreEqual(initialY + 1, car.Position.Y);
        }

        /// <summary>
        /// Tests the behavior of moving the car to the left using the MoveLeft command.
        /// </summary>
        [TestMethod]
        public void MovingLeftTest()
        {
            Car car = new();

            int initialX = car.Position.X;

            ICommand moveLeftCommand = new MoveLeft(car);

            moveLeftCommand.Execute();

            Assert.AreEqual(initialX - 1, car.Position.X);
        }

        /// <summary>
        /// Tests the behavior of moving the car to the right using the MoveRight command.
        /// </summary>
        [TestMethod]
        public void MovingRightTest()
        {
            Car car = new();

            int initialX = car.Position.X;

            ICommand moveRightCommand = new MoveRight(car);

            moveRightCommand.Execute();

            Assert.AreEqual(initialX + 1, car.Position.X);
        }

        /// <summary>
        /// Tests the behavior of stopping the car using the Stop command.
        /// </summary>
        [TestMethod]
        public void StopTest()
        {
            Car car = new();

            int initialY = car.Position.Y;
            int initialX = car.Position.X;

            ICommand stopCommand = new Stop(car);

            stopCommand.Execute();

            Assert.AreEqual(initialX, car.Position.X);

            if (car._isMoving == true)
            {
                Assert.AreEqual( initialY , car.Position.Y );
            }
            else
            {
                Assert.AreEqual( initialY - 1 , car.Position.Y );
            }
        }

        /// <summary>
        /// Tests the behavior of moving the car forward directly (without commands).
        /// </summary>
        [TestMethod]
        public void MovingForwardDirectTest()
        {
            Car car = new();

            int initialY = car.Position.Y;

            car.MoveForward();

            Assert.AreEqual(initialY + 1, car.Position.Y);
        }

        /// <summary>
        /// Tests the behavior of moving the car to the left directly (without commands).
        /// </summary>
        [TestMethod]
        public void MovingLeftDirectTest()
        {
            Car car = new();

            int initialX = car.Position.X;

            car.MoveLeft();

            Assert.AreEqual(initialX - 1, car.Position.X);
        }

        /// <summary>
        /// Tests the behavior of moving the car to the right directly (without commands).
        /// </summary>
        [TestMethod]
        public void MovingRightDirectTest()
        {
            Car car = new();

            int initialX = car.Position.X;

            car.MoveRight();

            Assert.AreEqual(initialX + 1, car.Position.X);
        }

        /// <summary>
        /// Tests the behavior of stopping the car directly (without commands).
        /// </summary>
        [TestMethod]
        public void StopDirectTest()
        {
            Car car = new();

            int initialY = car.Position.Y;
            int initialX = car.Position.X;

            car.Stop();

            Assert.AreEqual(initialX, car.Position.X);

            if (car._isMoving == true)
            {
                Assert.AreEqual( initialY , car.Position.Y );
            }
            else
            {
                Assert.AreEqual( initialY - 1 , car.Position.Y );
            }
        }
    }
}
