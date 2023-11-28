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
        public IEnumerable<TestQuestion> GetQuestionsWithAnswers(long testId)
        {
            return _context.Set<TestQuestion>().Include(t => t.Answers);
        }

        public IEnumerable<Test> GetTestsWithRelatedData()
        {
            return _context.Set<Test>().Include(t => t.Questions);
        }
    }
}
