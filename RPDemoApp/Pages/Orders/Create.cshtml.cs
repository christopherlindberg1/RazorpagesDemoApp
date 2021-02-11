using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RPDemoApp.Pages.Orders
{
    public class CreateModel : PageModel
    {
        private readonly IFoodData _foodData;
        private readonly IOrderData _orderData;

        public List<FoodModel> Foods { get; set; }
        public List<SelectListItem> FoodItems { get; set; }

        [BindProperty]  // Can write to this on a post
        public OrderModel Order { get; set; }

        public CreateModel(IFoodData foodData, IOrderData orderData)
        {
            _foodData = foodData;
            _orderData = orderData;
        }

        public async Task OnGet()
        {
            Foods = await _foodData.GetFood();

            //List<FoodModel> food = await _foodData.GetFood();

            FoodItems = new List<SelectListItem>();

            foreach (FoodModel foodItem in Foods)
            {
                FoodItems.Add(new SelectListItem
                {
                    Value = foodItem.Id.ToString(),
                    Text = foodItem.Title,
                });
            }

            //Food.ForEach(foodItem =>
            //{
            //    FoodItems.Add(new SelectListItem
            //    {
            //        Value = foodItem.Id.ToString(),
            //        Text = foodItem.Title,
            //    });
            //});
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            List<FoodModel> food = await _foodData.GetFood();

            Order.Total = Order.Quantity * food.Where(foodItem => foodItem.Id == Order.FoodId).First().Price;

            int id = await _orderData.CreateOrder(Order);

            return RedirectToPage("./Display", new { Id = id });
        }
    }
}
