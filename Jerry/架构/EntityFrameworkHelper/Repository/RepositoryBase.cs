using EntityFrameworkHelper.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EntityFrameworkHelper.Repository
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {

        /// <summary>
        /// 获取仓储上下文的实例
        /// </summary>
        public IUnitOfWork UnitOfWork { get; set; }

        /// <summary>
        /// 获取或设置 EntityFramework的数据仓储上下文
        /// </summary>
        protected IUnitOfWorkContext EFContext
        {
            get
            {
                if (UnitOfWork is IUnitOfWorkContext)
                {
                    return UnitOfWork as IUnitOfWorkContext;
                }
                throw new Exception(string.Format("数据仓储上下文对象类型不正确，应为IUnitOfWorkContext，实际为 {0}", UnitOfWork.GetType().Name));
            }
        }

        public virtual IQueryable<T> Entities
        {
            get { return EFContext.Set<T>(); }
        }

        public virtual int Insert(T entity, bool isCommit = true)
        {
            EFContext.RegisterNew(entity);
            return isCommit ? EFContext.Commit() : 0;
        }

        public int Insert(IEquatable<T> entities, bool isCommit = true)
        {
            EFContext.RegisterNew(entities);
            return isCommit ? EFContext.Commit() : 0;
        }

        public int DeleteByCondition(System.Linq.Expressions.Expression<Func<T, bool>> predicate, bool isCommit = true)
        {
            var list = Entities.Where(predicate);
            EFContext.RegisterDeleted(list);
            return isCommit ? EFContext.Commit() : 0;
        }

        public int UpdateByCondition(Action<T> updateExpression, System.Linq.Expressions.Expression<Func<T, bool>> predicate, bool isCommit = true)
        {
            var list = Entities.Where(predicate);
            foreach (var item in list)
            {
                updateExpression(item);
                EFContext.RegisterModified(item);
            }
            return isCommit ? EFContext.Commit() : 0;
        }

        public bool SaveOrUpdate(T entity, bool isAdd = false, bool isCommit = true)
        {
            if (isAdd)
                EFContext.RegisterNew(entity);
            else
                EFContext.RegisterModified(entity);
            return isCommit ? EFContext.Commit() > 0 : false;
        }

        public bool SaveOrUpdateForList(List<T> entities, bool isAdd = false, bool isCommit = true)
        {
            foreach (var item in entities)
            {
                if (isAdd)
                    EFContext.RegisterNew(item);
                else
                    EFContext.RegisterModified(item);
            }
            return isCommit ? EFContext.Commit() > 0 : false;
        }
    }
}
