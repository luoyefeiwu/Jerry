using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_命令模式
{
    public class RequirementGroup : Gorup
    {
        public override void add()
        {
            Console.WriteLine("添加需求");
        }

        public override void change()
        {
            Console.WriteLine("更改需求");
        }

        public override void delete()
        {
            Console.WriteLine("删除需求");
        }

        public override void find()
        {
            Console.WriteLine("找到需求组");
        }

        public override void plan()
        {
            Console.WriteLine("变更计划");
        }

        public override void rollBack()
        {
            Console.WriteLine("回滚");
        }
    }
}
