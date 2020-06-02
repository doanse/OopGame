using OopGame.Engines;
using System;

namespace OopGame.Cars
{
    class Ford : ICar<V2>
    {
        private IFuelTank _fuelTank;
        private int _speed;
        private V2 _engine;
        public string Abs { get; set; }       
        public IFuelTank FuelTank { get => _fuelTank; set => _fuelTank = value; }
        public int Speed { get => _speed; set => _speed = value; }
        public V2 Engine => _engine = new V2() { Cost = 300, Power = 140, Volume = 2 };

        public V2 GetCurrentEngine()
        {
            return this._engine;
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
