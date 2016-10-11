namespace TodoApp.Models
{
    using System.Data.Entity;

    /// <summary>
    /// The database context for the To dos.
    /// </summary>
    public class TodoContext : DbContext
    {
        /// <summary>
        /// Gets or sets the Category database set.
        /// </summary>
        public DbSet<Category> Category { get; set; }

        /// <summary>
        /// Gets or sets the To do database set.
        /// </summary>
        public DbSet<Todo> Todo { get; set; }
    }
}