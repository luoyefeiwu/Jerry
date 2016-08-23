using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Cat : BaseObserver
    {

        public void Cry()
        {
            Console.WriteLine("猫叫了.......");
            this.Notify();
        }

    }
}
