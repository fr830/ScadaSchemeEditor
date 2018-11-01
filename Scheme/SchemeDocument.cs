using System;
using System.Collections;
using System.Collections.Generic;

namespace Scheme
{
    /// <summary>
    /// Scheme document.
    /// </summary>
    [Serializable]
    public class SchemeDocument
    {
        /// <summary>
        /// Gets or sets the name of the document.
        /// </summary>
        /// <value>The name of the document.</value>
        public string DocumentName { get; set; }

        /// <summary>
        /// Gets or sets the document author.
        /// </summary>
        /// <value>The document author.</value>
        public string DocumentAuthor { get; set; }

        /// <summary>
        /// Gets or sets the changed date.
        /// </summary>
        /// <value>The changed date.</value>
        public DateTime ChangedDate { get; set; }

        /// <summary>
        /// The components.
        /// </summary>
        private readonly List<SchemeComponent.BaseSchemeComponent> Components;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Scheme.SchemeDocument"/> class.
        /// </summary>
        public SchemeDocument()
        {
            DocumentName = Utils.DefaultSchemeDocumentName + Utils.DefaultSchemeDocumentExtension;
            DocumentAuthor = string.Empty;
            ChangedDate = DateTime.Now;
            Components = new List<SchemeComponent.BaseSchemeComponent>();
        }
    }
}
