using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Observer_观察者_
{
    class Program
    {
        static void Main(string[] args)
        {

            Cat myCat = new Cat();

            Mouse myMouse1 = new Mouse("mouse1", myCat);

            Mouse myMouse2 = new Mouse("mouse2", myCat);

            Master myMaster = new Master(myCat);

            Master2 myMaster2 = new Master2(myCat);

            myCat.Cry();

            Console.Read();

        }
    }
}
