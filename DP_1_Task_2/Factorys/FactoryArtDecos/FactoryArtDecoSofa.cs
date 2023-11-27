using DP_1_Task_2.Furnitrues.Sofas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_1_Task_2.Factorys.FactoryArtDecos
{
    public class FactoryArtDecoSofa : FactoryArtDeco
    {
        public override Furniture CreatFurniture()
        {
            return new ArtDecoSofa();
        }
    }
}
