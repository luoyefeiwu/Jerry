using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Observer_观察者_
{
    /// <summary>
    /// 多行为
    /// </summary>
    public abstract class Observer2
    {

        public Observer2(ModelBase childModel)
        {

            childModel.SubEvent += new ModelBase.SubEventHandler(Response);
            childModel.SubEvent += new ModelBase.SubEventHandler(Response2);

        }


        public abstract void Response();


        public abstract void Response2();
    }
}
