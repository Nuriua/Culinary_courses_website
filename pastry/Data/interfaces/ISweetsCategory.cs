using pastry.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pastry.Data.interfaces
{
    public interface ISweetsCategory { 
        
        IEnumerable<Category> AllCategories { get; }

    }
}
