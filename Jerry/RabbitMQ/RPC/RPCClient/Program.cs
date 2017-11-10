using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var rpcClient = new RPCClient();

            var n = args.Length > 0 ? args[0] : "30";
            Console.WriteLine(" [x] Requesting fib({0})", n);
            var response = rpcClient.Call(n);
            Console.WriteLine(" [.] Got '{0}'", response);

            rpcClient.Close();

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}
