using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OopGame.Engines
{
    class V2: IEngine
    {
        public int Cost { get; set; }
        public int Volume { get; set; }
        public int Power { get; set; }
        public bool? IsActive { get; set; }

        public override string ToString()
        {
            return $"Двигатель V2 работает в потоке {Thread.CurrentThread.ManagedThreadId}";
        }
    }
}
