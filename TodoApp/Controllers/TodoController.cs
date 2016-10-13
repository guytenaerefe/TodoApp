namespace TodoApp.Controllers
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using TodoApp.Models;
    using TodoApp.Repositories;

    class TodoController
    {
        private ITodoRepository todoRepository;
        private static TodoController controller;

        public static TodoController CreateInstance()
        {
            if (controller == null)
            {
                controller = new TodoController();
            }
            return controller;
        }

        public TodoController()
        {
            this.todoRepository = new TodoRepository(TodoContext.CreateInstance());
        }


        public TodoController(ITodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        public IEnumerable<Todo> GetAll()
        {
            return this.todoRepository.GetTodos();
        }

        public IEnumerable<Todo> SearchTodos(string query)
        {
            return this.GetAll().Where(t => t.Title.Contains(query) || t.Content.Contains(query));
        }
    }
}
