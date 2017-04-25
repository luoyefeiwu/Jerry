using ServiceStack.Logging;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redis
{
    /// <summary>
    /// 发布订阅
    /// </summary>
    public class RedisPubSubServer
    {
        private static ILog Log = LogManager.GetLogger(typeof(RedisPubSubServer));

        private RedisPubSubServer() { }
        class Nested
        {
            static Nested()
            {
            }
            internal readonly static RedisPubSubServer instance = new RedisPubSubServer();

        }

        public static RedisPubSubServer Instance
        {
            get { return Nested.instance; }
        }

        /// <summary>
        /// 发布
        /// </summary>
        public void Pub()
        {
            ServiceStack.Redis.IRedisClientsManager RedisClientManager = new ServiceStack.Redis.PooledRedisClientManager("127.0.0.1.65:6379");
            //发布、订阅服务 IRedisPubSubServer
            ServiceStack.Redis.RedisPubSubServer pubSubServer = new ServiceStack.Redis.RedisPubSubServer(RedisClientManager, "channel-1");

            pubSubServer.OnMessage = (channel, msg) =>
            {
                Console.WriteLine(string.Format("服务端:频道{0}接收消息：{1}    时间：{2}", channel, msg, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")));
                Console.WriteLine("___________________________________________________________________");
            };
            pubSubServer.OnStart = () =>
            {
                Console.WriteLine("发布服务已启动");
                Console.WriteLine("___________________________________________________________________");
            };
            pubSubServer.OnStop = () => { Console.WriteLine("服务停止"); };
            pubSubServer.OnUnSubscribe = (channel) => { Console.WriteLine(channel); };
            pubSubServer.OnError = (e) => { Console.WriteLine(e.Message); };
            pubSubServer.OnFailover = (s) => { Console.WriteLine(s); };
            pubSubServer.Start();

        }

        /// <summary>
        /// 发送消息
        /// </summary>
        public Task Send(string msg)
        {
            return Task.Run(() =>
            {
                RedisClient client = new RedisClient("127.0.0.1", 6379);
                client.PublishMessage("channel-1", msg);
               
            });
        }

        /// <summary>
        /// 订阅
        /// </summary>
        public void Subscription()
        {
            using (ServiceStack.Redis.RedisClient consumer = new RedisClient("127.0.0.1", 6379))
            {
                //创建订阅
                ServiceStack.Redis.IRedisSubscription subscription = consumer.CreateSubscription();

                //接收消息处理Action
                subscription.OnMessage = (channel, msg) =>
                {
                    Console.WriteLine("频道【" + channel + "】订阅客户端接收消息：" + ":" + msg + "         [" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "]");
                    Console.WriteLine("订阅数：" + subscription.SubscriptionCount);
                    Console.WriteLine("___________________________________________________________________");

                };

                //订阅事件处理
                subscription.OnSubscribe = (channel) =>
                {
                    Console.WriteLine("订阅客户端：开始订阅" + channel);
                };

                //取消订阅事件处理
                subscription.OnUnSubscribe = (a) => { Console.WriteLine("订阅客户端：取消订阅"); };

                ////模拟：发送100条消息给服务
                //Task.Run(() =>
                //{
                //    using (ServiceStack.Redis.IRedisClient publisher = new ServiceStack.Redis.RedisClient("127.0.0.1", 6379))
                //    {
                //        for (int i = 1; i <= 100; i++)
                //        {
                //            publisher.PublishMessage("channel-1", string.Format("这是我发送的第{0}消息!", i));
                         
                //            System.Threading.Thread.Sleep(200);
                //        }
                //    }
                //    subscription.UnSubscribeFromAllChannels();
                //});

                //订阅频道
                subscription.SubscribeToChannels("channel-1");
            }

        }

    }



}
