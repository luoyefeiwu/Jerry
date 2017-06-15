using EntityFrameworkHelper.Contract.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkHelper.Contract.Impl
{
    public class UserService : IUserContract
    {

       
        public IEnumerable<Model.User> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
