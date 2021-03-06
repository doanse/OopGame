﻿using DragRacingGameLib.Engines;

namespace DragRacingGameLib.Cars
{
    class KiA : ICar<V5>
    {
        private IFuelTank _fuelTank;
        private int _speed;
        private V5 _engine;
        public string Abs { get; set; }       
        public IFuelTank FuelTank { get => _fuelTank; set => _fuelTank = value; }
        public int Speed { get => _speed; set => _speed = value; }
        public V5 Engine => _engine = new V5() { Cost = 200, Power = 150, Volume = 1 };

        public V5 GetCurrentEngine()
        {
            return this._engine;
        }

        public string Shine()
        {
            return "галогенки включены";
        }

        public string Signal()
        {
            return "биби";
        }

        public override string ToString()
        {
            return "KiA";
        }
    }
}
