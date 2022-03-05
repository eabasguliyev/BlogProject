using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.Repositories.Abstracts
{
    public interface IRepository<T> where T : IEntity
    {
        T Find(int id, string? includeProperties = null);
        T GetFirstOrDefault(Expression<Func<T, bool>> expression, string? includeProperties = null);
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? expression = null, string? includeProperties = null);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
