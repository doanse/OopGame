using OopGame.Engines;
using System;
using System.Collections.Generic;
using System.Text;

namespace OopGame.Cars
{
    class Toyota : Car<V3>
    {
        public string Abs { get; set; }
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
            return "Toyota";
        }
    }
}
