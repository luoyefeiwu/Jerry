using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_模版
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Basketball();
            game.play();
            Console.WriteLine("-------------");
            game = new Football();
            game.play();
            Console.Read();
        }
    }
}
