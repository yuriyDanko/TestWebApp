﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class TrainerContext : DbContext
    {
        public TrainerContext(DbContextOptions<TrainerContext> options) : base(options)
        {

        }

        public DbSet<Trainer> Trainers { get; set; }
    }
}
