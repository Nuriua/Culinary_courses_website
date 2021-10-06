using pastry.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pastry.ViewModels
{
    public class SweetsListViewModel
    {
        public IEnumerable<Sweets> allSweets { get; set; }

        public string currCategory { get; set; }

    }
}
