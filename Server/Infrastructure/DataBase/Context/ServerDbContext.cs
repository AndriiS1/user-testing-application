using Domain.Models;
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
            modelBuilder.Entity<User>()
                .HasOne(u => u.RefreshTokenData)
            .WithOne(d => d.User)
                .HasForeignKey<RefreshTokenData>(e => e.UserId)
                .IsRequired(false);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<RefreshTokenData> RefreshTokens { get; set; }
    }
}
