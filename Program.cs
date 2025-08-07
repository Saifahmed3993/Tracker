using System;
using System.Diagnostics;

namespace Tracker
{
    internal class Program
    {
        static string[] tasks = new string[100];
        static int taskIndex = 0;

        static void Main(string[] args)
        {
            Console.Title = "📝 Task Tracker";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========================================");
            Console.WriteLine("       📝 Welcome to Tracker Task       ");
            Console.WriteLine("========================================");
            Console.ResetColor();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1️⃣  Add task");
                Console.WriteLine("2️⃣  View tasks");
                Console.WriteLine("3️⃣  Mark task as complete");
                Console.WriteLine("4️⃣  Remove task");
                Console.WriteLine("5️⃣  Exit");
                Console.WriteLine("------------------------------");
                Console.Write("👉 Enter your choice (1-5): ");
                Console.ResetColor();

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        VTasks();
                        break;
                    case "3":
                        MarkCom();
                        break;
                    case "4":
                        RemoveCom();
                        break;
                    case "5":
                        Console.WriteLine("\n👋 Exiting... Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("❌ Invalid input. Please enter a number from 1 to 5.");
                        Console.ResetColor();
                        break;
                }
            }
        }

        private static void AddTask()
        {
            Console.Write("\n📝 Enter your task: ");
            string taskTitle = Console.ReadLine();
            tasks[taskIndex] = taskTitle;
            taskIndex++;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("✅ Task added successfully!");
            Console.ResetColor();
        }

        private static void VTasks()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n📋 Your Task List:");
            Console.ResetColor();

            if (taskIndex == 0)
            {
                Console.WriteLine("😴 No tasks yet.");
                return;
            }

            for (int i = 0; i < taskIndex; i++)
            {
                if (!string.IsNullOrEmpty(tasks[i]))
                    Console.WriteLine($"🔹 {i + 1}. {tasks[i]}");
            }
        }

        private static void MarkCom()
        {
            Console.Write("\n✅ Enter Task Number to mark as complete: ");
            string input = Console.ReadLine();
            int taskId = Convert.ToInt32(input);
            taskId -= 1;
            tasks[taskId] = tasks[taskId] + " -- ✅ Complete";
            Console.WriteLine("🎉 Task marked as complete!");
        }

        private static void RemoveCom()
        {
            Console.Write("\n🗑️ Enter Task Number to remove: ");
            string input = Console.ReadLine();
            int taskId = Convert.ToInt32(input);
            taskId -= 1;
            tasks[taskId] = string.Empty;
            Console.WriteLine("🧹 Task removed.");
        }
    }
}
