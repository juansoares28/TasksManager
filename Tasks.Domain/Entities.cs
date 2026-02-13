
namespace Tasks.Domain
{
    public class TaskItem ( string title, string description, TaskPriority priority)
    {
        public string ID { get; } = Guid.NewGuid().ToString().Substring(0,6).ToUpper();
        public  string Title { get; set;} = title;
        public  string Description { get; set;} = description;
        public TaskPriority Priority { get; set; } = priority;
        public bool IsCompleted { get;  private set;}

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }


    }
}
