using System;
using System.Collections.Generic;
using System.Text;

namespace OopGame
{
    abstract class Car<T> where T : IEngine
    {
        public T Engine { get; set; }
        public IFuelTank FuelTank { get; set; }
        public int Speed { get; set; }
        public abstract void Signal();
        public abstract void Shine();
    }
}
