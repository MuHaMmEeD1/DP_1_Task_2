

using DP_1_Task_2;
using DP_1_Task_2.Factorys.FactoryVictorians;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            FactoryVictorianChair factoryVictorianChair = new FactoryVictorianChair();

            Furniture victorianChair = factoryVictorianChair.CreatFurniture();

            victorianChair.InfoFurniture();




        }

    }

}




