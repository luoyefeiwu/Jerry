using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4netHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                LogHelper.Create(typeof(string)).Info(DateTime.Now);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
