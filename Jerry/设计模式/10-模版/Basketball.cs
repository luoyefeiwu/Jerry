using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_模版
{
    public class Basketball : Game
    {
        public override void initializa()
        {
            Console.WriteLine("篮球游戏初始化");
        }

        public override void startPlay()
        {
            Console.WriteLine("篮球游戏开始");
        }
        public override void endPlay()
        {
            Console.WriteLine("篮球游戏结束");
        }
    }
}
