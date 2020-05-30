using OopGame.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace OopGame
{
    class Game
    {
        private Track track;
        public Game(ICarFactory factory)
        {
            List<Viewer> viewers = new List<Viewer>()
            {
                new Viewer() { Name = "Антон"},
                new Viewer() { Name = "Дима"}
            };
            Woman woman = new Woman() { Name = "Света" };

            track = new Track(factory.Create(), 2000, viewers, woman);
        }
        public void Start()
        {
            track.TrackInfo();
            track.EnableCar();
        }
    }
}
