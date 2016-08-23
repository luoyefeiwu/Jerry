using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class People:Observer
    {
        public People(BaseObserver t):base(t)
        { 
        
        }
        public override void Response()
        {
            Console.WriteLine("人醒了");
        }
    }
}
