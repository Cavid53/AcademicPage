﻿using Academic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academic.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<RepeatTitle> RepeatTitles { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
