using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Repositories.Abstractions;
using WebApplication1.Services.Abstractions;

namespace WebApplication1.Services.Implementations.TrainerService
{
    public class TrainerService : ITrainerService
    {
        public ITrainerRepositories  TrainerRepositories{get; set;}
        public TrainerService(ITrainerRepositories trainerRepositories)
        {
            TrainerRepositories = trainerRepositories;
        }
        public async Task<IEnumerable<Trainer>> GetAll()
        {
            return await TrainerRepositories.List();
        }
    }
}
