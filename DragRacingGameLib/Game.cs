using DragRacingGameLib.Objects;
using System.Collections.Generic;

namespace DragRacingGameLib
{
    public delegate void WriterDelegate(string message);
    public class Game
    {
        private Track track;
        public Game(ICarFactory factory, WriterDelegate writerDelegate)
        {
            List<Viewer> viewers = new List<Viewer>()
            {
                new Viewer() { Name = "Антон"},
                new Viewer() { Name = "Дима"}
            };
            Woman woman = new Woman() { Name = "Света" };

            track = new Track(factory.Create(), length: 2000, viewers, woman, writerDelegate);
        }
        public void Start()
        {
            track.TrackInfo();
            track.EnableCar();
        }
        public static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
