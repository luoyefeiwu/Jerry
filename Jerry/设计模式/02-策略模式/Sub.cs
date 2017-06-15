using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_策略模式
{
    /// <summary>
    /// 减法
    /// </summary>
    public class Sub : ICalculator
    {
        public int exec(int a, int b)
        {
            return a - b;
        }
    }
}
