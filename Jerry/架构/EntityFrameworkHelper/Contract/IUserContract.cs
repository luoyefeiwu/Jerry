
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkHelper.Contract
{
    public interface IUserContract
    {
      
        IEnumerable<Model.User> GetAll();
    }
}
