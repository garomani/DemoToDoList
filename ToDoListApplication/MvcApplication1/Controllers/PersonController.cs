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
    public class PersonController : ApiController
    {
        IPersonService _service;

        public PersonController(IPersonService service)
        {
            _service = service;
        }

        [HttpGet]
        public PersonListData Get()
        {
            return _service.GetAll();
        }
    }
}
