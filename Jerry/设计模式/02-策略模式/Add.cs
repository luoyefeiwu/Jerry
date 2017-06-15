using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_策略模式
{
    /// <summary>
    /// 加法
    /// </summary>
   public class Add :ICalculator
    {
        public int exec(int a, int b)
        {
            return a + b;
        }
    }
}
