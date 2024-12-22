using ConsoleApp5;
using System;

class Program
{
    static void Main(string[] args)
    {
        TodoList todoList = new TodoList();

        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Просмотреть задачи");
            Console.WriteLine("3. Удалить задачу");
            Console.WriteLine("4. Пометить задачу как выполненную");
            Console.WriteLine("5. Выйти");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите описание задачи: ");
                    string description = Console.ReadLine();
                    todoList.AddTask(description);
                    break;
                case "2":
                    todoList.ViewTasks();
                    break;
                case "3":
                    Console.Write("Введите ID задачи для удаления: ");
                    if (int.TryParse(Console.ReadLine(), out int removeId))
                    {
                        todoList.RemoveTask(removeId);
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ID.");
                    }
                    break;
                case "4":
                    Console.Write("Введите ID задачи для пометки как выполненной: ");
                    if (int.TryParse(Console.ReadLine(), out int completeId))
                    {
                        todoList.MarkTaskAsCompleted(completeId);
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ID.");
                    }
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                    break;
            }
        }
    }
}