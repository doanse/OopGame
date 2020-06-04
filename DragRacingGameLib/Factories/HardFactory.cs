using DragRacingGameLib.Cars;
using DragRacingGameLib.FuelTanks;

namespace DragRacingGameLib.Factories
{
    public class HardFactory : ICarFactory
    {
        ICar<Engine>[] ICarFactory.Create()
        {
            Audi audi = new Audi()
            {
                Abs = "1",
                CruiseControl = "s",
                Esp = "s",
                Speed = 200,
                FuelTank = new FT3()
            };
            BMW bmw = new BMW()
            {
                Abs = "1",
                CruiseControl = "s",
                Esp = "s",
                Speed = 250,
                FuelTank = new FT3()
            };
            ICar<Engine>[] cars = new ICar<Engine>[]
            {
                audi,
                bmw
            };
            return cars;
        }
        public override string ToString()
        {
            return "Сложно";
        }
    }
}
