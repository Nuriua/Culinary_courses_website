using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pastry.Data.Models {  
    public class Category { 
        public int id { set; get; }

        public string categoryName { set; get; }

        public string desc { set; get; }

        public List<Sweets> sweet { set; get; } // товары которые входят в категорию

    }
}
