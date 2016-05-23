using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApplication.BusinessLayer.Services.DataContracts;

namespace ToDoListApplication.BusinessLayer.Services
{
    public interface ITaskService
    {
        TaskListData GetAllTask(string filter);
        TaskData GetById(int id);

        TaskData Create(TaskData task);

        TaskData Update(TaskData task);

        bool Delete(int id);

        TaskData Complete(int id);

        TaskListData GetAllTaskPendingCompletion();

        TaskListData GetAllTaskComplete();
    }
}
