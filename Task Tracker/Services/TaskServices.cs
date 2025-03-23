using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Tracker.Interfaces;
using Task_Tracker.Models;

namespace Task_Tracker.Services
{
    public class TaskServices : ITaskServices
    {
        public static string FileName = "task_data.json";
        private static string FilePath = Path.Combine(Directory.GetCurrentDirectory(), FileName);
        Task<TaskModel> ITaskServices.AddTask(TaskModel task)
        {
            try
            {
                var appTasks = new List<TaskModel>();
                var tasks = 
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        Task<TaskModel> ITaskServices.DeleteTask(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<TaskModel>> ITaskServices.GetAllTasks()
        {
            throw new NotImplementedException();
        }

        Task<TaskModel> ITaskServices.GetTask(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<TaskModel>> ITaskServices.GetTaskByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        Task<TaskModel> ITaskServices.SetStatus(int id, bool status)
        {
            throw new NotImplementedException();
        }

        Task<TaskModel> ITaskServices.UpdateTask(TaskModel task)
        {
            throw new NotImplementedException();
        }
    }
}
