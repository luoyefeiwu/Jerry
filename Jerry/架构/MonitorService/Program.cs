using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MonitorService
{
    class Program
    {

        static void Main(string[] args)
        {
            //ThreadPool.QueueUserWorkItem(new WaitCallback(Test), "ws://192.168.1.10:2012");
            //ThreadPool.QueueUserWorkItem(new WaitCallback(Test), "ws://192.168.1.19:2012");

            WebSocketHelper socket = new WebSocketHelper("ws://192.168.1.10:2012");
            socket.Connection();
            Timer timer = new Timer(new TimerCallback(TestTimer), socket, 1000, 1000);
            
       

            Console.Read();
        }


        static void TestTimer(object o)
        {
            WebSocketHelper socket = o as WebSocketHelper;
            string sendStr = "heart {\"message_method\":\"heart\",\"message_queue\":\"heart\"}" + "\r\n";
            var str = socket.Send(sendStr);
            Console.WriteLine(DateTime.Now.ToString() + str);
            System.Threading.Thread.Sleep(10);
        }





        private static void Test(object o)
        {
            string url = o as string;

            WebSocketHelper socket = new WebSocketHelper(url);
            //WebSocketHelper socket = new WebSocketHelper("ws://192.168.1.10:2012");
            socket.Connection();
            string sendStr = "heart {\"message_method\":\"heart\",\"message_queue\":\"heart\"}" + "\r\n";

            while (true)
            {
                var str = socket.Send(sendStr);
                Console.WriteLine(DateTime.Now.ToString() + str);
                System.Threading.Thread.Sleep(10);
            }
        }


    }
}
