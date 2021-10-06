using pastry.Data.interfaces;
using pastry.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pastry.Data.Repository
{
    public class CategoryRepository : ISweetsCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }


        public IEnumerable<Category> AllCategories => appDBContent.Category; // получаем все категории
    }
}
