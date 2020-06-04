using System.Threading;

namespace DragRacingGameLib.Engines
{
    class V4: Engine
    {      
        public override string ToString()
        {
            return $"Двигатель V4 работает в потоке {Thread.CurrentThread.ManagedThreadId}";
        }        
    }
}
