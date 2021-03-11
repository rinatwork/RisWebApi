using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IBaseDao<T>
    {
        /// <summary>
        /// 异步获取全部数据
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllAsync();

        /// <summary>
        /// 异步获取符合条件数据
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> GetByConditionAsync(Expression<Func<T, bool>> expression);

        /// <summary>
        /// 新增一条数据
        /// </summary>
        /// <param name="Entity"></param>
        void Create(T Entity);

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="Entity"></param>
        void Update(T Entity);

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="Entity"></param>
        void Delete(T Entity);

        /// <summary>
        /// 异步保存数据
        /// </summary>
        /// <returns></returns>
        Task<bool> SaveAsync();
    }
}
