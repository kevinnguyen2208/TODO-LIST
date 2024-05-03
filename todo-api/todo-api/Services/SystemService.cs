using ToDoAPI.Models;
using ToDoAPI.Repositorys;

namespace ToDoAPI.Services
{
    public class SystemService : ISystemService
    {
        private readonly ISystemRepository _systemRepository;
        public SystemService(ISystemRepository systemRepository)
        {
            _systemRepository = systemRepository;
        }

        public TaskDetails[] GetAllTasks()
        {
            return _systemRepository.GetAllTasks();
        }

        public bool AddTask(TaskDetails task)
        {
            return _systemRepository.AddTask(task);
        }

        public bool DeleteTasks(Guid[] ids)
        {
            return _systemRepository.DeleteTasks(ids);
        }
    }
}
