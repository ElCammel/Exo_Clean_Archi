using System;
using System.Collections.Generic;

namespace Clean_Archi.App
{
    public class TaskOrchestrator
    {
        TaskUpdater taskUpdater;
        TaskManager taskManager;

        public TaskOrchestrator(TaskManager taskManager, TaskUpdater taskUpdater){
            this.taskUpdater.taskManager = taskManager;
            this.taskManager = taskManager;
        }

        public void CreateTask(string name){
            DateTime creationDate = DateTime.Now;
            Task task = new Task(name, creationDate);
            this.taskManager.AddTask(task);
        }

    }
}
