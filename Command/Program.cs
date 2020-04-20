using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            ICommand on = new LightOnCommand(light);
            ICommand off = new LightOffCommand(light);
            ICommand up = new LightUpCommand(light);
            ICommand down = new LightDownCommand(light);
            Remote remote = new Remote(on,off,up,down);
            remote.PressOn();
            remote.PressOff();
            remote.PressUp();
            remote.PressDown();
            Console.ReadKey();

        }
    }
}
