using EntityFrameworkHelper.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace EntityFrameworkHelper.Dao
{
    public class BaseDal
    {
        private DBEntities db = new DBEntities();

        private bool isTransaction = false;

        public IQueryable<T> GetEntity<T>() where T : class
        {
            return db.Set<T>().AsNoTracking().AsQueryable<T>();
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lst"></param>
        /// <returns></returns>
        public int Add<T>(List<T> lst, bool isCommit = true) where T : class
        {
            foreach (var item in lst)
            {
                db.Entry<T>(item).State = System.Data.Entity.EntityState.Added;
            }

            if (isCommit && !isTransaction)
                return db.SaveChanges();
            else
                return 0;

        }

        /// <summary>
        /// 根据条件删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public bool DeleteByCondition<T>(Expression<Func<T, bool>> predicate, bool isCommit = true) where T : class
        {
            db.Set<T>().Where<T>(predicate).ToList<T>().ForEach(d => db.Entry<T>(d).State = System.Data.Entity.EntityState.Deleted);
            if (isCommit && !isTransaction)
                return db.SaveChanges() > 0;
            else
                return false;
        }

        public bool UpdateByCondition<T>(Action<T> updateExpression, Expression<Func<T, bool>> predicate, bool isCommit = true) where T : class
        {
            var lst = db.Set<T>().Where<T>(predicate).ToList<T>();
            lst.ForEach(item =>
            {
                updateExpression(item);
                db.Entry<T>(item).State = System.Data.Entity.EntityState.Modified;
            });

            if (isCommit && !isTransaction)
                return db.SaveChanges() > 0;
            else
                return false;
        }

        public bool SaveOrUpdate<T>(T entity, bool isAdd = false, bool isCommit = true) where T : class
        {
            if (isAdd)
                db.Set<T>().Add(entity);
            else
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;

            if (isCommit && !isTransaction)
                return db.SaveChanges() > 0;
            else
                return false;

        }

        public bool SaveOrUpdateForList<T>(List<T> entities, bool isAdd = false, bool isCommit = true) where T : class
        {
            foreach (T entity in entities)
            {
                if (isAdd)
                    db.Set<T>().Add(entity);
                else
                    db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            }
            if (isCommit && !isTransaction)
                return db.SaveChanges() > 0;
            else
                return false;
        }

        public int ExecuteSqlCommand(string sql, bool isCommit = true)
        {
            db.Database.ExecuteSqlCommand(sql);
            if (isCommit && !isTransaction)
                return db.SaveChanges();
            else
                return 0;
        }

        public int ExecuteSqlCommand(string sql, bool isCommit, params object[] parameters)
        {
            db.Database.ExecuteSqlCommand(sql, parameters);
            if (isCommit && !isTransaction)
                return db.SaveChanges();
            return 0;
        }
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ProcName"></param>
        /// <param name="paramsStr"></param>
        /// <returns></returns>
        public List<T> ExecPro<T>(string ProcName, object[] paramsStr)
        {
            try
            {
                string sql = "exec " + ProcName;

                if (paramsStr.Length > 0)
                {
                    string str = string.Empty;
                    for (int i = 0; i < paramsStr.Length; i++)
                    {
                        if (str != string.Empty)
                            str += ",";

                        str += "@p" + i.ToString();
                    }
                    sql += " " + str;
                }

                return db.Database.SqlQuery<T>(sql, paramsStr).ToList();
            }
            catch (Exception ex)
            {
                return new List<T>();
            }
        }

        /// <summary>
        ///  执行存储过程 无超时
        /// </summary>
        /// <param name="ProcName"></param>
        /// <param name="parList"></param>
        public void ExecPro(string ProcName, List<SqlParameter> parList)
        {
            DbConnection conn = db.Database.Connection;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            DbCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = ProcName;
            cmd.CommandTimeout = 0;
            foreach (SqlParameter par in parList)
            {
                cmd.Parameters.Add(par);
            }

            cmd.ExecuteNonQuery();
        }

        public void BeginTranscation()
        {
            isTransaction = true;
        }

        public int Commit()
        {
            if (isTransaction)
            {
                isTransaction = false;
                return db.SaveChanges();
            }
            else
                return 0;
        }

        /// <summary>
        /// 执行SQL查询语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<T> FindEntityListBySql<T>(string sql)
        {
            return db.Database.SqlQuery<T>(sql).ToList<T>();
        }

        public void Close()
        {
            if (db != null)
            {
                db.Dispose();
                db = null;
            }
        }

        public void Dispose()
        {
            if (db != null)
            {
                db.Dispose();
                db = null;
            }
        }
    }
}
