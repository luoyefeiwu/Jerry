using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EF读写分离
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private bool isTransaction = false;
        private Model.DbReadEntity dbRead = new Model.DbReadEntity();
        private Model.DbWriteEntity dbWrite = new Model.DbWriteEntity();

        //public TransactionScope BeginTransaction()
        //{
        //    return new TransactionScope()
        //}

        //public void Commited()
        //{
        //    tx.Complete;
        //    tx.Dispose();
        //}


        public IQueryable<T> Entities
        {
            get { return dbRead.Set<T>().AsNoTracking().AsQueryable<T>(); }
        }

        public int Insert(T entity, bool isCommit = true)
        {
            dbWrite.Entry<T>(entity).State = EntityState.Added;
            return (isCommit && !isTransaction) ? dbWrite.SaveChanges() : 0;
        }

        public int Insert(IEnumerable<T> entities, bool isCommit = true)
        {
            foreach (var item in entities)
                dbWrite.Entry<T>(item).State = EntityState.Added;
            return (isCommit && !isTransaction) ? dbWrite.SaveChanges() : 0;
        }

        public int DeleteByCondition(Expression<Func<T, bool>> predicate, bool isCommit = true)
        {
            throw new NotImplementedException();
        }

        public int UpdateByCondition(Action<T> updateExpression, Expression<Func<T, bool>> predicate, bool isCommit = true)
        {
            throw new NotImplementedException();
        }

        public bool SaveOrUpdate(T entity, bool isAdd = false, bool isCommit = true)
        {
            throw new NotImplementedException();
        }

        public bool SaveOrUpdateForList(List<T> entities, bool isAdd = false, bool isCommit = true)
        {
            throw new NotImplementedException();
        }


    }
}
