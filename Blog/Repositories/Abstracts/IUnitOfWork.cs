using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Repositories.Abstracts
{
    public interface IUnitOfWork
    {
        void Save();
    }
}
