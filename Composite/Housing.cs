using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Housing : IStructure
    {
        private List<IStructure> structures;
        private String address;
        public Housing(String address)
        {
            this.address = address;
            this.structures = new List<IStructure>();

        }
        public int AddStructure(IStructure structure)
        {
            structures.Add(structure);
            return structures.Count-1;
        }
        public IStructure GetStructure(int index)
        {
            return structures[index];
        }
        public void Location()
        {
            Console.WriteLine($"Hello, you are in {this.GetName()}, it has:");
            foreach (IStructure structure in structures)
            {
                Console.WriteLine($"{structure.GetName()}");
            }
        }
        public void Enter()
        {
            Console.WriteLine($"Entered Housing {this.address}");
        }

        public void Exit()
        {
            Console.WriteLine($"Exited Housing {this.address}");
        }

        public string GetName()
        {
            return this.address;
        }

      
    }
}
