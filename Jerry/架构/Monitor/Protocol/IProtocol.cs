using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor.Protocol
{
    public interface IProtocol
    {
        void Send(string msg);

        string Recive();


    }
}
