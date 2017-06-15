using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_策略模式
{
    /// <summary>
    /// 上下文
    /// </summary>
    public class Context
    {
        private ICalculator _cal = null;

        public Context(ICalculator cal)
        {
            _cal = cal;
        }
        public int exec(int a, int b)
        {
            return this._cal.exec(a, b);
        }
    }
}
