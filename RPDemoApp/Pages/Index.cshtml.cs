using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPDemoApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IFoodData _foodData;

        public List<FoodModel> Foods { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IFoodData foodData)
        {
            _logger = logger;
            _foodData = foodData;
        }

        public async Task OnGet()
        {
            Foods = await _foodData.GetFood();
        }
    }
}
