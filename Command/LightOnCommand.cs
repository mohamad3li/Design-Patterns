﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class LightOnCommand : ICommand
    {
        private Light light;
        public LightOnCommand(Light light)
        {
            this.light = light;

        }
        public void Execute()
        {
            light.On();
        }

        public void UnExecute()
        {
            light.Off();
        }
    }
}
