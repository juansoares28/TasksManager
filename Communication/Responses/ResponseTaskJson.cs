using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Domain;

namespace Tasks.Communication.Responses
{
    public class ResponseTaskJson(string id, string title,TaskPriority priority)
    {
        public string ID { get; set; } = id;
        public  string Title { get; set; } = title;
        public TaskPriority Priority { get; set; } = priority;
    }
}
