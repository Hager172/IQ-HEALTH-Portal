using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace IQHealthPortal.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<T?> FindAsync(Expression<Func<T, bool>> predicate);
        Task<List<T>> FindAllAsync(Expression<Func<T, bool>>? predicate=null, string[]? includes = null);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
