using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Repositories.Abstractions;

namespace WebApplication1.Repositories.Implementations
{
    public class TrainerRepositories : ITrainerRepositories
    {
        public TrainerContext DataBaseContext { get; set; }
        public TrainerRepositories(TrainerContext trainerContext)
        {
            DataBaseContext = trainerContext;
        }
        public async Task<IEnumerable<Trainer>> List()
        {
            return await DataBaseContext.Trainers.ToListAsync();
        }
    }
}
