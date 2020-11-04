/*
 * Author: Nolan Meyer
 * Class name: IndexModel.cshtml.cs
 * Purpose: Class for helping the IndexModel.cshtml class
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// Minimum price
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; } = null;

        /// <summary>
        /// Max price
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; } = null;

        /// <summary>
        /// Minimum amount of calories
        /// </summary>
        [BindProperty]
        public int? CaloriesMin { get; set; } = null;

        /// <summary>
        /// Max amount of calories
        /// </summary>
        [BindProperty]
        public int? CaloriesMax { get; set; } = null;

        /// <summary>
        /// The filtered Order items
        /// </summary>
        public string[] OrderItems { get; set; }

        /// <summary>
        /// An ILogger of IndexModels
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
        /// Terms to search for
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// Items in the search
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; set; } 

        /// <summary>
        /// Method for getting something.
        /// </summary>
        public void OnGet(double? PriceMax, double? PriceMin, int? CaloriesMin, int? CaloriesMax)
        {
            this.PriceMax = PriceMax;
            this.PriceMin = PriceMin;
            this.CaloriesMax = CaloriesMax;
            this.CaloriesMin = CaloriesMin;
            SearchTerms = Request.Query["SearchTerms"];
            Items = Menu.Search(Items, SearchTerms);
            OrderItems = Request.Query["OrderItems"];
            Items = Menu.FilterByCategory(Items, OrderItems);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
        }
    }
}
