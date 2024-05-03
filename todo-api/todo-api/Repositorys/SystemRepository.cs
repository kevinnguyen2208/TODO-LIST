using Microsoft.Extensions.Caching.Memory;
using ToDoAPI.Models;

namespace ToDoAPI.Repositorys
{
    public class SystemRepository : ISystemRepository
    {
        private readonly IMemoryCache _memoryCache;
        private readonly string CacheKey = "Tasks";

        public SystemRepository(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public TaskDetails[] GetAllTasks()
        {
            var tasks = _memoryCache.Get<List<TaskDetails>>(CacheKey);
            return tasks?.ToArray() ?? new TaskDetails[] {};
        }

        public bool AddTask(TaskDetails task)
        {
            task.Id = Guid.NewGuid();
            task.CreatedOn = DateTime.Now;

            var tasks = GetAllTasks().ToList();
            tasks.Add(task);

            Update(tasks);

            return true;
        }

        public bool DeleteTasks(Guid[] ids)
        {
            var tasks = GetAllTasks().ToList();
            tasks.RemoveAll(i => ids.Any(id => id == i.Id));
            Update(tasks);

            return true;
        }

        private void Update(List<TaskDetails> tasks)
        {
            _memoryCache.Remove(CacheKey);
            _memoryCache.Set(CacheKey, tasks);
        }
    }
}
