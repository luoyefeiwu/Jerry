using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Observer_观察者_
{
    public class Master2 : Observer2
    {
        public Master2(ModelBase childBase)
            : base(childBase)
        {

        }

        public override void Response()
        {
            Console.WriteLine("Baby醒来..........");
        }

        public override void Response2()
        {
            Console.WriteLine("开始哭闹...........");
        }





    }
}
    