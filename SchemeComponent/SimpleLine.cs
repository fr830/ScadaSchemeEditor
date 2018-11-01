using System;
using System.Drawing;

namespace Scheme.SchemeComponent
{
    /// <summary>
    /// Simple line.
    /// </summary>
    [Serializable]
    public class SimpleLine: BaseSchemeComponent
    {
        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>The weight.</value>
        public double Weight { get; set; }

        /// <summary>
        /// Gets or sets the start position.
        /// </summary>
        /// <value>The start position.</value>
        public Point StartPosition { get; set; }

        /// <summary>
        /// Gets or sets the end position.
        /// </summary>
        /// <value>The end position.</value>
        public Point EndPosition { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Scheme.SchemeComponent.SimpleLine"/> class.
        /// </summary>
        public SimpleLine()
            :base()
        {
            Name = "NewSimpleLine";
            StartPosition = Location;
            EndPosition = new Point(Location.X + base.ComponentSize.Width, Location.Y);
        }
    }
}
