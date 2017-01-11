using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_命令模式
{
    public abstract class Gorup
    {
        /// <summary>
        /// 甲乙双方分开办公，要和哪个组讨论需求，你首先要找到这个组
        /// </summary>
        public abstract void find();

        /// <summary>
        /// 被要求增加功能
        /// </summary>
        public abstract void add();

        /// <summary>
        /// 被要求删除功能
        /// </summary>
        public abstract void delete();

       /// <summary>
       /// 被要求修改需求
       /// </summary>
        public abstract void change();

        /// <summary>
        /// 被要求给出所有变更计划
        /// </summary>
        public abstract void plan();

        /// <summary>
        /// 每个执行者都要对直接执行的任务可以回滚
        /// </summary>
        public abstract void rollBack();
    }
}
