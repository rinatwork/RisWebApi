using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;
using IDAL;

namespace DAL
{
    public class BaseDao<T, TId> : IBaseDao<T>, IBaseDaoPro<T, TId> where T : class
    {
        public DbContext DbContext { get; set; }

        public BaseDao(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        /// <summary>
        /// 新增一条数据
        /// </summary>
        /// <param name="Entity"></param>
        public void Create(T Entity)
        {
            DbContext.Set<T>().Add(Entity);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="Entity"></param>
        public void Delete(T Entity)
        {
            DbContext.Set<T>().Remove(Entity);
        }

        /// <summary>
        /// 异步获取全部数据
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<T>> GetAllAsync()
        {
            return Task.FromResult(DbContext.Set<T>().AsEnumerable());   
        }

        /// <summary>
        /// 异步获取符合条件数据
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public Task<IEnumerable<T>> GetByConditionAsync(Expression<Func<T, bool>> expression)
        {
            return Task.FromResult(DbContext.Set<T>().Where(expression).AsEnumerable());
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <returns></returns>
        public async Task<bool> SaveAsync()
        {
            return await DbContext.SaveChangesAsync() > 0;
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="Entity"></param>
        public void Update(T Entity)
        {
            DbContext.Set<T>().Update(Entity);
        }

        /// <summary>
        /// 异步根据主键获取数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<T> GetByIdAsync(TId Id)
        {
            return await DbContext.Set<T>().FindAsync(Id);
        }

        /// <summary>
        /// 异步根据主键判断数据是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> IsExistAsync(TId id)
        {
            return await DbContext.Set<T>().FindAsync(id) != null;
        }
    }
}
