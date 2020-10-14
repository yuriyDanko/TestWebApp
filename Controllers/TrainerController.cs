using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services.Abstractions;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerController : ControllerBase
    {
        public ITrainerService TrainerService { get; set; }
        public TrainerController(ITrainerService trainerService)
        {
            TrainerService = trainerService;
        }

        [HttpGet]
        public async Task<IEnumerable<Trainer>> Get()
        {
           
            var res = await TrainerService.GetAll();
            return res;
        }
    }
}
