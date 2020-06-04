using System.Threading;

namespace DragRacingGameLib.Engines
{
    class V5: Engine
    {    
        public override string ToString()
        {
            return $"Двигатель V5 работает в потоке {Thread.CurrentThread.ManagedThreadId}";
        }        
    }
}
