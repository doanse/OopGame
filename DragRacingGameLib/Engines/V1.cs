using System;
using System.Threading;
using System.Threading.Tasks;

namespace DragRacingGameLib.Engines
{
    class V1 : Engine
    {     
        public override string ToString()
        {
            return $"Двигатель V1 работает в потоке {Thread.CurrentThread.ManagedThreadId}";
        }        
    }
}
