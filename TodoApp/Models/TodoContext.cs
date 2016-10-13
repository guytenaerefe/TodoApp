namespace TodoApp.Models
{
    using System.Data.Entity;

    /// <summary>
    /// The database context for the To dos.
    /// </summary>
    public class TodoContext : DbContext
    {
        private static TodoContext instance;

        public static TodoContext CreateInstance()
        {
            if (instance == null)
            {
                instance = new TodoContext();
            }
            return instance;
        } 

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