using System;
using System.Collections.Generic;

namespace Clean_Archi.App
{
    public class TaskDate
    {

        public static string timeToString(TimeSpan time){
             if(time.Days > 30){
                 return time.Days/30 + "Month";             }
            else if(time.Days > 7){
                return time.Days/7 + "Week";  
            }
            else if (time.Days > 0){
                return time.Days + "Day";
            }
            else{
                return time.Hours + "Hours";
            }
            
        }

        public TimeSpan calculateTimeSinceCreation(Task task){
            return DateTime.Now.Subtract(task.creationDate);
        }

    }
}
