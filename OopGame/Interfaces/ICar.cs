using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OopGame
{
    interface ICar<out T> where T : IEngine
    {
        public T GetCurrentEngine();
        public T Engine { get; }
        public IFuelTank FuelTank { get; set; }
        public int Speed { get; set; }
        public void Signal();
        public void Shine();
        public double GetDistance(double time)
        {
            return time * Speed;
        }

        public async Task<string> Move()
        {
            try
            {
                int time = 3000;
                double distance = 0;
                while (true)//пока не  закончится топливо
                {
                    if (GetCurrentEngine().IsActive == true)
                    {
                        await Task.Delay(time);
                        distance += GetDistance(time / 1000);
                        Console.WriteLine($"Едет {this.ToString()} - пройдено расстояние {distance} м");
                    }
                    else if (GetCurrentEngine().IsActive == false)
                    {
                        Console.WriteLine($"Закончилось топливо {this.ToString()} - пройдено расстояние {distance} м");
                        break;
                    }
                    else 
                    {
                        continue;
                    }
                }
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }       
    }
}
