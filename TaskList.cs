using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_2_Tasklist
{
    class TaskList
    {
        private List<Task> tasks = new List<Task>();

        public void Add(Task t)
        {
            tasks.Add(t);
        }
        public Task GetTask(int i)
        {
            if (i < tasks.Count)
            {
                return tasks[i];
            }
            else
            {
                Console.WriteLine("There is no task at index: " + i);
                return null;
            }
        }

        public void Delete(Task t)
        {
            Console.WriteLine(tasks.Contains(t));
            if (tasks.Contains(t))
            {
                
                tasks.Remove(t);
            }
            else
            {
                Console.WriteLine("Task was not found in the list");
                Console.WriteLine("Nothing was Deleted");
            }
        }

        public void MarkComplete(Task t)
        {
            if (tasks.Contains(t))
            {
               int i = tasks.IndexOf(t);
                Task s = tasks[i];
                s.MarkComplete();
            }
            else
            {
                Console.WriteLine($"Task {t.Name} does not exist in the list, so nothing was deleted.");
            }
        }

        public void PrintTasks()
        {
            for(int i = 0; i < tasks.Count; i++)
            {
                Task t = tasks[i];
                Console.Write(i +1 +": ");
                t.PrintInfo();
                Console.WriteLine();
            }
           
        }

    }
}
