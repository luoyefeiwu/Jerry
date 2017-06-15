using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(Factory.CreateCalculator(Calculator.Add));
            var result = context.exec(1, 2);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
