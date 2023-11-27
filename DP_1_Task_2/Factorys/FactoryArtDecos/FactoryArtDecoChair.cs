using DP_1_Task_2.Furnitrues.Chairs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_1_Task_2.Factorys.FactoryArtDecos
{
    public class FactoryArtDecoChair : FactoryArtDeco
    {
        public override Furniture CreatFurniture()
        {
            return new ArtDecoChair();
        }
    }
}
