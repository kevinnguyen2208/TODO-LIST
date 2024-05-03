namespace ToDoAPI.Models
{
    public class TaskDetails
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Priority Priority { get; set; }
    }

    public enum Priority
    {
        Low,
        Medium,
        High
    }
}
