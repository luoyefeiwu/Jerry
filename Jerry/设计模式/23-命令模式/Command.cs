using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_命令模式
{
    public abstract class Command
    {
        protected RequirementGroup rg = new RequirementGroup();

        public abstract void execute();

    }
}
