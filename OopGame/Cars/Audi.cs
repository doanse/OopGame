using OopGame.Engines;
using System;
using System.Collections.Generic;
using System.Text;

namespace OopGame.Cars
{
    class Audi : Car<V1>
    {
        public string Abs { get; set; }
        public string Esp { get; set; }
        public string CruiseControl { get; set; }

        public override void Shine()
        {
            Console.WriteLine("ксенон включен");
        }

        public override void Signal()
        {
            Console.WriteLine("би");
        }

        public override string ToString()
        {
            return "Audi";
        }
    }
}
