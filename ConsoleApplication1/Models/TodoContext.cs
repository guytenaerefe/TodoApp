using System.Data.Entity;

namespace TodoApp.Models
{
    public class TodoContext : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Todo> Todo { get; set; }
    }

}