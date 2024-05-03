using ToDoAPI.Models;

namespace ToDoAPI.Repositorys
{
    public interface ISystemRepository
    {
        TaskDetails[] GetAllTasks();
        bool AddTask(TaskDetails task);
        bool DeleteTasks(Guid[] ids);
    }
}
