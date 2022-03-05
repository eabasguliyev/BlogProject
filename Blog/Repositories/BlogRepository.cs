using Blog.Context.Data;
using Blog.Entities;
using Blog.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Repositories
{
    public class BlogRepository : Repository<BlogModel>, IBlogRepository
    {
        public BlogRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
