using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class TodoList
    {
        private List<Task> tasks = new List<Task>();
        private int nextId = 1;

        public void AddTask(string description)
        {
            tasks.Add(new Task { Id = nextId++, Description = description, IsCompleted = false });
            Console.WriteLine("Задача добавлена.");
        }

        public void ViewTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Список задач пуст.");
                return;
            }

            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
        }

        public void RemoveTask(int id)
        {
            var task = tasks.Find(t => t.Id == id);
            if (task != null)
            {
                tasks.Remove(task);
                Console.WriteLine("Задача удалена.");
            }
            else
            {
                Console.WriteLine("Задача не найдена.");
            }
        }

        public void MarkTaskAsCompleted(int id)
        {
            var task = tasks.Find(t => t.Id == id);
            if (task != null)
            {
                task.IsCompleted = true;
                Console.WriteLine("Задача помечена как выполненная.");
            }
            else
            {
                Console.WriteLine("Задача не найдена.");
            }
        }
    }
}
