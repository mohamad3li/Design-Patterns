using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Remote
    {
        ICommand on,off,up,down;
        public Remote(ICommand on,ICommand off,ICommand up,ICommand down )
        {
            this.on = on;
            this.off = off;
            this.down = down;
            this.up = up;
        }
        public void PressOn()
        {
            on.Execute();
        }
        public void PressOff()
        {
            off.Execute();
        }
        public void PressUp()
        {
            up.Execute();
        }
        public void PressDown()
        {
            down.Execute();
        }
    }
}
