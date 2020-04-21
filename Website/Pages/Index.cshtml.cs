using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// All items in the current filter
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; protected set; }

        /// <summary>
        /// Search bar value
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// Minimum calories
        /// </summary>
        public double? CaloriesMin { get; set; }

        /// <summary>
        /// Maximum calories
        /// </summary>
        public double? CaloriesMax { get; set; }

        /// <summary>
        /// Minimum price
        /// </summary>
        public double? PriceMin { get; set; }

        /// <summary>
        /// Maximum price
        /// </summary>
        public double? PriceMax { get; set; }

        /// <summary>
        /// Types to filter by string
        /// </summary>
        public string[] Types { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Determines the current filter on the index page
        /// </summary>
        /// <param name="PriceMin"></param>
        /// <param name="PriceMax"></param>
        /// <param name="CaloriesMin"></param>
        /// <param name="CaloriesMax"></param>
        public void OnGet(double? PriceMin, double? PriceMax, double? CaloriesMin, double? CaloriesMax)
        {
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            SearchTerms = Request.Query["SearchTerms"];
            Types = Request.Query["Types"];
            Items = Menu.Search(SearchTerms);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = Menu.FilterByType(Items, Types);
        }
    }
}
