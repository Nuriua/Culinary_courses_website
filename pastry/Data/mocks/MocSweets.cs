using pastry.Data.interfaces;
using pastry.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pastry.Data.mocks
{
    public class MocSweets : IAllSweets
    {

        private readonly ISweetsCategory _categoryCars = new MockCategory();

        public IEnumerable<Sweets> Sweets {
            get
            {
                return new List<Sweets>
                {
                    new Sweets { 
                        name = "Tesla", 
                        shortDesc = "", 
                        longDesc = "", 
                        img = "/img/1she.jpg", 
                        price = 45000, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.First()
                    }

                };
            }
        }
        public IEnumerable<Sweets> getFavSweets { get; set; }

        public Sweets getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
