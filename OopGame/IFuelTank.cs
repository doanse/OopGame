using System;
using System.Collections.Generic;
using System.Text;

namespace OopGame
{
    interface IFuelTank
    {
        int Volume { get; set; }
        int FuelVolume { get; set; }
        public void Combustion();
    }
}
