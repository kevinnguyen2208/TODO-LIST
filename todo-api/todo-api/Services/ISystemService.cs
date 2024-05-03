using ToDoAPI.Models;

namespace ToDoAPI.Services
{
    public interface ISystemService
    {
        TaskDetails[] GetAllTasks();
        bool AddTask(TaskDetails task);
        bool DeleteTasks(Guid[] ids);
    }
}
