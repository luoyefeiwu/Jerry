using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public abstract class BaseObserver
    {
        public delegate void SubEventHandler();

        public event SubEventHandler SubEvent;

        protected void Notify()
        {
            if (this.SubEvent != null)
                this.SubEvent();
        }


    }
}
