using EntityFrameworkHelper.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkHelper.Repository
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {

        /// <summary>
        /// 获取仓储上下文的实例
        /// </summary>
        public IUnitOfWork UnitOfWork { get; set; }



        public IQueryable<T> Entities
        {
            get { throw new NotImplementedException(); }
        }

        public int Insert(T entity, bool isCommit = true)
        {
            throw new NotImplementedException();
        }

        public int Insert(IEquatable<T> entities, bool isCommit = true)
        {
            throw new NotImplementedException();
        }

        public int DeleteByCondition<T>(System.Linq.Expressions.Expression<Func<T, bool>> predicate, bool isCommit = true)
        {
            throw new NotImplementedException();
        }

        public int UpdateByCondition<T>(Action<T> updateExpression, System.Linq.Expressions.Expression<Func<T, bool>> predicate, bool isCommit = true)
        {
            throw new NotImplementedException();
        }

        public bool SaveOrUpdate<T>(T entity, bool isAdd = false, bool isCommit = true)
        {
            throw new NotImplementedException();
        }

        public bool SaveOrUpdateForList<T>(List<T> entities, bool isAdd = false, bool isCommit = true)
        {
            throw new NotImplementedException();
        }
    }
}
