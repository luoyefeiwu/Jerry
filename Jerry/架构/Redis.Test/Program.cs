using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Redis.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Redis发布，订阅服务");
            string str = Console.ReadLine();
           
            if (str == "publish")
            {
                RedisPubSubServer.Instance.Subscription();
            }   
            else
            {
               // RedisPubSubServer.Instance.Pub();
                while (true)
                {
                    string msg = Console.ReadLine();
                    RedisPubSubServer.Instance.Send(msg);
                }
            }

            Console.Read();

        }



    }
}
