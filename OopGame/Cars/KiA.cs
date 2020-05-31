using OopGame.Engines;
using OopGame.FuelTanks;
using System;
using System.Collections.Generic;
using System.Text;

namespace OopGame.Cars
{
    class KiA : ICar<V5>
    {
        private IFuelTank _fuelTank;

        private int _speed;
        public string Abs { get; set; }
       
        public IFuelTank FuelTank { get => _fuelTank; set => _fuelTank = value; }
        public int Speed { get => _speed; set => _speed = value; }

        public V5 GetEngine()
        {
            return new V5() { Cost = 200, Power = 150, Volume = 2 };
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
            return "KiA";
        }
    }
}
