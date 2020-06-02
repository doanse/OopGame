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
        ICar<IEngine>[] ICarFactory.Create()
        {
            Ford ford = new Ford()
            {
                Abs = "1",
                Speed = 100,
                FuelTank = new FT2()                
            };
            KiA kia = new KiA()
            {
                Abs = "1",
                Speed = 110,
                FuelTank = new FT1()
            };

            ICar<IEngine>[] cars = new ICar<IEngine>[]
            {
                ford,
                kia
            };
            return cars;
        }
        public override string ToString()
        {
            return "Легко";
        }
    }
}
