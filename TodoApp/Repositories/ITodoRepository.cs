namespace TodoApp.Repositories
{
    using System;
    using System.Collections.Generic;
    using TodoApp.Models;

    public interface ITodoRepository : IDisposable
    {
        /// <summary>
        /// Get the To dos.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Todo> GetTodos();

        /// <summary>
        /// Get a To do by Id.
        /// </summary>
        /// <returns></returns>
        Todo GetTodoById(int id);

        /// <summary>
        /// Insert a new To do.
        /// </summary>
        void InsertTodo();

        /// <summary>
        /// Delete a To do.
        /// </summary>
        void DeleteTodo();

        /// <summary>
        /// Update a To do.
        /// </summary>
        void UpdateTodo();

    }
}
