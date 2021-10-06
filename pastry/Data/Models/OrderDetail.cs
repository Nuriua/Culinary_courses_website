using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pastry.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }

        public int orderID { get; set; }

        public int SweetsID { get; set; }

        public uint price { get; set; }

        public virtual Sweets sweet { get; set; }

        public virtual Order order { get; set; }

        

    }
}
