using Domain.Models;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class PassedTestDataRepository : Repository<PassedTestData>, IPassedTestDataRepository
    {
        public PassedTestDataRepository(DbContext context) : base(context)
        {

        }
    }
}
