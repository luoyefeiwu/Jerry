using System;

namespace _20_迭代器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Iterator iterator;
            IListCollection list = new ConcreteList();
            iterator = list.GetIterator();

            while (iterator.MoveNext())
            {
                int i = (int)iterator.GetCurrent();
                Console.WriteLine(i);
                iterator.Next();
            }
            Console.Read();
        }
    }
}
