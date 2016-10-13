
namespace TodoApp.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Models;

    class TodoRepository : ITodoRepository
    {
        private TodoContext todoContext;

        public TodoRepository(TodoContext context)
        {
            this.todoContext = context;
        }

        public IEnumerable<Todo> GetTodos()
        {
            return this.todoContext.Todo.ToList();
        }

        public Todo GetTodoById(int id)
        {
            return this.todoContext.Todo.Where(t => t.TodoId == id) as Todo;
        }

        public void InsertTodo()
        {
            throw new NotImplementedException();
        }
        public void UpdateTodo()
        {
            throw new NotImplementedException();
        }
        public void DeleteTodo()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            this.todoContext.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
