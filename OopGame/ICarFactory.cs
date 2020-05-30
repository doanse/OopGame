using System;
using System.Collections.Generic;
using System.Text;

namespace OopGame
{
    interface ICarFactory
    {
        ICar<IEngine>[] Create();
    }
}
