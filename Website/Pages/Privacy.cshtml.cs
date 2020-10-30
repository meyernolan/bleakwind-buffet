/*
 * Author: Nolan Meyer
 * Class name: PrivacyModel.cshtml.cs
 * Purpose: Class for helping the PrivacyModel.cshtml class
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
    public class PrivacyModel : PageModel
    {
        /// <summary>
        /// An ILogger of ErrorModels
        /// </summary>
        private readonly ILogger<PrivacyModel> _logger;

        /// <summary>
        /// Constructor for PrivacyModel
        /// </summary>
        /// <param name="logger">variable for setting the private logger variable</param>
        public PrivacyModel(ILogger<PrivacyModel> logger)
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
