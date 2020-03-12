using System;
using System.Collections.Generic;
using System.Linq;

namespace Clean_Archi.App
{
    public class TaskUpdater
    {
        public TaskManager taskManager { get; set; }

        public Task MarkTaskAsDone(string name){
            List<Task> tasks = this.taskManager.todoTasks;
            int index = tasks.FindIndex(o => o.name.Equals(name));
            tasks[index].done = true;

            return tasks[index];
        }

        public List<Task> sortTasksByDateAscending(){
            return this.taskManager.todoTasks.OrderBy(task => task.creationDate).ToList();
        }
    }
}
