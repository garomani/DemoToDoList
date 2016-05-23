using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApplication.BusinessLayer.Repositories.Interfaces;
using ToDoListApplication.BusinessLayer.Services.DataContracts;
using ToDoListApplication.BusinessLayer.Mappers;

namespace ToDoListApplication.BusinessLayer.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IPersonRepository _personRepository;

        public TaskService(ITaskRepository taskRepository,
                           IPersonRepository personRepository)
        {
            _taskRepository = taskRepository;
            _personRepository = personRepository;
        }

        public TaskListData GetAllTask(string filter)
        {
            var list = _taskRepository.FindAll(filter);
            var persons = _personRepository.FindAll("").ToList();
            var data = list.Select(m => m.MapToTaskData(persons)).ToList();

            return new TaskListData
            {
                Values = data,
                Count = data.Count
            };
        }

        public TaskData GetById(int id)
        {
            var task = _taskRepository.FindById(id);
            var persons = _personRepository.FindAll("").ToList();
            return task.MapToTaskData(persons);
        }


        public TaskData Create(TaskData task)
        {
            var taskEntity = task.MapToTask();
            int newInt = _taskRepository.FindAll("").Max(t => t.Id);
            var persons = _personRepository.FindAll("").ToList();
            taskEntity.Id = newInt + 1;

            _taskRepository.Add(taskEntity);
            return taskEntity.MapToTaskData(persons);

        }

        public TaskData Update(TaskData task)
        {
            var persons = _personRepository.FindAll("").ToList();
            var taskEntity = task.MapToTask();
            var existingTask = _taskRepository.FindById(taskEntity.Id);

            existingTask.Description = taskEntity.Description;
            existingTask.PersonId = taskEntity.PersonId;

            _taskRepository.Update(existingTask);
            return taskEntity.MapToTaskData(persons);

        }

        public bool Delete(int id)
        {
            var persons = _personRepository.FindAll("").ToList();
            var existingTask = _taskRepository.FindById(id);

            _taskRepository.Delete(existingTask);
            return true;

        }

        public TaskData Complete(int id)
        {
            var persons = _personRepository.FindAll("").ToList();
            var existingTask = _taskRepository.FindById(id);

            existingTask.CompletionDate = DateTime.Now;
            _taskRepository.Update(existingTask);

            return existingTask.MapToTaskData(persons);
        }


        public TaskListData GetAllTaskPendingCompletion()
        {
            var persons = _personRepository.FindAll("").ToList();
            var tasks = _taskRepository.FindAll("");

            var data = tasks.Where(t => t.CompletionDate == null).Select(t => t.MapToTaskData(persons)).ToList();

            return new TaskListData
            {
                Values = data,
                Count = data.Count
            };
        }


        public TaskListData GetAllTaskComplete()
        {
            var persons = _personRepository.FindAll("").ToList();
            var tasks = _taskRepository.FindAll("");

            var data = tasks.Where(t => t.CompletionDate != null).Select(t => t.MapToTaskData(persons)).ToList();

            return new TaskListData
            {
                Values = data,
                Count = data.Count
            };
        }
    }
}
