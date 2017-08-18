using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF读写分离
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository<Model.User> r = new Repository<Model.User>();

            var model = r.Entities.FirstOrDefault(e => e.WorkPhone == "18500392662");
            if (model != null) {
                model.UserName = "hcw";
            }

            r.Insert(model, true);

            Console.WriteLine("执行完毕");
            Console.Read();

        }
    }
}
