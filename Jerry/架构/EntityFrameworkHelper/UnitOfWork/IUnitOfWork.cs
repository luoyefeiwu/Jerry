
namespace EntityFrameworkHelper.UnitOfWork
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// 获取当前单元操作是否已被提交
        /// </summary>
        bool IsCommitted { get; }

        /// <summary>
        /// 提交当前单元的结果
        /// </summary>
        /// <returns></returns>
        int Commit();

        /// <summary>
        /// 回滚
        /// </summary>
        void Rollback();

    }

}
