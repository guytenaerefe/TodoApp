namespace TodoApp.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Categories for the To dos.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets or sets Auto increment PK of the Category.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets Title of the Category.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets List with To dos.
        /// </summary>
        public List<Todo> Todo { get; set; }
    }
}
