using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_外观模式
{
    public class Circle : Shape
    {
        public void draw()
        {
           Console.WriteLine("Circle:draw()");
        }
    }
}
