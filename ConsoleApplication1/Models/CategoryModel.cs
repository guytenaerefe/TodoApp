
namespace TodoApp.Models
{
    using System.Collections.Generic;
    public class Category
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public List<Todo> Todo { get; set; }
    }
}
