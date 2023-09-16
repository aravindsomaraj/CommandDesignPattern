using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{

    /// <summary>
    /// Represents a point in a two-dimensional space with X and Y coordinates.
    /// </summary>
    public class Point
    {

        /// <summary>
        /// Gets/sets the X-coordinate of the point.
        /// </summary>
        public int X {  get; set; }

        /// <summary>
        /// Gets/sets the Y-coordinate of the point.
        /// </summary>
        public int Y { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class with specified X and Y coordinates.
        /// </summary>
        /// <param name="x">The X-coordinate of the point.</param>
        /// <param name="y">The Y-coordinate of the point.</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        /**
        /// <summary>
        /// Returns a string representation of the point in the format "(X,Y)".
        /// </summary>
        /// <returns>A string representing the point's coordinates.</returns>
        public override string ToString()
        {
            return $"({X},{Y})";
        }
        **/
    }
}
