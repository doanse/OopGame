using System.Threading;

namespace DragRacingGameLib.Engines
{
    class V3: Engine
    {     
        public override string ToString()
        {
            return $"Двигатель V3 работает в потоке {Thread.CurrentThread.ManagedThreadId}";
        }        
    }
}
