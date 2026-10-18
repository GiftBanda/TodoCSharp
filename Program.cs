using System;

// public class Calculator

// {
//     public static int number1;
//     public static int number2;
//     public static int Add(int a, int b)
//     {
//         return a + b;
//     }

//     static void Main(string[] args)
//     {
//         int result = Add(5, 10);
//         Console.WriteLine("The sum:" + result);
//     }
// }

// public class NumberDisplay
// {
//     public static void DisplayNumbers()
//     {
//         for (int i = 1; i <= 20; i++)
//         {
//             Console.WriteLine(i);
//         }
//     }

//     static void Main(string[] args)
//     {
//         DisplayNumbers();
//     }
// }

// public class UserInput()
// {
//     static void GreetUser()
//     {
//         Console.WriteLine("Enter your name:");
//         string name = Console.ReadLine();
//         Console.WriteLine("Hello, " + name + "!");
//     }

//     static void Main(string[] args)
//     {
//         GreetUser();
//     }
// }

class ToDoList
{
    public static string[] tasks = new string[10];
    public static int taskCount = 0;

    public static void AddTask()
    {
        Console.WriteLine("Please Enter a Task");
        string task = Console.ReadLine();
        if (taskCount < tasks.Length)
        {
            tasks[taskCount] = task;
            taskCount++;
            Console.WriteLine("Task added: " + task);
        }
        else
        {
            Console.WriteLine("Task list is full.");
        }
    }

    public static void ViewTasks()
    {
        for (int i = 0; i < taskCount; i++)
        {
            Console.WriteLine((i + 1) + ". " + tasks[i]);
        }
    }


    public static void CompleteTask()
    {
        Console.WriteLine("Enter the task number to complete:");
        int taskNumber = Convert.ToInt32(Console.ReadLine());
        if (taskNumber > 0 && taskNumber <= taskCount)
        {
            Console.WriteLine("Task completed: " + tasks[taskNumber - 1]);
            for (int i = taskNumber - 1; i < taskCount - 1; i++)
            {
                tasks[i] = tasks[i + 1];
            }
            tasks[taskCount - 1] = null;
            taskCount--;
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }


    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("To-Do List Application");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Complete Task");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    CompleteTask();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}