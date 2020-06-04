using System;
using System.Threading;

namespace DragRacingGameLib.Engines
{
    class V2: Engine
    {         
        public override string ToString()
        {
            return $"Двигатель V2 работает в потоке {Thread.CurrentThread.ManagedThreadId}";
        }       
    }
}
