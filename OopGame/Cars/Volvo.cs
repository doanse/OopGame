using OopGame.Engines;
using System;
using System.Collections.Generic;
using System.Text;

namespace OopGame.Cars
{
    class Volvo : Car<V4>
    {
        public string Abs { get; set; }

        public string Esp { get; set; }
        public override void Shine()
        {
            Console.WriteLine("галогенки включены");
        }

        public override void Signal()
        {
            Console.WriteLine("бу");
        }

        public override string ToString()
        {
            return "Volvo";
        }

    }
}
