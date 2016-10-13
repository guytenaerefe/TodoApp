namespace TodoApp
{
    using System;
    using System.Linq;
    using TodoApp.Controllers;
    using Models;
    using System.Collections.Generic;

    /// <summary>
    /// To do Application.
    /// </summary>
    public class Program
    {
        private static TodoController controller;

        /// <summary>
        /// Run the main program.
        /// </summary>
        public static void Main()
        {
            controller = TodoController.CreateInstance();
            Console.WriteLine("Make a choice:");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("(1) List all Todos");
            Console.WriteLine("(2) Populate Example Todo and Category");
            Console.WriteLine("(3) Search Todos");
            Console.WriteLine("(4) Mark Todo as done");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("(X) Exit ");
            Console.WriteLine();
            var key = Console.ReadKey();
            switch (key.KeyChar.ToString().ToUpper())
            {
                case "2":
                    Populate();
                    break;
                case "3":
                    Search();
                    break;
                case "X":
                    Exit(0);
                    break;
                case "1":
                default:
                    List();
                    break;
            }
        }

        /// <summary>
        /// Exit the Application with supplied exit-code.
        /// </summary>
        /// <param name="code">Exit code</param>
        private static void Exit(int code)
        {
            Environment.Exit(code);
        }

        /// <summary>
        /// Search the To dos.
        /// </summary>
        private static void Search()
        {
            Console.WriteLine("Search query:");
            var input = Console.ReadLine();
            //using (var db = new TodoContext()) 
            //{
                var todos = controller.SearchTodos(input);
                if (todos.Count() > 0)
                {
                    foreach (Todo todo in todos)
                    {
                        Console.WriteLine("{0} : {1}", todo.Title, todo.Content);
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("No todos found containing the query {0}", input);
                    Console.WriteLine();
                }
            //}
            
            Main();
        }

        /// <summary>
        /// List the To dos.
        /// </summary>
        private static void List()
        {
            using (var db = new TodoContext())
            {
                Console.WriteLine("All todos in database:");
                if (db.Todo.Count() > 0)
                {
                    foreach (var todo in db.Todo)
                    {
                        Console.WriteLine(" - {0}", todo.Title);
                    }
                }
                else
                {
                    Console.WriteLine("There are no Todo's");
                }
            }

            Main();
        }

        /// <summary>
        /// Supposed to run only once as a seed. I realize there is a Seed method.
        /// </summary>
        private static void Populate()
        {
            using (var db = new TodoContext())
            {
                Category cat = db.Category.Where(c => c.Title == "Household").FirstOrDefault();
                if (null == cat)
                {
                    db.Category.Add(new Category { Title = "Household" });
                    db.SaveChanges();
                }
                else
                {
                    Console.WriteLine("This Category has already been added!");
                    Console.WriteLine();
                }

                Todo todo = db.Todo.Where(t => t.Title.Contains("Flea Drops")).FirstOrDefault();
                if (null == todo)
                {
                    db.Todo.Add(new Todo { Title = "Flea drops on cats", Content = "Give the cats some flea drops", Category = cat });
                    var count = db.SaveChanges();
                    Console.WriteLine("{0} records saved to database", count);
                    Console.WriteLine();
                }

                List();
            }
        }
    }
}
