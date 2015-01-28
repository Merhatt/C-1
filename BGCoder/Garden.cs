using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal tomatoSeeds = int.Parse(Console.ReadLine());
            decimal tomatoArea = int.Parse(Console.ReadLine());
            decimal cucumberSeeds = int.Parse(Console.ReadLine());
            decimal cucumberArea = int.Parse(Console.ReadLine());
            decimal patatoeSeeds = int.Parse(Console.ReadLine());
            decimal patatoeArea = int.Parse(Console.ReadLine());
            decimal carrotSeeds = int.Parse(Console.ReadLine());
            decimal carrotArea = int.Parse(Console.ReadLine());
            decimal cabbageSeeds = int.Parse(Console.ReadLine());
            decimal cabbageArea = int.Parse(Console.ReadLine());
            decimal seedsAmount = int.Parse(Console.ReadLine());
            decimal tomato = 0.5m;
            decimal cucumber = 0.4m;
            decimal patatoe = 0.25m;
            decimal carrot = 0.6m;
            decimal cabbage = 0.3m;
            decimal beans = 0.4m;
            decimal totalArea = 250m;
            decimal totalCost = (tomatoSeeds * tomato) + (cucumberSeeds * cucumber) + (patatoeSeeds * patatoe) + (carrotSeeds * carrot) + (cabbageSeeds * cabbage);
            decimal area = tomatoArea+cucumberArea+patatoeArea+carrotArea+cabbageArea;
            if (area < totalArea)
            {
                decimal beanss = totalArea - area;
                Console.WriteLine("Total costs: {0}", totalCost + seedsAmount * beans);
                Console.WriteLine("Beans area: {0}", totalArea - area);
            }
            else if (area > totalArea) 
            {
                Console.WriteLine("Total costs: {0}", totalCost + seedsAmount * beans);
                Console.WriteLine("Insufficient area");

            }
            else if (totalArea - area == 0) 
            {
                Console.WriteLine("Total costs: {0}", totalCost + seedsAmount * beans);
                Console.WriteLine("No area for beans");
            }

        }
    }
}
