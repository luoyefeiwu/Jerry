using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            update();
        }
        private void Add()
        {
            userInfo u = new userInfo()
            {
                name = "张三",
                password = Guid.NewGuid(),
                birthDay = Convert.ToDateTime("1988-10-07"),
                createTime = DateTime.Now,
                gender = true
            };
            mongoDBHelper.Instance.Add<userInfo>(u);
        }

        private static void Get(Expression<Func<userInfo, bool>> predicate)
        {
            var list = mongoDBHelper.Instance.GetEntity<userInfo>().Where(predicate);
            string json = "null";
            if (list != null && list.Count() > 0)
            {
                json = Newtonsoft.Json.JsonConvert.SerializeObject(list);
            }

            Console.WriteLine(json);
        }

        private static void delete()
        {
            mongoDBHelper.Instance.DeleteByCondition<userInfo>(e => e.gender);
        }

        private static void listAdd()
        {
            List<userInfo> list = new List<userInfo>();
            for (int i = 0; i < 200; i++)
            {
                userInfo u = new userInfo();
                u.name = "张三" + i;
                u.birthDay = Convert.ToDateTime("1988-10-07");
                u.createTime = DateTime.Now;
                if (i % 2 == 0)
                {
                    u.gender = true;
                }
                else
                {
                    u.gender = false;
                }
                list.Add(u);
            }
            mongoDBHelper.Instance.Add<userInfo>(list);
        }

        private static void update()
        {
            mongoDBHelper.Instance.UpdateByCondition<userInfo>(e => e.gender == true, Builders<userInfo>.Update.Set(e => e.gender, false).Set(e=>e.name,"123"));
        }

    }
}
