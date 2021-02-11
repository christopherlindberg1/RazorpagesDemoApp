using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RPDemoApp.Pages.Orders
{
    public class AllOrdersModel : PageModel
    {
        private readonly IOrderData _orderData;
        private readonly IFoodData _foodData;

        public List<OrderModelWithFoodDetails> Orders { get; set; }

        public AllOrdersModel(IOrderData orderData, IFoodData foodData)
        {
            _orderData = orderData;
            _foodData = foodData;
        }

        public async Task OnGet()
        {
            Orders = await _orderData.GetOrdersWithFoodDetails();
        }
    }
}
