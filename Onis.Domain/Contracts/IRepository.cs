using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Onis.Domain.Contracts
{
    public interface IRepository<T> where T : class
    {
        Task<T> FindAsync(Expression<Func<T, bool>> expresion, params string[] includes);
        Task<T> FindAsync(object id);
        Task<bool> ExistsAsync(Expression<Func<T, bool>> expresion);
        Task<IEnumerable<T>> FindManyAsync(Expression<Func<T, bool>> expresion, params string[] includes);
        T Find(Expression<Func<T, bool>> expresion, params string[] includes);
        T Find(object id);
        IEnumerable<T> FindMany(Expression<Func<T, bool>> expresion, params string[] includes);
        void Update(T entity);
        Task UpdateAsync(T entity);
        void Add(T entity);
        Task AddAsync(T entity);
        Task Insert(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
        IQueryable<T> Table { get; }
        IQueryable<T> TableNoTracking { get; }
    }
}
