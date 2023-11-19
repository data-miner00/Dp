using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp.Creational.Prototype.Seed
{
    internal class GardenFactory(Seed seed1, Seed seed2, Seed seed3)
    {
        private readonly Seed seed1 = seed1;
        private readonly Seed seed2 = seed2;
        private readonly Seed seed3 = seed3;

        internal Seed CreatePlant1() => seed1.Copy();
        internal Seed CreatePlant2() => seed2.Copy();
        internal Seed CreatePlant3() => seed3.Copy();
    }
}
