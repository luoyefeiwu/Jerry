﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Comm.Instance.SayHi();
            Console.WriteLine(str);
            Console.Read();
        }
    }
}
