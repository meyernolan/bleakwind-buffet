/*
 * Author: Nolan Meyer
 * Class name: IndexModel.cshtml.cs
 * Purpose: Class for helping the IndexModel.cshtml class
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// An ILogger of ErrorModels
        /// </summary>
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// IndexModel constructor
        /// </summary>
        /// <param name="logger">variable for setting the private logger variable</param>
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Method for getting something.
        /// </summary>
        public void OnGet()
        {

        }
    }
}
