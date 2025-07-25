﻿using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Persistence
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        public required DbSet<Activity> Activities { get; set; }

    }
}
