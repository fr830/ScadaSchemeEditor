using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ScadaSchemeEditor.Models
{
    public class SchemeModel
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ScadaSchemeEditor.Models.SchemeViewModel"/> class.
        /// </summary>
        public SchemeModel()
        {
            Name = "NewScheme";
        }
    }
}
