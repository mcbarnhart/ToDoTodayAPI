﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoTodayAPI.Models.Api;
using ToDoTodayAPI.Models;

namespace ToDoTodayAPI.Data.Repositories
{
    public interface ITaskRepository
    {
        Task<List<TaskDTO>> GetAllTasks();

        Task<List<TaskDTO>> GetAllMyTasks(string userId);

        Task<TaskDTO> GetOneTask(int id);

        Task<TaskItem> EditTask(int id, TaskItem task);

        Task AddTask(TaskItem task);

        Task DeleteTask(int id);
    }
}