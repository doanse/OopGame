using System;
using System.Collections.Generic;
using System.Text;

namespace OopGame
{
    interface ICarFactory
    {
        Car<IEngine>[] Create();
    }
}
