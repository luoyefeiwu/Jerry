using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_命令模式
{
    public class AddRequirement : Command
    {
        public override void execute()
        {
            base.rg.find();
            base.rg.add();
            base.rg.plan();
        }
    }
}
