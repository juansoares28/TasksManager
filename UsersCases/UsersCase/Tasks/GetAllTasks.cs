using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Communication.Responses;
using Tasks.Domain;
using Tasks.Infrastructure_;

namespace Tasks.Aplication.UsersCase.Tasks
{
    public class GetAllTasks(ITaskRepository database)
    {
        public List<ResponseTaskJson> Execute()
        {
            var databaseTasks = database.GetAllTasks();
            var responseTasks = new List<ResponseTaskJson>();
            foreach (var task in databaseTasks)
            { 
                var responseTask = new ResponseTaskJson(task.ID, task.Title, task.Priority);
                responseTasks.Add(responseTask);
            }
            return responseTasks;
        }
    }
}




