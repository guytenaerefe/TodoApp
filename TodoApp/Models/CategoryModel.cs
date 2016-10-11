namespace TodoApp.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Categories for the Todos.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Auto increment PK of the Category.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Title of the Category.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// List with Todos.
        /// </summary>
        public List<Todo> Todo { get; set; }
    }
}
