using OopGame.Cars;
using OopGame.Engines;
using OopGame.Factories;
using OopGame.FuelTanks;
using System;

namespace OopGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите уровень сложности easy or hard");
            var level = Console.ReadLine();

            if (level == "easy")
            {
                Game game = new Game(new EasyFactory());
                game.Start();
            }
            else
            {
                Game game = new Game(new HardFactory());
                game.Start();
            }

            Console.ReadKey();
        }
    }
}
