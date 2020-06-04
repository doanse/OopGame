using System;
using System.Threading.Tasks;

namespace DragRacingGameLib
{    
    public abstract class Engine
    {
        public event EventHandler OnActive;
        public event EventHandler OnDeactivate;
        public async Task<string> Work(int fuelTankVolume, WriterDelegate writerDelegate)
        {
            try
            {
                int time = 3000;
                var step = time * Volume / 1000;
                for (int i = 0; i < fuelTankVolume; i += step)
                {
                    if (i == step)
                        OnActive?.Invoke(this, new EventArgs());
                    await Task.Delay(time);
                    writerDelegate($"{this.ToString()} Мощность = {Power} лс");
                }
                OnDeactivate?.Invoke(this, new EventArgs());
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public bool? IsActive { get; set; }
        public int Cost { get; set; }
        public int Volume { get; set; }
        public int Power { get; set; }
    }
}
