using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataBase.Context
{
    public class ServerDbContext : DbContext
    {
        public ServerDbContext(DbContextOptions<ServerDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
