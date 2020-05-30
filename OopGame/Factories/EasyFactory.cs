using OopGame.Cars;
using OopGame.Engines;
using OopGame.FuelTanks;
using System;
using System.Collections.Generic;
using System.Text;

namespace OopGame.Factories
{
    class EasyFactory : ICarFactory
    {  
        Car<IEngine>[] ICarFactory.Create()
        {
            Ford ford = new Ford()
            {
                Abs = "1",
                Speed = 11,
                Engine = new V2() { Cost = 300, Power = 140, Volume = 2 },
                FuelTank = new FT2() { FuelVolume = 30, Volume = 30 }
            };
            KiA kia = new KiA()
            {
                Abs = "1",
                Speed = 11,
                Engine = new V5() { Cost = 200, Power = 150, Volume = 2 },
                FuelTank = new FT2() { FuelVolume = 30, Volume = 30 }
            };

            Car<IEngine> car = ford;

            Car<IEngine>[] cars = new Car<IEngine>[]
            {
                ford,
                kia
            };
            return cars;
        }
    }
}
