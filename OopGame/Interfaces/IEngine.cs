using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OopGame
{
    interface IEngine
    {
        public async Task<string> Work(int fuelTankVolume)
        {
            try
            {
                int time = 3000;
                this.IsActive = true;
                for (int i = 0; i < fuelTankVolume; i+=time*Volume/1000)
                {
                    await Task.Delay(time);
                    Console.WriteLine($"{this.ToString()} Мощность = {Power} лс");
                }
                this.IsActive = false;
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        bool? IsActive { get; set; }
        int Cost { get; set; }
        int Volume { get; set; }
        int Power { get; set; }
    }
}
