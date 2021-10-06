using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using pastry.Data.interfaces;
using pastry.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pastry.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllSweets _sweetRep;

        public HomeController(IAllSweets carRep)
        {
            _sweetRep = carRep;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favSweets = _sweetRep.getFavSweets
            };

            return View(homeCars);
        }


    }
}
