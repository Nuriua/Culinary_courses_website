using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using pastry.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pastry.Data
{
    public class DBObjects
    {

        public static void Initial(AppDBContent content)
        {

            //AppDBContent content = app.ApplicationServices.GetRequiredService<AppDBContent>();

            if(!content.Category.Any()) // если нет объектов 
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Sweets.Any())
            {
                content.AddRange(
                        new Sweets
                        {
                            name = "Tesla",
                            shortDesc = "",
                            longDesc = "",
                            img = "/img/1she.jpg",
                            price = 45000,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Электромобили"]
                        }


                    );
            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                         new Category { categoryName = "Электромобили", desc = "Современный вид транспорта"},
                         new Category { categoryName = "Классические автомобили", desc = "Машины с двигателем внут згорания"}
                         //new Category { categoryName="Торты", }

                    };

                    category = new Dictionary<string, Category>();

                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }

                }

                return category;

            }

        }

    }
}
