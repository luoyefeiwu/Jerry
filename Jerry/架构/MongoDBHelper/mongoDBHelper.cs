using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBHelper
{
    public class mongoDBHelper
    {
        private readonly static MongoClient client = new MongoClient("mongodb://127.0.0.1:27017");

        private readonly static IMongoDatabase db = client.GetDatabase("userInfo");

        private mongoDBHelper() { }

        class Nested
        {
            static Nested() { }
            internal readonly static mongoDBHelper instance = new mongoDBHelper();
        }

        public static mongoDBHelper Instance
        {
            get { return Nested.instance; }
        }


        public IQueryable<T> GetEntity<T>() where T : class
        {
            return db.GetCollection<T>(typeof(T).Name).AsQueryable<T>();
        }

        public void Add<T>(List<T> list) where T : class
        {
            db.GetCollection<T>(typeof(T).Name).InsertMany(list);
        }

        public void Add<T>(T t) where T : class
        {
            db.GetCollection<T>(typeof(T).Name).InsertOne(t);
        }

        /// <summary>
        /// 根据条件删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public void DeleteByCondition<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            db.GetCollection<T>(typeof(T).Name).DeleteMany(predicate);
        }

        public void UpdateByCondition<T>(Expression<Func<T, bool>> predicate, UpdateDefinition<T> update)
            where T : class
        {


            //   public UpdateDefinition<TDocument> Combine(params UpdateDefinition<TDocument>[] updates);
       
   




            db.GetCollection<T>(typeof(T).Name).UpdateMany<T>(predicate, update);
        }

       

    }
}
