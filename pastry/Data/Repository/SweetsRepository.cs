using pastry.Data.interfaces;
using pastry.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace pastry.Data.Repository
{
    public class SweetsRepository : IAllSweets
    {
        private readonly AppDBContent appDBContent;

        public SweetsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Sweets> Sweets => appDBContent.Sweets.Include(c => c.Category); // получаем все объекты

        public IEnumerable<Sweets> getFavSweets => appDBContent.Sweets.Where(p => p.isFavourite).Include(c => c.Category); // получаем все объекты где isFavourite == true

        public Sweets getObjectCar(int carId) => appDBContent.Sweets.FirstOrDefault(p => p.id == carId); // получаем один объект по id
        
    }
}
