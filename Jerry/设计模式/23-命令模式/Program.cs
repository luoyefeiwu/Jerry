﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_命令模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker xiaoSan = new Invoker();
            xiaoSan.setCommand(new AddRequirement());
            xiaoSan.action();
            Console.Read();
        }
    }
}
