﻿using OopGame.Engines;
using System;

namespace OopGame.Cars
{
    class Audi : ICar<V1>
    {
        private IFuelTank _fuelTank;
        private int _speed;
        private V1 _engine;
        public string Abs { get; set; }
        public string Esp { get; set; }
        public string CruiseControl { get; set; }       
        public IFuelTank FuelTank { get => _fuelTank; set => _fuelTank = value; }
        public int Speed { get => _speed; set => _speed = value; }
        public V1 Engine => _engine = new V1() { Cost = 1000, Power = 500, Volume = 4 };

        public V1 GetCurrentEngine()
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
            return "Audi";
        }
    }
}
