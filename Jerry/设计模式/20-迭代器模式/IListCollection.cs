using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_迭代器模式
{
    public interface IListCollection
    {
        Iterator GetIterator();
    }
}
