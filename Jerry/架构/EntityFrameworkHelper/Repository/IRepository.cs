using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EntityFrameworkHelper.Repository
{
    public interface IRepository<T> where T : class
    {

        /// <summary>
        /// 获取当前实体的查询数据集
        /// </summary>
        IQueryable<T> Entities { get; }

        /// <summary>
        /// 插入实体
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="isCommit">是否执行保存</param>
        /// <returns></returns>
        int Insert(T entity, bool isCommit = true);
        /// <summary>
        /// 批量插入
        /// </summary>
        /// <param name="entities">实体集合</param>
        /// <param name="isCommit">是否执行保存</param>
        /// <returns></returns>
        int Insert(IEquatable<T> entities, bool isCommit = true);

        /// <summary>
        /// 根据条件删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate"></param>
        /// <param name="isCommit"></param>
        /// <returns></returns>
        int DeleteByCondition<T>(Expression<Func<T, bool>> predicate, bool isCommit = true);

        /// <summary>
        /// 根据条件修改
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="updateExpression"></param>
        /// <param name="predicate"></param>
        /// <param name="isCommit"></param>
        /// <returns></returns>
        int UpdateByCondition<T>(Action<T> updateExpression, Expression<Func<T, bool>> predicate, bool isCommit = true);

        /// <summary>
        /// 保存或者修改
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <param name="isAdd"></param>
        /// <param name="isCommit"></param>
        /// <returns></returns>
        bool SaveOrUpdate<T>(T entity, bool isAdd = false, bool isCommit = true);

        /// <summary>
        /// 批量保存或者修改
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entities"></param>
        /// <param name="isAdd"></param>
        /// <param name="isCommit"></param>
        /// <returns></returns>
        bool SaveOrUpdateForList<T>(List<T> entities, bool isAdd = false, bool isCommit = true);
    }
}
