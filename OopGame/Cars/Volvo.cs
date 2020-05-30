using OopGame.Engines;
using OopGame.FuelTanks;
using System;
using System.Collections.Generic;
using System.Text;

namespace OopGame.Cars
{
    class Volvo : ICar<V4>
    {
        public string Abs { get; set; }

        public string Esp { get; set; }
        private IFuelTank _fuelTank;
        private int _speed;
        public IFuelTank FuelTank { get => _fuelTank; set => _fuelTank = value; }
        public int Speed { get => _speed; set => _speed = value; }

        public V4 GetEngine()
        {
            return new V4() { Cost = 1400, Power = 300, Volume = 4 };
        }

        public void Shine()
        {
            Console.WriteLine("галогенки включены");
        }

        public void Signal()
        {
            Console.WriteLine("бу");
        }

        public override string ToString()
        {
            return "Volvo";
        }

    }
}
