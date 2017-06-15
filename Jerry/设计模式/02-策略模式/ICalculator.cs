using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_策略模式
{
    /// <summary>
    /// 策略接口
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// 执行方法
        /// </summary>
        int exec(int a, int b);
    }
}
