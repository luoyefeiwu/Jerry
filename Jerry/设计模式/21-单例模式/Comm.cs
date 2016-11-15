using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_单例模式
{
    public class Comm
    {
        private Comm() { }
        /// <summary>
        /// 延时实例化
        /// </summary>
        class Nested {
            static Nested() { }
            internal static readonly Comm instance = new Comm();
        }

        /// <summary>
        /// 单件实例
        /// </summary>
        public static Comm Instance
        {
            get { return Nested.instance; }
        }

        public string SayHi()
        {
            return "Hello";
        }

    }
}
