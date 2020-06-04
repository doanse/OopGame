using DragRacingGameLib.Cars;
using DragRacingGameLib.FuelTanks;

namespace DragRacingGameLib.Factories
{
    public class EasyFactory : ICarFactory
    {
        ICar<Engine>[] ICarFactory.Create()
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

            ICar<Engine>[] cars = new ICar<Engine>[]
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
