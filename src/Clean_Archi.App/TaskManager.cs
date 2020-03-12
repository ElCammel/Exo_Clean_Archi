using System;
using System.Collections.Generic;

namespace Clean_Archi.App
{
    public class TaskManager
    {
        public List<Task> todoTasks { get; set;}

        public TaskManager(List<Task> tasks){
            this.todoTasks = tasks;
        }

        public void AddTask(Task task){
           this.todoTasks.Add(task); 
        }

    }
}
