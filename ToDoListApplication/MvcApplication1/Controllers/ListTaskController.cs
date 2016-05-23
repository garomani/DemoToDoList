using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ToDoListApplication.BusinessLayer.Services;
using ToDoListApplication.BusinessLayer.Services.DataContracts;

namespace MvcApplication1.Controllers
{
    public class ListTaskController : ApiController
    {
        ITaskService _service;

        public ListTaskController(ITaskService service)
        {
            _service = service;
        }

        [HttpGet]
        public TaskListData GetAllTasks(string filter)
        {
            return _service.GetAllTask(filter);
        }

        [HttpGet]
        public TaskListData GetAllPendingCompletion()
        {
            return _service.GetAllTaskPendingCompletion();
        }

        [HttpGet]
        public TaskListData GetAllComplete()
        {
            return _service.GetAllTaskComplete();
        }
    }
}
