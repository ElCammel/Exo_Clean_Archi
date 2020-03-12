using System;
using System.Collections.Generic;

namespace Clean_Archi.App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks;
            if(args[0].Length > 0){
                tasks = args[0];
            }
            else{
                tasks = new List<Task>();
            }
            TaskManager taskManager = new TaskManager(tasks);
            TaskUpdater taskUpdater = new TaskUpdater();

            TaskOrchestrator taskOrchestrator = new TaskOrchestrator(taskManager, taskUpdater);
        }
    }
}
