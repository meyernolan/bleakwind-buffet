/*
 * Author: Nolan Meyer
 * Class name: ErrorModel.cshtml.cs
 * Purpose: Class for helping the ErrorModel.cshtml class
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class ErrorModel : PageModel
    {
        /// <summary>
        /// Gets and sets the prooperty RequestId
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Proprty for whether the RequestId is shown.
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        /// <summary>
        /// An ILogger of ErrorModels
        /// </summary>
        private readonly ILogger<ErrorModel> _logger;

        /// <summary>
        /// Constructor for the ErrorModel
        /// </summary>
        /// <param name="logger">variable for setting the private logger variable</param>
        public ErrorModel(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Method for getting something.
        /// </summary>
        public void OnGet()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }
    }
}
