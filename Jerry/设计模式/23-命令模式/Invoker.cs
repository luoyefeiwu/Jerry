using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_命令模式
{
    public class Invoker
    {
        private Command command;

        public void setCommand(Command command)
        {
            this.command = command;
        }

        public void action()
        {
            this.command.execute();
        }
    }
}
