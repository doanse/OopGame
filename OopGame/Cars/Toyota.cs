using OopGame.Engines;
using OopGame.FuelTanks;
using System;
using System.Collections.Generic;
using System.Text;

namespace OopGame.Cars
{
    class Toyota : ICar<V3>
    {
        private IFuelTank _fuelTank;

        private int _speed;
        public string Abs { get; set; }
        public string CruiseControl { get; set; }
        
        public IFuelTank FuelTank { get => _fuelTank; set => _fuelTank = value; }
        public int Speed { get => _speed; set => _speed = value; }

        public V3 GetEngine()
        {
            return new V3() { Cost = 1000, Power = 200, Volume = 3 };
        }

        public void Shine()
        {
            Console.WriteLine("ксенон включен");
        }

        public void Signal()
        {
            Console.WriteLine("би");
        }

        public override string ToString()
        {
            return "Toyota";
        }
    }
}
