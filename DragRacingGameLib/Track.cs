using DragRacingGameLib.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRacingGameLib
{
    class Track
    {
        private int length;
        private ICar<Engine>[] cars;
        private List<Viewer> viewers;
        private Woman woman;
        WriterDelegate writerDelegate;

        public Track(ICar<Engine>[] cars, int length, List<Viewer> viewers, Woman woman, WriterDelegate writerDelegate)
        {
            this.cars = cars;
            this.length = length;
            this.viewers = viewers;
            this.woman = woman;
            this.writerDelegate = writerDelegate;
        }

        public void TrackInfo()
        {
            if (viewers.Any())
                writerDelegate("Зрители присутствуют");
            else
                writerDelegate("Зрители отсутствуют");
            
            writerDelegate($"Длина трассы {length}");
            writerDelegate("Список авто:");
            foreach (var car in cars)
            {
                writerDelegate(car.ToString());
            }
        }
        public void EnableCar()
        {
            foreach (var car in cars)
            {               
                car.Engine.Work(car.FuelTank.GetVolume(), writerDelegate);
                car.GetCurrentEngine().OnActive += Engine_OnActive;
                car.GetCurrentEngine().OnDeactivate += Engine_OnDeactivate;
                car.Move(writerDelegate);
            }
        }

        private void Engine_OnDeactivate(object sender, EventArgs eventArgs)
        {
            var engine = (Engine)sender;
            engine.IsActive = false;
        }

        private void Engine_OnActive(object sender, EventArgs eventArgs)
        {
            var engine = (Engine)sender;
            engine.IsActive = true;                      
        }
    }
}
