using OopGame.Cars;
using OopGame.Engines;
using OopGame.FuelTanks;
using System;
using System.Collections.Generic;
using System.Text;

namespace OopGame.Factories
{
    class HardFactory : ICarFactory
    {
        Car[] ICarFactory.Create()
        {
            Audi audi = new Audi()
            {
                Abs = "1",
                CruiseControl = "s",
                Esp = "s",
                Speed = 11,
                Engine = new V1() { Cost = 1000, Power = 500, Volume = 4 },
                FuelTank = new FT1() { FuelVolume = 10, Volume = 10 }
            };
            BMW bmw = new BMW()
            {
                Abs = "1",
                CruiseControl = "s",
                Esp = "s",
                Speed = 11,
                Engine = new V1() { Cost = 1300, Power = 550, Volume = 4 },
                FuelTank = new FT1() { FuelVolume = 10, Volume = 10 }
            };
            Car[] cars = new Car[]
            {
                audi,
                bmw
            };
            return cars;
        }
    }
}
