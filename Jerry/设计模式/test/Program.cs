using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            People p = new People(cat);
            cat.Cry();
            Console.Read();
        }
    }
}
