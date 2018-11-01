using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScadaSchemeEditor.Models;

namespace ScadaSchemeEditor.Controllers
{
    public class SchemeController : Controller
    {
        private SchemeModel Model = null;

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [ModelBinder]
        public string Id { get; set; }

        // GET: /<controller>/
        public IActionResult Index()
        {
            Model = new SchemeModel(){
                Name = "Test Scheme"
            };
            return View("Index", Model);
        }
    }
}
