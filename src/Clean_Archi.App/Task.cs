using System;

namespace Clean_Archi.App
{
    public class Task
    {
        public string name { get; set;}
        public DateTime creationDate { get; }

        public bool done {get; set;}

        public Task(string name, DateTime creationDate){
            this.name = name;
            this.creationDate = creationDate;
            this.done = false;
        }
    }
}
