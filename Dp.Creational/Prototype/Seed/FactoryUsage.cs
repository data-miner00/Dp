using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp.Creational.Prototype.Seed
{
    internal static class FactoryUsage
    {
        public static void Usage()
        {
            var garden = new GardenFactory(
                new TreeSeed("Apple"),
                new GrassSeed("Red"),
                new FlowerSeed("Roses")
            );

            garden.CreatePlant1();
            garden.CreatePlant2();
            garden.CreatePlant3();
        }
    }
}
