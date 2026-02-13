using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tasks.Aplication.UsersCase;
using Tasks.Aplication.UsersCase.Tasks;
using Tasks.Communication.Requests;
using Tasks.Communication.Responses;

namespace TasksManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tasks(CreatNewTask useCase, GetAllTasks getAllTasks, GetTaskById getTaskById, UpdateTask updateTask) : ControllerBase
    {


        [HttpPost]
        [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateTask(RequestTaskJson request)
        {
            var response = useCase.Execute(request);

            return Created(string.Empty, response);

        }
        [HttpGet]
        [ProducesResponseType(typeof(List<ResponseTaskJson>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]

        public IActionResult GetTasks()
        {
            var tasks = getAllTasks.Execute();
            if (tasks == null || tasks.Count == 0)
            {
                return NoContent();
            }
            return Ok(tasks);
        }
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetTask(string id)
        {
            var task = getTaskById.Execute(id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
     
        }
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public IActionResult UpdateTask(string id, RequestTaskJson request)
        {
            var success = updateTask.Execute(id, request);
            if (!success)
            {
                return NotFound();
            }
            return NoContent();
        }

    }
}
