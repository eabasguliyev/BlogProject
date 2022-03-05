using Blog.Context.Data;
using Blog.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;

        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
            BlogRepository = new BlogRepository(context);
            UserRepository = new UserRepository(context);
        }

        public IBlogRepository BlogRepository { get; set; }

        public IUserRepository UserRepository { get; set; }

        public void Save()
        {
            this.context.SaveChanges();
        }
    }
}
