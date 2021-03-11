using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IBaseDaoPro<T, TId>
    {
        /// <summary>
        /// 异步根据主键获取数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetByIdAsync(TId id);

        /// <summary>
        /// 异步根据主键判断数据是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> IsExistAsync(TId id);
    }
}
