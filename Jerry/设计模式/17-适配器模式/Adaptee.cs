using System;
namespace _17_适配器模式
{
    /// <summary>
    /// 源
    /// </summary>
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("特殊处理");
        }
    }
}
