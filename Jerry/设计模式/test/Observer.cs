using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public abstract class Observer
    {
        public Observer(BaseObserver t)
        {
            t.SubEvent += new BaseObserver.SubEventHandler(Response);
        }
        public abstract void Response();
       
    }
}
