using DP_1_Task_2.Furnitrues.CoffeeTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_1_Task_2.Factorys.FactoryArtDecos
{
    public class FactoryArtDecoCoffeTables : FactoryArtDeco
    {
        public override Furniture CreatFurniture()
        {
            return new ArtDecoCoffeeTable();
        }
    }
}
