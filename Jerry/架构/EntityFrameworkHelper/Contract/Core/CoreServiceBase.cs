﻿using EntityFrameworkHelper.UnitOfWork;

namespace EntityFrameworkHelper.Contract.Core
{
    public abstract class CoreServiceBase
    {
        /// <summary>
        /// 获取或设置 工作单元对象，用于处理同步业务的事务操作
        /// </summary>
        protected IUnitOfWork UnitOfWork { get; set; }
    }
}
