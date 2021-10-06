using pastry.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pastry.Data.interfaces
{
    public interface IAllSweets {  

        IEnumerable<Sweets> Sweets { get;  } // get - получать данные, set - устанавливать данные
                                            //  IEnumerable - перечесление
        IEnumerable<Sweets> getFavSweets { get; }

        Sweets getObjectCar(int carId);

    }
}
