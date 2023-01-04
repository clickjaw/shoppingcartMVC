using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartMVC.Infrastructure;
using ShoppingCartMVC.Models;
using ShoppingCartMVC.Models.ViewModels;

namespace ShoppingCartMVC.Controllers
{
    public class CheckoutController : Controller
    {

        public IActionResult Index()
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();

            CheckoutViewModel cartVM = new()
            {
                CartItems = cart,
                GrandTotal = cart.Sum(x => x.Quantity * x.Price)
            };

            return View(cartVM);
        }


        public IActionResult Clear(long id)
        {


            HttpContext.Session.Remove("Cart");

            return RedirectToAction("index");

        }

    }
}