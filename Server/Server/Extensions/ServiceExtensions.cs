using Infrastructure.DataBase.Context;
using Microsoft.EntityFrameworkCore;

namespace ServerPesentation.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureDB(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<ServerDbContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("Database")));
        }
    }
}
