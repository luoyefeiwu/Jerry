using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Observer_观察者_
{
    /// <summary>
    /// 单行为
    /// </summary>
    public abstract class Observer
    {

        public Observer(ModelBase childModel)
        {
            childModel.SubEvent += new ModelBase.SubEventHandler(Response);
        }

        public abstract void Response();
    }
}
