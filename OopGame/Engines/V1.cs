using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OopGame.Engines
{
    class V1 : IEngine
    {
        public int Cost { get; set; }
        public int Volume { get; set; }
        public int Power { get; set; }
        public bool? IsActive { get; set; }

        public override string ToString()
        {
            return $"Двигатель V1 работает в потоке {Thread.CurrentThread.ManagedThreadId}";
        }
    }
}
