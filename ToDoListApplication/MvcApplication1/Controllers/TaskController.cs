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
    public class TaskController : ApiController
    {
        ITaskService _service;

        public TaskController(ITaskService service)
        {
            _service = service;
        }

        [HttpGet]
        public TaskData GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public HttpResponseMessage Create(TaskData task)
        {
            try 
	        {	        
		        var newTask = _service.Create(task);
                return this.Request.CreateResponse(HttpStatusCode.OK, newTask);
	        }
	        catch (Exception ex)
	        {
		
		       return this.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
	        }
             
        }

        [HttpPut]
        public HttpResponseMessage Mofify(TaskData task)
        {
            try 
	        {	        
		        var newTask = _service.Update(task);
                return this.Request.CreateResponse(HttpStatusCode.OK, newTask);
	        }
	        catch (Exception ex)
	        {
		
		       return this.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
	        }
        }

        [HttpDelete]
        public HttpResponseMessage Remoce(int id)
        {
            try
            {
                var newTask = _service.Delete(id);
                return this.Request.CreateResponse(HttpStatusCode.OK, newTask);
            }
            catch (Exception ex)
            {

                return this.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpPost]
        public HttpResponseMessage CompleteTask(int id)
        {
            try
            {
                var newTask = _service.Complete(id);
                return this.Request.CreateResponse(HttpStatusCode.OK, newTask);
            }
            catch (Exception ex)
            {

                return this.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

    }
}
