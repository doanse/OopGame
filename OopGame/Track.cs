using OopGame.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OopGame
{
    class Track
    {
        private int length;
        private ICar<IEngine>[] cars;
        private List<Viewer> viewers;
        private Woman woman;

        public Track(ICar<IEngine>[] cars, int length, List<Viewer> viewers, Woman woman)
        {
            this.cars = cars;
            this.length = length;
            this.viewers = viewers;
            this.woman = woman;
        }

        public void TrackInfo()
        {
            if (viewers.Any())
                Console.WriteLine("Зрители присутствуют");
            else
                Console.WriteLine("Зрители отсутствуют");

            Console.WriteLine($"Длина трассы {length}");
            Console.WriteLine("Список авто:");
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
        public void EnableCar()
        {
            foreach (var car in cars)
            {
                car.GetEngine().Work();
            }
        }
    }
}
