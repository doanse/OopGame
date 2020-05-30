﻿using OopGame.Engines;
using System;
using System.Collections.Generic;
using System.Text;

namespace OopGame.Cars
{
    class KiA : Car<V5>
    {
        public string Abs { get; set; }
        public override void Shine()
        {
            Console.WriteLine("галогенки включены");
        }

        public override void Signal()
        {
            Console.WriteLine("би");
        }

        public override string ToString()
        {
            return "KiA";
        }
    }
}
