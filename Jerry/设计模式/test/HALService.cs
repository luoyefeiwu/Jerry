using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class HALService<T> where T:CommBase
    {
        HAL hal = null;
        public HALService(HAL hal)
        { 
        
        }
        public bool Open(T t)
        {
          return  hal.Open(t);
        }



       

    }
}
