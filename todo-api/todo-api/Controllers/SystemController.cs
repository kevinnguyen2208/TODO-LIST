using Microsoft.AspNetCore.Mvc;
using ToDoAPI.Models;
using ToDoAPI.Services;

namespace ToDoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemController : ControllerBase
    {
        private readonly ISystemService _systemService;

        public SystemController(ISystemService systemService)
        {
            _systemService = systemService;
        }

        [HttpGet]
        public TaskDetails[] GetAllTasks()
        {
            return _systemService.GetAllTasks();
        }

        [HttpPost("add")]
        public bool AddTask([FromBody] TaskDetails task)
        {
            return _systemService.AddTask(task);
        }

        [HttpPost("delete")]
        public bool RemoveTasks([FromBody] Guid[] ids)
        {
            return _systemService.DeleteTasks(ids);
        }
    }
}
