using DP_1_Task_2.Furnitrues.CoffeeTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_1_Task_2.Factorys.FactoryModerns
{
    public class FactoryModernCoffeeTable : FactoryModern
    {
        public override Furniture CreatFurniture()
        {
            return new ModernCoffeeTable();
        }
    }
}
