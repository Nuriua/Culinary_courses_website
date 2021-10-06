using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pastry.Data.Models { 
    public class Sweets {  // контретные товары

        public int id { set; get; } // идентификатор

        public string name { set; get; } // имя

        public string shortDesc { set; get; } // небольшое описание

        public string longDesc { set; get; } // длинное описание

        public string img { set; get; } // url адрес с картинкой

        public ushort price { set; get; } // цена (ushort не может быть отрицательным)

        public bool isFavourite { set; get; } // отображение товара на главной странице

        public bool available { set; get; } // доступен ли товар

        public int categoryID { set; get; } 

        public virtual Category Category { set; get; }

    }
}
