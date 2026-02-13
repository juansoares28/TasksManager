using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Communication.Requests;
using Tasks.Domain;

namespace Tasks.Infrastructure_
{
    public interface ITaskRepository
    {
        TaskItem AddTask(TaskItem task);
        TaskItem GetTaskById(string id);
            List<TaskItem> GetAllTasks();
            void UpdateTask(TaskItem taskItem);
            void DeleteTask(string id);

    }
}
