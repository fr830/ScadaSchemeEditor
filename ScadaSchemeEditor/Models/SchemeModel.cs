using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Scheme;
using System.IO;

namespace ScadaSchemeEditor.Models
{
    public class SchemeModel
    {
        /// <summary>
        /// Gets or sets the scheme document path.
        /// </summary>
        /// <value>The scheme document path.</value>
        public string SchemeDocumentPath { get; set; }

        /// <summary>
        /// The current scheme.
        /// </summary>
        SchemeDocument CurrentScheme;

        /// <summary>
        /// Create this instance.
        /// </summary>
        public void Create()
        {
            CurrentScheme = new SchemeDocument();
        }

        /// <summary>
        /// Read this instance.
        /// </summary>
        public void Read()
        {
            try{
                // ToDo: implement scheme reading
            }
            catch (Exception ex){
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Update this instance.
        /// </summary>
        public void Update()
        {

            // ToDo: implement scheme updating
        }

        public void Delete()
        {
            // ToDo: implement scheme deleting
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get => CurrentScheme.DocumentName;
            set { CurrentScheme.DocumentName = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ScadaSchemeEditor.Models.SchemeViewModel"/> class.
        /// </summary>
        public SchemeModel()
        {
            SchemeDocumentPath = AppDirectories.DefaultPath;
            Create();
        }
    }
}
