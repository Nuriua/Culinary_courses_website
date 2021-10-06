using Microsoft.AspNetCore.Mvc;
using pastry.Data.interfaces;
using pastry.Data.Models;
using pastry.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pastry.Controllers
{
    public class SweetsController : Controller
    {
        // переменные на интерфейсы
        private readonly IAllSweets _allCars;
        private readonly ISweetsCategory _allCategories;

        public SweetsController(IAllSweets iAllSweet, ISweetsCategory iCarsCat)
        {
            _allCars = iAllSweet;
            _allCategories = iCarsCat;
        }

        [Route("Sweets/List")]
        [Route("Sweets/List/{category}")]
        //[Route("/")]
        public ViewResult List(string category) // возвращает html страницу
        {
            //  ViewBag.Category = "Some New"
            // var sweet = _allCars.Sweets;
            string _category = category;
            IEnumerable<Sweets> cars = null;
            string currCategory = "";
            if(string.IsNullOrEmpty(category))
            {
                cars = _allCars.Sweets.OrderBy(i => i.id);
            } else
            {
                if(string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Sweets.Where(i => i.Category.categoryName.Equals("Электромобили")).OrderBy(i => i.id);
                    currCategory = "Электромобили";
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Sweets.Where(i => i.Category.categoryName.Equals("Классические автомобили")).OrderBy(i => i.id);
                    currCategory = "Классические автомобили";
                }

                 

            }


            var carObj = new SweetsListViewModel
            {
                allSweets = cars,
                currCategory = currCategory
            };

            ViewBag.Title = "Страница с автомобилями";

            //SweetsListViewModel obj = new SweetsListViewModel();
           // obj.allSweets = _allCars.Sweets;
            //obj.currCategory = "Автомобили";

            return View(carObj);
        }

    }
}
