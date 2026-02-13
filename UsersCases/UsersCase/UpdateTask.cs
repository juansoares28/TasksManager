using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Communication.Requests;
using Tasks.Infrastructure_;

namespace Tasks.Aplication.UsersCase
{
    public  class UpdateTask (ITaskRepository database)
    {
        public bool Execute(string id, RequestTaskJson request)
        {
            var task = database.GetTaskById(id);

            if (task is null)
            {
                return false; 
            }

            task.Title = request.Title;
            task.Description = request.Description;
            task.Priority = request.Priority;

            database.UpdateTask(task);

            return true; 
        }
    }
}
