using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Domain;

namespace Tasks.Infrastructure_
{
    public class InMemory : ITaskRepository
    {
        private readonly List<TaskItem> _TaskItems = new();

        public TaskItem AddTask(TaskItem task)
        {
            _TaskItems.Add(task);
            return task;
        }
        public TaskItem GetTaskById(string id)
        {
            return _TaskItems.Find(t => t.ID == id);
        }
        public void DeleteTask(string id)
        {
            var task = GetTaskById(id);
            if (task != null)
            {
                _TaskItems.Remove(task);
            }
        }
        public void UpdateTask(TaskItem taskItem)
        {
            var existingTask = _TaskItems.FirstOrDefault(t => t.ID == taskItem.ID);
            
            if (existingTask != null)
            {
                existingTask.Title = taskItem.Title;
                existingTask.Description = taskItem.Description;
                existingTask.Priority = taskItem.Priority;
            }
        }
        public List <TaskItem> GetAllTasks()
        { 
            return _TaskItems;
        }

    }
}
