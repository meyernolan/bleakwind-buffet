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
using BleakwindBuffet.Data.Entrees;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

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
            List<IOrderItem> items = (List<IOrderItem>)Menu.FullMenu();
            // Search movie titles for the SearchTerms
            if (SearchTerms != null)
            {
                items = new List<IOrderItem>();
                string[] searchWords = SearchTerms.Split(' ');
                foreach (string str in searchWords)
                {
                    List<IOrderItem> temp = (List<IOrderItem>)Menu.FullMenu();
                    if (str != null)
                    {
                        items.AddRange(temp.Where(item => (item.Name != null && item.Name.Contains(str, StringComparison.InvariantCultureIgnoreCase)) || item.Description.Contains(str, StringComparison.InvariantCultureIgnoreCase)));
                    }
                }
            }
            Items = items;
            OrderItems = Request.Query["OrderItems"];
            foreach(string str in OrderItems)
            {
                if(str.Equals("Entree"))
                {
                    Items = Items.Where(item => item is Entree);
                }
                else if (str.Equals("Drink"))
                {
                    Items = Items.Where(item => item is Drink);
                }
                else if (str.Equals("Drink"))
                {
                    Items = Items.Where(item => item is Drink);
                }
            }
            if (CaloriesMax != null)
            {
                Items = Items.Where(item => item.Calories <= CaloriesMax);
            }
            else if (CaloriesMin != null)
            {
                Items = Items.Where(item => item.Calories >= CaloriesMin);
            }
            else if (CaloriesMin != null && CaloriesMax != null)
            {
                Items = Items.Where(item => item.Calories >= CaloriesMin && item.Calories <= CaloriesMax);
            }
            if (PriceMax != null)
            {
                Items = Items.Where(item => item.Price <= PriceMax);
            }
            else if (PriceMin != null)
            {
                Items = Items.Where(item => item.Price >= PriceMin);
            }
            else if (PriceMin != null && PriceMax != null)
            {
                Items = Items.Where(item => item.Price >= PriceMin && item.Price <= PriceMax);
            }
        }
    }
}
