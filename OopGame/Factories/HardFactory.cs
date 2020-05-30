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
        ICar<IEngine>[] ICarFactory.Create()
        {
            Audi audi = new Audi()
            {
                Abs = "1",
                CruiseControl = "s",
                Esp = "s",
                Speed = 11,
                FuelTank = new FT1() { FuelVolume = 10, Volume = 10 }
            };
            BMW bmw = new BMW()
            {
                Abs = "1",
                CruiseControl = "s",
                Esp = "s",
                Speed = 11,
                FuelTank = new FT1() { FuelVolume = 10, Volume = 10 }
            };
            ICar<IEngine>[] cars = new ICar<IEngine>[]
            {
                audi,
                bmw
            };
            return cars;
        }
    }
}
