using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class LightDownCommand : ICommand
    {
        private Light light;
        public LightDownCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.Down();
        }

        public void UnExecute()
        {
            light.Up();
        }
    }
}
