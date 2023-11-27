using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_1_Task_2.Factorys.FactoryVictorians
{
    public class FactoryVictorianChair : FactoryVictorian
    {
        public override Furniture CreatFurniture()
        {
            return new VictorianChair();
        }
    }
}
