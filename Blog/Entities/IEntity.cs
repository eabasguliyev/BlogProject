using System;

namespace Blog.Entities
{
    public interface IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
