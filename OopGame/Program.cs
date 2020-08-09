using DragRacingGameLib;
using DragRacingGameLib.Factories;
using System;
using System.Collections.Generic;
namespace OopGame
{
    class Program
    {
        static void Main(string[] args)
        {         
            //
            List<ICarFactory> levels = new List<ICarFactory>()
            {
                new EasyFactory(),
                new HardFactory()
            };

            for (int i = 0; i < levels.Count; i++) 
            {
                Console.WriteLine($"{i + 1}. {levels[i]}");
            }

            int selectedLevel;
            var userValue = Console.ReadLine();
            var isSuccess = Int32.TryParse(userValue, out selectedLevel);

            if (!isSuccess)
            {
                Console.WriteLine("Ошибка");
                Console.ReadKey();
                return;
            }
            selectedLevel--;
            if (selectedLevel > -1 && selectedLevel < levels.Count)
            {
                ICarFactory carFactory = levels[selectedLevel];
                Game game = new Game(carFactory, Writer.Write);
                game.Start();
            }
            else
            {
                Console.WriteLine("Такого уровня не существует");
            }       
            Console.ReadKey();
        }
    }
}
