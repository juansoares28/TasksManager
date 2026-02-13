using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Communication.Requests;
using Tasks.Communication.Responses;
using Tasks.Domain;
using Tasks.Infrastructure_;
namespace Tasks.Aplication.UsersCase.Tasks
{
    public class CreatNewTask (ITaskRepository database)
    {
        public ResponseTaskJson Execute(RequestTaskJson request)
        {
            var newTask = new TaskItem( request.Title, request.Description, request.Priority);
            var databeseTask = database.AddTask(newTask);
            return new ResponseTaskJson(databeseTask.ID, databeseTask.Title, databeseTask.Priority);

        }

    }
}
