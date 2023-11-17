using System;
using System.Collections.Generic;

class SimpleToDoList
{
    static void Main()
    {
        List<string> toDoList = new List<string>();

        while (true)
        {
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter task: ");
                    string task = Console.ReadLine();
                    toDoList.Add(task);
                    break;

                case 2:
                    Console.WriteLine("Tasks:");
                    foreach (var item in toDoList)
                        Console.WriteLine(item);
                    break;

                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
