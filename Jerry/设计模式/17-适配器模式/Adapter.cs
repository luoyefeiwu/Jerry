using System;

namespace _17_适配器模式
{
    /// <summary>
    /// 适配器
    /// </summary>
    public class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            this.SpecificRequest();
        }
    }
}
