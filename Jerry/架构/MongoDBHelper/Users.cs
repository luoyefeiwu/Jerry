using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBHelper
{
    [BsonIgnoreExtraElements]
    public class userInfo
    {
        //public ObjectId id { get; set; }
        public string name { get; set; }

        public Guid password { get; set; }

        public bool gender { get; set; }

        public DateTime birthDay { get; set; }

        public DateTime createTime { get; set; }
    }
}
