using OopGame.Engines;
using OopGame.FuelTanks;
using System;
using System.Collections.Generic;
using System.Text;

namespace OopGame.Cars
{
    class Ford : ICar<V2>
    {
        public string Abs { get; set; }
        private IFuelTank _fuelTank;
        private int _speed;
        public IFuelTank FuelTank { get => _fuelTank; set => _fuelTank = value; }
        public int Speed { get => _speed; set => _speed = value; }

        public V2 GetEngine()
        {
            return new V2() { Cost = 300, Power = 140, Volume = 2 };
        }

        public void Shine()
        {
            Console.WriteLine("галогенки включены");
        }

        public void Signal()
        {
            Console.WriteLine("би");
        }

        public override string ToString()
        {
            return "Ford";
        }
    }
}
