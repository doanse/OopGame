using OopGame.Engines;
using System;

namespace OopGame.Cars
{
    class Volvo : ICar<V4>
    {
        private IFuelTank _fuelTank;
        private int _speed;
        private V4 _engine;
        public string Abs { get; set; }
        public string Esp { get; set; }        
        public IFuelTank FuelTank { get => _fuelTank; set => _fuelTank = value; }
        public int Speed { get => _speed; set => _speed = value; }

        public V4 Engine => _engine = new V4() { Cost = 1400, Power = 300, Volume = 3 };

        public V4 GetCurrentEngine()
        {
            return this._engine;
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
