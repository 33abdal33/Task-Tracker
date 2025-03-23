using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Tracker.Models;

namespace Task_Tracker.Interfaces
{
    public interface ITaskServices
    {
        Task<IEnumerable<TaskModel>> GetAllTasks();
        Task<TaskModel> GetTask(int id);
        Task<TaskModel> AddTask(TaskModel task);
        Task<TaskModel> UpdateTask(TaskModel task);
        Task<TaskModel> DeleteTask(int id);
        Task<TaskModel> SetStatus(int id, bool status);
        Task<IEnumerable<TaskModel>> GetTaskByStatus(bool status);

    }
}
