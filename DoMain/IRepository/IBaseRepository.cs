using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DoMain.IRepository
{
    public interface IBaseRepository<T>:IAutofac where T:class,new()
    {
        /// <summary>
        /// 通过Id获取一条数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        T GetModel(object Id);
        /// <summary>
        /// 用过linq查询返回一条数据
        /// </summary>
        /// <param name="pression"></param>
        /// <returns></returns>
        T GetModel(Expression<Func<T, bool>> pression);
        /// <summary>
        /// 以List返回所有数据
        /// </summary>
        /// <returns></returns>
        List<T> GetList();
        /// <summary>
        /// 通过Linq查询返回List数据集
        /// </summary>
        /// <param name="pression"></param>
        /// <returns></returns>
        List<T> GetList(Expression<Func<T, bool>> pression);
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">每页数量</param>
        /// <param name="count">总数据量</param>
        /// <param name="pression">Linq查询条件</param>
        /// <param name="orderby">排序Linq</param>
        /// <returns></returns>
        List<T> GetPageList(int pageIndex, int pageSize, ref int count, Expression<Func<T, bool>> pression, Expression<Func<T, dynamic>> orderby);
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">每页数量</param>
        /// <param name="count">总数据量</param>
        /// <param name="pression">Linq查询条件</param>
        /// <param name="orderby">排序Linq</param>
        /// <param name="sort">true正序，false反序</param>
        /// <returns></returns>
        List<T> GetPageList(int pageIndex, int pageSize, ref int count, Expression<Func<T, bool>> pression, Expression<Func<T, dynamic>> orderby,bool sort);
        /// <summary>
        /// 对象新增数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Add(T model);
        /// <summary>
        /// 批量新增
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        bool AddRange(List<T> list);
        /// <summary>
        /// 更新单个对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Update(T model);
        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        bool Update(List<T> list);
        /// <summary>
        /// 删除单个对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Delete(T model);
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        bool Delete(List<T> list);
        /// <summary>
        /// Linq删除
        /// </summary>
        /// <param name="pression"></param>
        /// <returns></returns>
        bool Delete(Expression<Func<T, bool>> pression);
        
    }
}
