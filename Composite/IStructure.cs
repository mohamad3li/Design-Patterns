using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    interface IStructure
    {
        void Enter();
        void Exit();
        void Location();
        String GetName();
    }
}
