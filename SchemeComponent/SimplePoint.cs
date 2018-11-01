using System.Drawing;
using System;

namespace Scheme.SchemeComponent
{
    /// <summary>
    /// Simple point.
    /// </summary>
    [Serializable]
    public class SimplePoint: BaseSchemeComponent
    {
        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>The color.</value>
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Scheme.SchemeComponent.SimplePoint"/> is filled.
        /// </summary>
        /// <value><c>true</c> if filled; otherwise, <c>false</c>.</value>
        public bool Filled { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Scheme.SchemeComponent.SimplePoint"/> class.
        /// </summary>
        public SimplePoint()
            :base()
        {
            Color = "#000000";
            Weight = 1.0;
            Filled = true;
            Group = "Simple";
            Name = "NewSimplePoint";
        }
    }
}
