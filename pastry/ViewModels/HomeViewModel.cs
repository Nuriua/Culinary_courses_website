using pastry.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pastry.ViewModels
{
    public class HomeViewModel
    {

        public IEnumerable<Sweets> favSweets { get; set; }

    }
}
