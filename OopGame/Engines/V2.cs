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

        public async Task<string> Work()
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    await Task.Delay(1000);
                    Console.WriteLine(this.ToString());
                }
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public override string ToString()
        {
            return $"Двигатель V2 работает в потоке {Thread.CurrentThread.ManagedThreadId}";
        }
    }
}
