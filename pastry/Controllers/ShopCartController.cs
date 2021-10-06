using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using pastry.Data.interfaces;
using pastry.Data.Models;
//using pastry.Data.Repository;
using pastry.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pastry.Controllers
{
    public class ShopCartController : Controller
    {
        //private readonly SweetsRepository _sweetRep;
        private readonly IAllSweets _carRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllSweets sweetRep, ShopCart shopCart)
        {
            _carRep = sweetRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };


            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _carRep.Sweets.FirstOrDefault(i => i.id == id);

            if(item != null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");

        }


    }
}
