using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApplication.BusinessLayer.Services.DataContracts;

namespace ToDoListApplication.BusinessLayer.Services
{
    public interface IPersonService
    {
        PersonListData GetAll();
    }
}
