using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OopGame
{
    interface IEngine
    {
        Task<string> Work();
        int Cost { get; set; }
        int Volume { get; set; }
        int Power { get; set; }
    }
}
