﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Infrastructure.DataBase.Context
{
    public class ServerDbContext : DbContext
    {
        public ServerDbContext(DbContextOptions<ServerDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
