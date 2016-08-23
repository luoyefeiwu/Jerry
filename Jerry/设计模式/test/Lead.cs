using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Lead : HAL<CommBase>
    {
        public Lead(CommBase t):base(t)
        {
 
        }

        public override void Receive(object sender, SerialDataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override bool Open(CommBase t)
        {
            throw new NotImplementedException();
        }
    }
}
