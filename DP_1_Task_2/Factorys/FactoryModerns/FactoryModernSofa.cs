using DP_1_Task_2.Furnitrues.Sofas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_1_Task_2.Factorys.FactoryModerns
{
    public class FactoryModernSofa : FactoryModern
    {
        public override Furniture CreatFurniture()
        {
            return new ModernSofa();
        }
    }
}
