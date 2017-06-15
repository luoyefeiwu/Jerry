using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_策略模式
{
    public class Factory
    {
        /// <summary>
        /// 创建实例
        /// </summary>
        /// <param name="cal"></param>
        /// <returns></returns>
        public static ICalculator CreateCalculator(Calculator cal)
        {
            ICalculator calculator = null;
            switch (cal)
            {
                case Calculator.Add: calculator = new Add();
                    break;
                case Calculator.Sub: calculator = new Add();
                    break;
            }
            return calculator;
        }
    }
}
