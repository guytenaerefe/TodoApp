namespace TodoApp
{
    using Models;
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Make a choice:");
            Console.WriteLine("--------------");
            Console.WriteLine("(1) List all Todos");
            Console.WriteLine("(2) Populate Example Todo and Category");
            var key = Console.ReadKey();
            switch (key.KeyChar.ToString())
            {
                case "1":
                    List();
                    break;
                case "2":
                    Populate();
                    break;
            }
        }

        public static void List()
        {
            using (var db = new TodoContext())
            {
                Console.WriteLine("All todos in database:");
                foreach (var todo in db.Todo)
                {
                    Console.WriteLine(" - {0}", todo.Title);
                }
            }
        }

        public static void Populate()
        {
            using (var db = new TodoContext())
            {
                Category cat = db.Category.Where(c => c.Title == "Household").FirstOrDefault();
                if (null == cat)
                {
                    db.Category.Add(new Category { Title = "Household" });
                    db.SaveChanges();
                    db.Todo.Add(new Todo { Title = "Flea drops on cats", Content = "Give the cats some flea drops", Category = cat });
                    var count = db.SaveChanges();
                    Console.WriteLine("{0} records saved to database", count);
                }
                else
                {
                    Console.WriteLine("This example has already been added!");
                    Console.WriteLine();
                }
                List();
            }
        }
    }
}
