using OopGame.Engines;
using OopGame.FuelTanks;
using System;
using System.Collections.Generic;
using System.Text;

namespace OopGame.Cars
{
    class BMW : ICar<V1>
    {
        public string Abs { get; set; }
        public string Esp { get; set; }
        public string CruiseControl { get; set; }
        private IFuelTank _fuelTank;
        private int _speed;
        public IFuelTank FuelTank { get => _fuelTank; set => _fuelTank = value; }
        public int Speed { get => _speed; set => _speed = value; }

        public V1 GetEngine()
        {
            return new V1() { Cost = 1300, Power = 550, Volume = 4 };
        }

        public void Shine()
        {
            Console.WriteLine("ксенон включен");
        }

        public void Signal()
        {
            Console.WriteLine("бо");
        }

        public override string ToString()
        {
            return "BMW";
        }
    }
}
