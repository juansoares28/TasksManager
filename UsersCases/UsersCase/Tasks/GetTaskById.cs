using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Communication.Responses;
using Tasks.Infrastructure_;

namespace Tasks.Aplication.UsersCase.Tasks
{
    public class GetTaskById (ITaskRepository database)
    {
        public ResponseTaskJson? Execute(string id)
        {
            var task = database.GetTaskById(id);
            if (task == null)
            {
               return null;
            }
            var responseTask = new ResponseTaskJson(task.ID, task.Title, task.Priority);
            
            return  responseTask;
        }
    }
}
