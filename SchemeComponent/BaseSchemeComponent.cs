using System;
using System.Drawing;

namespace Scheme.SchemeComponent
{
    /// <summary>
    /// Scheme base component.
    /// </summary>
    [Serializable]
    public abstract class BaseSchemeComponent
    {
        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>The location.</value>
        public Point Location { get; set; }

        /// <summary>
        /// Gets or sets the size of the component.
        /// </summary>
        /// <value>The size of the component.</value>
        public Size ComponentSize { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the component group.
        /// </summary>
        /// <value>The group.</value>
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Scheme.SchemeComponent.BaseSchemeComponent"/> class.
        /// </summary>
        public BaseSchemeComponent()
        {
            Location = new Point(10, 10);
            ComponentSize = new Size(50, 50);
            Id = Guid.NewGuid();
            Group = "Other";
            Name = "NewComponent";
        }
    }
}
