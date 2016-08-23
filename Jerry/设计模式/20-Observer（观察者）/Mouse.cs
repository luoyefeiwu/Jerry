using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Observer_观察者_
{
    public class Mouse : Observer
    {

        private string name;

        public Mouse(string name, ModelBase childModel)
            : base(childModel)
        {
            this.name = name;
        }

        public override void Response()
        {
            Console.WriteLine(this.name + "开始逃跑");
        }
    }
}
