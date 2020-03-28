using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Room : IStructure
    {
        private String name;
        public Room(String name)
        {
            this.name = name;
        }
        public void Enter()
        {
            Console.WriteLine($"Entered room{this.name}");
        }

        public void Exit()
        {
            Console.WriteLine($"Exited room {this.name}");
        }

        public string GetName()
        {
            return this.name;
        }

        public void Location()
        {
            Console.WriteLine($"Currently in room {this.name}");
        }
    }
}
