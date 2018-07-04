using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DoMain.IRepository;
using Entity.Models;
using System.Linq.Expressions;
using System.Data.Entity;

namespace DoMain.Repository
{
    public class BaseRepository<T>:IBaseRepository<T> where T:class,new()
    {
        private TestAuthorityContext db;
        public BaseRepository()
        {
            if (db == null)
            {
                db = new TestAuthorityContext();
            }
        }
        public T GetModel(object Id)
        {
            return db.Set<T>().Find(Id);
        }
        public T GetModel(Expression<Func<T, bool>> pression)
        {
            return db.Set<T>().Where(pression).FirstOrDefault();
        }
        public List<T> GetList()
        {
            return db.Set<T>().ToList();
        }
        public List<T> GetList(Expression<Func<T, bool>> pression)
        {
            return db.Set<T>().Where(pression).ToList();
        }
        public List<T> GetPageList(int pageIndex, int pageSize, ref int count, Expression<Func<T, bool>> pression, Expression<Func<T, dynamic>> orderby)
        {
            var query = db.Set<T>().Where(pression);
            count = query.Count();
            return query.OrderBy(orderby).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

        }
        public List<T> GetPageList(int pageIndex, int pageSize, ref int count, Expression<Func<T, bool>> pression, Expression<Func<T, dynamic>> orderby, bool sort)
        {
            var query = db.Set<T>().Where(pression);
            count = query.Count();
            if (sort)
            {
                return query.OrderBy(orderby).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            }
            else
            {
                return query.OrderByDescending(orderby).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            }
        }
        public bool Add(T model)
        {
            using (DbContextTransaction Ts = db.Database.BeginTransaction())
            {
                db.Set<T>().Add(model);
                int Count = db.SaveChanges();
                Ts.Commit();
                return Count > 0;
            }
        }
        public bool AddRange(List<T> list)
        {
            using (DbContextTransaction Ts = db.Database.BeginTransaction())
            {
                db.Set<T>().AddRange(list);
                int Count = db.SaveChanges();
                Ts.Commit();
                return Count > 0;
            }
        }
        public bool Update(T model)
        {
            using (DbContextTransaction Ts = db.Database.BeginTransaction())
            {
                var entity = db.Entry<T>(model);
                db.Set<T>().Attach(model);
                entity.State = EntityState.Modified;
                int Count = db.SaveChanges();
                Ts.Commit();
                return Count > 0;
            }
        }
        public bool Update(List<T> list)
        {
            using (DbContextTransaction Ts = db.Database.BeginTransaction())
            {
                foreach (var model in list)
                {
                    var entity = db.Entry<T>(model);
                    db.Set<T>().Attach(model);
                    entity.State = EntityState.Modified;
                }
                int Count = db.SaveChanges();
                Ts.Commit();
                return Count > 0;
            }
        }
        public bool Delete(T model)
        {
            using (DbContextTransaction Ts = db.Database.BeginTransaction())
            {
                db.Set<T>().Remove(model);
                int Count = db.SaveChanges();
                Ts.Commit();
                return Count > 0;
            }
        }
        public bool Delete(List<T> list)
        {
            using (DbContextTransaction Ts = db.Database.BeginTransaction())
            {
                foreach (var model in list)
                {
                    db.Set<T>().Remove(model);
                }
                int Count = db.SaveChanges();
                Ts.Commit();
                return Count > 0;
            }
        }
        public bool Delete(Expression<Func<T, bool>> pression)
        {
            using (DbContextTransaction Ts = db.Database.BeginTransaction())
            {
                IEnumerable<T> model = db.Set<T>().Where(pression);
                if (model != null)
                {
                    db.Set<T>().RemoveRange(model);
                    int count = db.SaveChanges();
                    Ts.Commit();
                    return count > 0;
                }
                return false;
            }
        }
    }
}
