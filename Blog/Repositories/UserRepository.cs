using Blog.Context.Data;
using Blog.Entities;
using Blog.Repositories.Abstracts;

namespace Blog.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
