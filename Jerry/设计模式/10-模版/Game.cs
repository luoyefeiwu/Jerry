using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_模版
{
    public abstract class Game
    {
        public abstract void initializa();

        public abstract void startPlay();

        public abstract void endPlay();

        public void play()
        {
            //初始化
            initializa();
            //开始
            startPlay();
            //结束
            endPlay();
        }
    }
}
