using System;
using System.Collections.Generic;
using System.Text;

namespace OopGame.FuelTanks
{
    class FT2: IFuelTank
    {
        public int Volume { get; set; }
        public int FuelVolume { get; set; }

        public void Combustion()
        {
            Console.WriteLine("Combustion");
        }
    }
}
