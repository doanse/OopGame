using System;
using System.Collections.Generic;
using System.Text;

namespace OopGame
{
    interface ICar<out T> where T : IEngine
    {
        public T GetEngine();
        public IFuelTank FuelTank { get; set; }
        public int Speed { get; set; }
        public abstract void Signal();
        public abstract void Shine();
    }
}
