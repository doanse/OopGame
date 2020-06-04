using System.Threading;

namespace DragRacingGameLib.Engines
{
    class V6: Engine
    {       
        public override string ToString()
        {
            return $"Двигатель V6 работает в потоке {Thread.CurrentThread.ManagedThreadId}";
        }       
    }
}
