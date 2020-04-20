using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class LightUpCommand : ICommand
    {
        private Light light;
        public LightUpCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.Up();
        }

        public void UnExecute()
        {
            light.Down();
        }
    }
}
