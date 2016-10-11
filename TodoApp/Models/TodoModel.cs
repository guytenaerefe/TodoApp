namespace TodoApp.Models
{
    using System;

    /// <summary>
    /// The Todo Item.
    /// </summary>
    public class Todo
    {
        /// <summary>
        /// Auto Increment Id.
        /// </summary>
        public int TodoId { get; set; }

        /// <summary>
        /// Title of the Todo.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Content of the Todo.
        /// </summary>
        public string Content { get; set; }

        public DateTime deletedAt { get; set; }

        /// <summary>
        /// Category Id of the Todo.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Category this Todo Belongs to, based on the Id.
        /// </summary>
        public Category Category { get; set; }
    }
}
