using System;
using System.Threading.Tasks;

namespace DragRacingGameLib
{
    interface ICar<out T> where T : Engine
    {
        public T GetCurrentEngine();
        public T Engine { get; }
        public IFuelTank FuelTank { get; set; }
        public int Speed { get; set; }
        public string Signal();
        public string Shine();
        public double GetDistance(double time)
        {
            return time * Speed;
        }

        public async Task<string> Move(WriterDelegate writerDelegate)
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
                        writerDelegate($"Едет {this.ToString()} - пройдено расстояние {distance} м");
                    }
                    else if (GetCurrentEngine().IsActive == false)
                    {
                        writerDelegate($"Закончилось топливо {this.ToString()} - пройдено расстояние {distance} м");
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
