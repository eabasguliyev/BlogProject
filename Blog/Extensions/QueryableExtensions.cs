using Blog.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> IncludeProperties<T>(this IQueryable<T> query, string includeProperties) where T : class, IEntity
        {
            var properties = includeProperties.Split(',', StringSplitOptions.RemoveEmptyEntries);
            foreach (var property in properties)
            {
                query = query.Include(property);

            }

            return query;
        }
    }
}
