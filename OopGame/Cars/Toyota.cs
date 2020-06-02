﻿using OopGame.Engines;
using System;

namespace OopGame.Cars
{
    class Toyota : ICar<V3>
    {
        private IFuelTank _fuelTank;
        private int _speed;
        private V3 _engine;
        public string Abs { get; set; }
        public string CruiseControl { get; set; }        
        public IFuelTank FuelTank { get => _fuelTank; set => _fuelTank = value; }
        public int Speed { get => _speed; set => _speed = value; }

        public V3 Engine => _engine = new V3() { Cost = 1000, Power = 200, Volume = 2 };

        public V3 GetCurrentEngine()
        {
            return this._engine;
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
