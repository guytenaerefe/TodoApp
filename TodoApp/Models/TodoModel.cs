namespace TodoApp.Models
{
    using System;

    /// <summary>
    /// The To do Item.
    /// </summary>
    public class Todo
    {
        /// <summary>
        /// Gets or sets Auto Increment Id.
        /// </summary>
        public int TodoId { get; set; }

        /// <summary>
        /// Gets or sets Title of the To do.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Content of the To do.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the DeletedAt Date time.
        /// </summary>
        public DateTime DeletedAt { get; set; }

        /// <summary>
        /// Gets or sets Category Id of the To do.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets Category this To do Belongs to, based on the Id.
        /// </summary>
        public Category Category { get; set; }
    }
}
