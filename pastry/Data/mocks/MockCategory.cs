using pastry.Data.interfaces;
using pastry.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pastry.Data.mocks
{
    public class MockCategory : ISweetsCategory
    {
        IEnumerable<Category> ISweetsCategory.AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Электромобили", desc = "Современный вид транспорта"},
                    new Category { categoryName = "Классические автомобили", desc = "Машины с двигателем внут згорания"}
                };
            }
        }



    }
}
