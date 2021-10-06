using Microsoft.AspNetCore.Mvc;
using pastry.Data.interfaces;
using pastry.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pastry.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }



        public IActionResult Checkout()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.listShopItems = shopCart.getShopItems();

            if(shopCart.listShopItems.Count == 0)
            {
                ModelState.AddModelError("", "У ва должны быть товары");
            }

            if(ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complele");
            }

            return View(order);
        }

        public IActionResult Complele()
        {
            ViewBag.Message = "Заказ успешно обработан";

            return View();
        }


    }
}
