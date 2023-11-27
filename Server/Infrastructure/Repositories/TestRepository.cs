using Domain.Models;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class TestRepository : Repository<Test>, ITestRepository
    {
        public TestRepository(DbContext context) : base(context)
        {

        }
        public Test GetTestsWithRelatedData(long id)
        {
            return _context.Set<Test>().Include(t => t.Questions).Single(s => s.Id == id);
        }

        public IEnumerable<Test> GetTestsWithRelatedData()
        {
            return _context.Set<Test>().Include(t => t.Questions);
        }
    }
}
