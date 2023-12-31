﻿using Domain.Models;
using Infrastructure.DataBase.Seeding;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataBase.Context
{
    public class ServerDbContext : DbContext
    {
        public ServerDbContext(DbContextOptions<ServerDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>()
            .HasMany(t => t.Questions)
            .WithOne(q => q.Test)
            .HasForeignKey(q => q.TestId)
            .IsRequired(false);

            modelBuilder.Entity<TestQuestion>()
            .HasMany(t => t.Answers)
            .WithOne(a => a.TestQuestion)
            .HasForeignKey(a => a.TestQuestionId)
            .IsRequired(false);

            modelBuilder.Entity<User>()
            .HasMany(t => t.PassedTestDatas)
            .WithOne(q => q.User)
            .HasForeignKey(q => q.UserId)
            .IsRequired(false);

            modelBuilder.Entity<Test>()
            .HasMany(t => t.PassedTestDatas)
            .WithOne(q => q.Test)
            .HasForeignKey(q => q.TestId)
            .IsRequired(false);

            DataSeeder.SeedData(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestQuestion> TestQuestions { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
    }
}
