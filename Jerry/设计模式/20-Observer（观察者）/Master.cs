using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Observer_观察者_
{
    public class Master:Observer
    {



        public Master(ModelBase childModel)
            : base(childModel)
        { 
        
        }

        public override void Response()
        {
            Console.WriteLine("主人醒来");
        }
    }
}
