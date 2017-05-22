using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkHelper.UnitOfWork
{
    /// <summary>
    /// 单元操作实现
    /// </summary>
    public abstract class UnitOfWorkContextBase : IUnitOfWorkContext
    {
        /// <summary>
        /// 获取 当前使用的数据访问上下文对象
        /// </summary>
        protected abstract DbContext Context { get; set; }

        /// <summary>
        /// 获取 当前单元操作是否已经提交
        /// </summary>
        public bool IsCommitted { get; private set; }

        /// <summary>
        /// 提交当前单元操作的结果
        /// </summary>
        /// <returns></returns>
        public int Commit()
        {
            int result = 0;
            if (!IsCommitted)
            {
                try
                {
                    result = Context.SaveChanges();
                    IsCommitted = true;
                }
                catch (DbUpdateException ex)
                {
                    throw ex;
                }
            }
            return result;
        }



        public void Rollback()
        {
            IsCommitted = false;
        }

        public void Dispose()
        {
            if (!IsCommitted) Commit();
            Context.Dispose();
        }


        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return Context.Set<TEntity>();
        }

        public void RegisterNew<TEntity>(TEntity entity) where TEntity : class
        {
            if (Context.Entry(entity).State == EntityState.Detached)
                Context.Entry(entity).State = EntityState.Added;
            IsCommitted = false;
        }

        public void RegisterNew<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
        {
            try
            {
                Context.Configuration.AutoDetectChangesEnabled = false;
                foreach (var item in entities)
                    RegisterNew(item);
            }
            finally
            {
                Context.Configuration.AutoDetectChangesEnabled = true;
            }
        }

        public void RegisterModified<TEntity>(TEntity entity) where TEntity : class
        {
            if (Context.Entry(entity).State == EntityState.Detached)
                Context.Set<TEntity>().Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
            IsCommitted = false;
        }

        /// <summary>
        /// 注册一个删除的对象到仓储上下文中
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        public void RegisterDeleted<TEntity>(TEntity entity) where TEntity : class
        {
            Context.Entry(entity).State = EntityState.Deleted;
            IsCommitted = false;
        }

        /// <summary>
        /// 批量注册多个删除的对象到仓储上下文中
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entities"></param>
        public void RegisterDeleted<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
        {
            try
            {
                Context.Configuration.AutoDetectChangesEnabled = false;
                foreach (var item in entities)
                    RegisterDeleted(item);
            }
            finally
            {
                Context.Configuration.AutoDetectChangesEnabled = true;
            }
        }
    }
}
