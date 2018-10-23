using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_2_Tasklist
{
    class Task
    {
        private string name;
        private string desc;
        private bool complete = false;

        public string Name { get { return name; } }

        public Task(string name, string desc)
        {
            this.name = name;
            this.desc = desc;
        }

        public void MarkComplete()
        {
            complete = true;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine($"Description: {desc}");
            Console.WriteLine($"Completed: {complete}");
        }
    }
}
