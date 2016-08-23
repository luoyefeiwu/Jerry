using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public abstract class HAL<T> where T:CommBase
    {
        public HAL(T t)
        {
            t.SerialPort.DataReceived += Receive;
        }

        public abstract void Receive(object sender, System.IO.Ports.SerialDataReceivedEventArgs e);


        public abstract bool Open(T t);

    }
}
