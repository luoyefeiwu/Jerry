﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new Adapter();
            target.Request();
            Console.Read();
        }
    }
}
