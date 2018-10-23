using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_2_Tasklist
{
    class App
    {
        TaskList t = new TaskList();

        public App()
        {
            Task t1 = new Task("Get Bread", "We're low on bread, I like wheat");
            Task t2 = new Task("Mow Lawn", "The neighbors are getting on us again over the grass.");

            t.Add(t1);
            t.Add(t2);
        }

        public void Run()
        {
            bool goOn = true;
            while (goOn)
            {                
                Console.WriteLine("Hello! Welcome to the Task List");
                Console.WriteLine("Here are your options: ");
                Console.WriteLine("1) List out your tasks");
                Console.WriteLine("2) Add a new Task");
                Console.WriteLine("3) Delete a Task");
                Console.WriteLine("4) Mark a task Complete");
                Console.WriteLine("5) Exit");
                string input = Console.ReadLine();

                input.Trim();

                switch (input)
                {
                    case "1":
                        t.PrintTasks();
                        break;
                    case "2":
                        Task newTask = MakeTask();
                        t.Add(newTask);
                        Console.WriteLine("Task Added: ");
                        t.PrintTasks();
                        break;
                    case "3":
                        t.PrintTasks();
                        Console.WriteLine("Select a number to delete a task!");
                        string index = Console.ReadLine();
                        int i;
                        if (int.TryParse(index, out i))
                        {
                            Task del = t.GetTask(i -1);
                            if (del != null)
                            {
                                t.Delete(del);
                            }
                        }
                        t.PrintTasks();
                        break;
                    case "4":
                        t.PrintTasks();
                        Console.WriteLine("Select a task to mark!");
                        string spot = Console.ReadLine();
                        int j;
                        if (int.TryParse(spot, out j))
                        {
                            Task com = t.GetTask(j - 1);
                            if (com != null)
                            {
                                t.MarkComplete(com);
                            }
                        }
                        Console.WriteLine("New List: ");
                        t.PrintTasks();
                        break;
                    case "5":
                        goOn = false;
                        break;

                        
                }
                Console.WriteLine("Press any key to go on...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public Task MakeTask()
        {
            Console.WriteLine("We will build our task:");
            Console.WriteLine("What is the name of the task you wish to make?");
            string name = Console.ReadLine();

            Console.WriteLine("What is the description you wish to write for your task?");
            string desc = Console.ReadLine();

            Task newTask = new Task(name, desc);
            return newTask;
        }
    }
}
